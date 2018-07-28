 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using makelanlan;


namespace 售后
{
    public partial class 旧件处理 : Form
    {
        List<m_rukuku> Dt;
        public bool doBack = false;
  
        int id;
        /// <summary>
        /// 处理量
        /// </summary>
        decimal num = 0;
        /// <summary>
        /// 当前待处理量
        /// </summary>
        decimal oldNum = 0;
        TextBox Tbnum = new TextBox();
        TextBox Tbinfo = new TextBox();
        //计划时间
        TextBox Jhtime = new TextBox();
        Label Jhtime_lab = new Label();
        //时间控件
        IMrili BigMli;
        Label Btn = new Label();
        /// <summary>
        /// 流程指向
        /// </summary>
        int isWc = 0;
        Label info = new Label(); //获取责任人和工时
        string Wxman = string.Empty;//维修人员
        string wxDD = string.Empty;
        decimal Wxtime = 0;
        /// <summary>
        /// 客户
        /// </summary>
        string Kf;//客户
        /// <summary>
        /// 维修类型
        /// </summary>
        string typ = "";  //维修类型
        /// <summary>
        /// 责任部门
        /// </summary>
        string Ctyp = "";  //责任部门

        /// <summary>
        /// 处罚人
        /// </summary>
        string Cfmen = "";
        /// <summary>
        /// 处罚部门
        /// </summary>
        string CfBmn = "";

        public 旧件处理(int _id, Decimal _Nums,string _kf)
        {
            id = _id;
            num = _Nums;
            oldNum = _Nums;
            Kf = _kf;
            InitializeComponent();
            Skin.NewFrom(this, _kf, 7);
            ShowDialog();
        }
 
        private void 旧件处理_Load(object sender, EventArgs e)
        {
            m_rukuku mr = new m_rukuku();
            Dt= mr.Select("and id =" + id);

            int toHeig = 50;
            string sNumm = string.Format("待处理[{0}] 已处理[{1}] 总量[{2}]", oldNum, Dt[0].已处理, Dt[0].数量);

            Skincss.AddLable(this, " > 单据编号：" + Dt[0].CODE + "[" + Dt[0].机床码 + "]" + "[" + Dt[0].质保 + "]", "10/"+ toHeig, "426/30", "#100100100", 10, "", 0, -1, false, "#240240240");
            toHeig += 40;
            Skincss.AddLable(this, " > 物料名称：" + Dt[0].物料+"["+Dt[0].借用类型+"]", "10/"+ toHeig, "426/30", "#100100100", 10, "", 0, -1, false, "#240240240");
            toHeig += 40;
            Skincss.AddLable(this, " > " + sNumm, "10/"+ toHeig, "426/30", "#100100100", 10, "", 0, -1, false, "#240240240");

            toHeig = 170;
            Label Cg = Skincss.AddLable(this, "供应商维修", "70/" + toHeig, "90/30", "#255255255", 10, "", 1, -1, false, Skin.upBColor);
            Cg.Click += Cg_Click;
            Label Cj = Skincss.AddLable(this, "车间维修", "180/" + toHeig, "90/30", "#255255255", 10, "", 1, -1, false, Skin.upBColor);
            Cj.Click += Cj_Click;
            Label Sh = Skincss.AddLable(this, "售后维修", "286/" + toHeig, "90/30", "#255255255", 10, "", 1, -1, false, Skin.upBColor);
            Sh.Click += Sh_Click;
            Label Bf = Skincss.AddLable(this, "报废", "10/" + toHeig, "50/30", "#255255255", 10, "", 1, -1, false, Skin.upRcolor);
            Bf.Click += Bf_Click;
            Label Hg = Skincss.AddLable(this, "合格", "385/" + toHeig, "50/30", "#255255255", 10, "", 1, -1, false, Skin.upYcolor);
            Hg.Click += Hg_Click;
            toHeig += 40;
            Skincss.AddLable(this, "处理量", "10/" + toHeig, "300/30", "#100100100");
            toHeig += 30;
            Tbnum = Skincss.AddTxt(this, "Tbnum", (Dt[0].数量 - Dt[0].已处理).ToString(), "10/" + toHeig, "426/25", Skin.upRcolor, 14);
            Tbnum.TextChanged += Tbnum_TextChanged;
            toHeig += 30;
            Skincss.AddLable(this, "处理依据", "10/" + toHeig, "300/30", "#100100100");
            toHeig += 30;
            Tbinfo = Skincss.AddTxt(this, "Tbinfo", "无", "10/" + toHeig, "426/120","#100100100",10,-1,true);
            toHeig += Tbinfo.Height +10 ;



            //日期处理
            Jhtime_lab= Skincss.AddLable(this, "要求完成时间:", "10/" + toHeig, "120/30", "#100100100");
            Jhtime = Skincss.AddTxt(this, "Jhtime", "", "130/" + toHeig, "200/24", "#100100100", 12, -1, true);
            BigMli = new IMrili(Jhtime, "0/40", Jhtime.Width + "/180", DateTime.Now, 8, false,1,null, GetTexinfo);
             


            info = Skincss.AddLable(this, " ", "10/" + (Height - 100), "426/30", "#100100100", 10, "", 0);
            Btn = Skincss.AddLable(this, "取消", "10/"+(Height -60),  "426/50", "#100100100", 10, "", 1, -1, false, "#220220220");
            Btn.Click += Btn_Click;


 
        }
        private void GetTexinfo() {
            DateTime DD = new DateTime();
            DD = BigMli.DValue;
            if (DD > SysTime.GetTime)
            {
                Jhtime.Text = DD.ToString("yyyy-MM-dd");
            }
        }

        private void Tbnum_TextChanged(object sender, EventArgs e)
        {
            num = Ifnn.CheaTxttoini((sender as TextBox),num, oldNum);
                if (num > oldNum)
                {
                    Msg Err = new Msg(3, "当前数量已超过系统允许的数量！\n\r 请输入<=" + oldNum +"的数量","数量错误",1 );
                    (sender as TextBox).Text = oldNum.ToString();
                    num = oldNum;
                }
                else {
                    num = decimal.Parse((sender as TextBox).Text);
                }
        }

        private void Box_TextChanged(object sender, EventArgs e)
        {
            Wxtime = Ifnn.CheaTxttoini((sender as TextBox), Wxtime);
 
        }
        private void SetCFtxt(Label cl)
        {
            if (cl.Text == "报废" || cl.Text == "合格") {
                Jhtime.Visible = false;
                Jhtime_lab.Visible = false;
                Jhtime.Text = SysTime.GetTime.ToString("yyyy-MM-dd");
            } else {
                Jhtime.Visible = true ;
                Jhtime_lab.Visible = true ;
            }
            Btn.Text = cl.Text;
            Btn.BackColor = cl.BackColor;
            Btn.ForeColor = cl.ForeColor;
            info.Controls.Clear();
            info.Text = "";
            Wxtime = 0;
            Wxman = string.Empty;
            typ = "";
            Ctyp = "";
            isWc = 0;
        }

        private void SetManlist(string strlist) {
            puku pk = new puku();
            List<puku> lpk = pk.Select("and dept in ("+ strlist + ") and isStop <>'是'");
            List<string> Gys = (from r in lpk select r.TURENAME).ToList();
            Msg m = new Msg(Msg._Type.单选, "请选择相关责任人", "责任人", 1, "320/80", "确定/取消", Gys, 4, 120);
            if (m.Msg_button == "确定")
            {
                Wxman = m.Msg_Value_str;
                info.Text = "维修员:[" + m.Msg_Value_str + "]";

                Label gs = Skincss.AddLable(info, "工时:", "right", "160/30", "#100100100", 10, "", 0);
                TextBox box = Skincss.AddTxt(gs, "Wxgs", "0", "right", "120/30", Skin.upBColor,18);
                box.TextChanged += Box_TextChanged;
            }
        }


        private void Sh_Click(object sender, EventArgs e)
        {
            SetCFtxt(sender as Label);
            SetManlist("'维修员','服务部经理'");
            typ = "维修";
            Ctyp = "售后部";
        }
        private void Cj_Click(object sender, EventArgs e)
        {
            SetCFtxt(sender as Label);
            SetManlist("'电器员工','电器主管','机械员工','机械主管'");
            typ = "维修";
            Ctyp = "生产部";
        }

        private void Hg_Click(object sender, EventArgs e)
        {
            
            SetCFtxt(sender as Label);
            Wxman = Dt[0].维修人;
            info.Text = "责任人:["+ Dt[0].维修人 + "]";
            typ = "合格";
            Ctyp = "售后部";
            Cfmen = Dt[0].维修人;
            CfBmn = "售后部";
            isWc = 1;
        }

        private void Bf_Click(object sender, EventArgs e)
        {
            SetCFtxt(sender as Label);
            List<string> Gys = new List<string>();

            if (Dt[0].借用类型=="新件维修") {
                Gys.Add("仓库问题");
                Gys.Add("售后部门");
                Gys.Add("生产部门");
            }
            else{
                Gys.Add("客户问题");
                Gys.Add("售后部门");
                Gys.Add("生产部门");
            }
  
            Msg m = new Msg(Msg._Type.单选, "请选择相关责任部门：", "选择部门", 1, "320/80", "确定/取消", Gys, 4, 120);
            if (m.Msg_button =="确定") {
                if (m.Msg_Value_str == "供应商问题")
                {
                    Wxman = "谷力振";
                    info.Text = "负责人:[谷力振]";
                    Ctyp = "采购部";
                    Cfmen = "供应商";
                    CfBmn = "供应商问题";
                    
                }
                else if (m.Msg_Value_str == "仓库问题")
                {
                    Wxman = "卢龙";
                    info.Text = "责任人:[卢龙]";
                    Ctyp = "仓库";
                    Cfmen = "卢龙";
                    CfBmn = "仓库";
                    isWc = 1;
                }
                else if (m.Msg_Value_str == "售后部门")
                {
                    Wxman = Dt[0].维修人;
                    info.Text = "负责人:[" + Dt[0].维修人 + "]";
                    Ctyp = "售后部";
                    Cfmen = Dt[0].维修人;
                    CfBmn = "售后部";
                    isWc = 1;
                }
                else if (m.Msg_Value_str == "生产部门") {

                    puku pk = new puku();
                    List<puku> lpk = pk.Select("and dept in ('电器员工', '电器主管', '机械员工', '机械主管') and isStop <>'是'");
                    List<string> vv  = (from r in lpk select r.TURENAME).ToList();
                    Msg xm = new Msg(Msg._Type.单选, "请选择相关责任人：", "选择责任人", 1, "320/80", "确定/取消", vv, 4, 120);
                    if (xm.Msg_button == "确定")
                    {
                        Wxman = xm.Msg_Value_str;
                        info.Text = "负责人:[" + xm.Msg_Value_str + "]";
                        Ctyp = "生产部";
                        Cfmen = xm.Msg_Value_str;
                        CfBmn = "生产部";
                        isWc = 1;

                    }

                    }
                else
                {
                    Wxman = Kf;
                    info.Text = "责任单位:[" + Kf + "]";
                    Ctyp = m.Msg_Value_str;
                    Cfmen = Kf;
                    CfBmn = "客户问题";
                    isWc = 3;
                }
                
            }

            typ = "报废";
        }



        private void Cg_Click(object sender, EventArgs e)
        {
            SetCFtxt(sender as Label);
            Wxman = "谷力振";
            info.Text = "维修员:[谷力振]";
            typ = "维修";
            Ctyp = "采购部";
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Label btnn = sender as Label;
            if (btnn.Text == "取消") {
                doBack = false;
                Close();
            }
            if (Jhtime.Text=="") {
                Msg Er = new Msg(3, "请选择(要求完成时间)");
                return;
            }
            if (Tbinfo.Text == "") {
                Msg Er = new Msg(3, "请输入(处理依据)");
                return;
            }

            if (Wxman=="") {
                Msg Er = new Msg(3, "请选择(责任人)");
                return;
            }

            btnn.Text = "正在保存数据中...";
            btnn.Enabled = false;

            //拆单逻辑
            for (int i =1; i<= num;i++) { 
            //保存逻辑
            m_rukukuinfo minfo = new m_rukukuinfo
            {
                FID = id,
                物料= Dt[0].物料,
                物料型号= Ifun.IsDBnull(Dt[0].物料型号," ").ToString(),
                编号= Dt[0].编号,
                单位= Dt[0].单位,
                借用类型 =Ifun.IsDBnull(Dt[0].借用类型,"无借用").ToString(),
                维修类型 = typ,
                预警时间 =DateTime.Parse(Jhtime.Text),
                责任部门 = Ctyp,
                责任人 = Wxman,
                处罚部门 = CfBmn,
                处罚人 = Cfmen,
                判断时间 = SysTime.GetTime,
                处理意见 = Tbinfo.Text.Trim(),
                数量 = 1,
                维修单 = Dt[0].维修单 ,
                IS完成 = isWc,
                要求时间 = Wxtime,
            };
           
            if (typ == "报废" || typ == "合格")
            {

                minfo.终判类型 = typ;
                minfo.过程信息 = Tbinfo.Text.Trim();
            }
            minfo.Insert();
            }


            doBack = true;
            //更新原数据条
            m_rukuku mr = new m_rukuku
            {
                已处理 = Dt[0].已处理 + num
            };
            mr.Updata("and id=" + id);
            Close();
        }

   

    
 
   

     
    }
}
