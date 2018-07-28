using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using makelanlan;


namespace 售后
{
    public partial class 维修报告 : Form
    {
        private int id;
        private string Kf=string.Empty;
        /// <summary>
        /// 快递控件
        /// </summary>
        List<string> Kdlist = new List<string>();
        private bool isOpenTre = false; //true 是快递信息
        /// <summary>
        /// 快递信息内容区域
        /// </summary>
        private Panel Kdinfo = new Panel();
        public bool doBack = false;
        /// <summary>
        /// 信息反馈
        /// </summary>
        TextBox Setinfo = new TextBox();
        int toHeig = 50;
        Label Btn = new Label();
        decimal Wxtime=0;
        List<m_rukukuinfo> Dt;

        private string Isgys = string.Empty;

        bool IsNextup = false;
        int Isw = 0;

        Label GysWxf = new Label();

        public 维修报告(int _id, string _kf,bool isopen=false)
        {
            id = _id;
            Kf = _kf;
            isOpenTre = isopen;
            InitializeComponent();
            Skin.NewFrom(this, _kf, 7);
            Width = 380;
            Height = 0;
            ShowDialog();
        }

        private void 维修报告_Load(object sender, EventArgs e)
        {
            m_rukukuinfo mr = new m_rukukuinfo();
            Dt = mr.Select("and id =" + id);
            Label titile = new Label();
            if (Dt[0].处罚部门 == "供应商问题" || Dt[0].责任部门 == "采购部") IsNextup = true;
          if (isOpenTre)
            {
                Label kd = Skincss.AddLable(this, "快递", "10/" + toHeig, "60/30", "#100100100", 10, "", 1, -1, false, "#220220220");
                kd.Click += Kd_Click;
                Label hy = Skincss.AddLable(this, "货运", "80/" + toHeig, "60/30", "#100100100", 10, "", 1, -1, false, "#220220220");
                hy.Click += Hy_Click;
                toHeig += 40;
                Kdinfo.Top = toHeig;
                Kdinfo.Left = 1;
                Kdinfo.Width = (Width-2);
                Kdinfo.Parent = this;
                SetControls(true);
            }
            else
            {
                Label Bf = Skincss.AddLable(this, "报废", "10/" + toHeig, "60/30", "#255255255", 10, "", 1, -1, false, Skin.upRcolor);
                Bf.Click += Bf_Click;
                Label Hg = Skincss.AddLable(this, "合格", "80/" + toHeig, "60/30", "#255255255", 10, "", 1, -1, false, Skin.upYcolor);
                Hg.Click += Hg_Click;
                int ctoHeig = toHeig;
                toHeig += 40;
                titile = Skincss.AddLable(this, "维修反馈信息", "10/" + toHeig, "140/30", "#100100100");
                toHeig += 40;
                Setinfo = Skincss.AddTxt(this, "Setinfo", "无", "10/" + toHeig, (Width - 20) + "/160", "#100100100", 10, -1, true);
                toHeig += 130;
                Height += toHeig + 60;
                Btn = Skincss.AddLable(this, "取消", "10/" + (Height - 60), (Width - 20) + "/50", "100100100", 10, "", 1, -1, false, "#220220220");
                Btn.Click += Btn_Click;

                if (IsNextup) {
                 GysWxf = Skincss.AddLable(this, "维修费", "150/" + ctoHeig, "60/30", "#255255255", 10, "", 1, -1, false, Skin.upBColor);
                   // GysWxf.Click += GysWxf_Click;
                    TextBox  Ini_gys = Skincss.AddTxt(this, "Ini_gys", "0", "220/" + ctoHeig,  "120/30", "#100100100", 14, -1, true);
                    Ini_gys.TextChanged += Ini_gys_TextChanged;
                    if (Dt[0].终判类型 == "报废") Bf_Click(Bf, null);
                    if (Dt[0].终判类型 == "合格") Hg_Click(Hg, null);
                }

           

     
            }

            
      


        }

        private void GysWxf_Click(string  cType)
        {
 
            if (cType == "退款") {
                Isw = -1;
                GysWxf.Text = "退款";
            } else {
                GysWxf.Text = "维修费";
                Isw = 1;
            }

        }

        private void Ini_gys_TextChanged(object sender, EventArgs e)
        {
          
                Wxtime = Ifnn.CheaTxttoini((sender as TextBox), Wxtime);
          
        }

   
        private void Hy_Click(object sender, EventArgs e)
        {
            SetControls(false);
            
        }

        private void Kd_Click(object sender, EventArgs e)
        {
            SetControls(true);
        }

        private void  SetControls(bool isOpenName) {
            Height = 0;
            toHeig = 50;
            int Toh = 0;
            Kdinfo.Controls.Clear();
            Kdlist.Clear();
            if (isOpenName)
            {
                Kdlist.Add("快递单号");
                Kdlist.Add("快递公司");
                Kdlist.Add("供应商");
                Kdlist.Add("联系人");
                Kdlist.Add("联系电话");
                Kdlist.Add("预计到达时间");
                Kdlist.Add("费用");
                Kdlist.Add("其他信息");
            }
            else {
                Kdlist.Add("货车车牌");
                Kdlist.Add("司机姓名");
                Kdlist.Add("司机电话");
                Kdlist.Add("供应商");
                Kdlist.Add("联系人");
                Kdlist.Add("联系电话");
                Kdlist.Add("费用");
                Kdlist.Add("其他信息");
            }
         
            int lastTinfo = 0;
            for (int i = 0; i < Kdlist.Count; i++) {
                Skincss.AddLable(Kdinfo,  Kdlist[i], "10/" + Toh, (Width - 20) + "/25", "#100100100");
                Toh += 25;
                if (i == (Kdlist.Count - 1)) lastTinfo = 45;
                Skincss.AddTxt(Kdinfo, "Tx_"+Kdlist[i], "无", "10/" + Toh, (Width - 20) + "/" +(25+ lastTinfo), "#100100100");
                Toh += (35+ lastTinfo);
            }
            Kdinfo.Controls["Tx_供应商"].Click += 维修报告_Click;
            Kdinfo.Controls["供应商"].ForeColor = Skin.Set_Color(Skin.upRcolor);
            toHeig += Toh;
            Kdinfo.Height = Toh;
            Height += toHeig + 100;
            Btn = Skincss.AddLable(this, "记录", "10/" + (Height - 60), (Width - 20) + "/50", "#255255255", 10, "", 1, -1, false, Skin.upBColor);
            Btn.Click += Btn_Click2;

        }

        private void 维修报告_Click(object sender, EventArgs e)
        {
            string sql = "select NAME as 简称,FULLNAME as 全称 from waixieku where TRADETYPENAME ='原材料供应商' and FULLNAME <>''";
            DataTable mm = (DataTable)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Table, sql);
            Msg err = new Msg("选择供应商", 1, "供应商", "600/320", "选择/关闭")
            {
                isPage = true,
                Pnum = 100,
                DataName = "waixieku_旧件返修_供应商维修"
            };
            err.Msg_data(mm);
            err.ShowDialog();
            if (err.Msg_button == "选择") {
                Isgys = err.Msg_Value_datatable.Rows[0][1].ToString();
                (sender as TextBox).Text = Isgys;
            } 
        }

        private void Btn_Click2(object sender, EventArgs e)
        {
            Label Tb = sender as Label;

            if (Tb.Text == "取消")
            {
                doBack = false;
                Close();
                return;
            }
            //供应商采购信息
            if (Isgys =="") {
                Msg pp = new Msg(3, "系统无法检测到供应商名称！单据无法进行！");
                Kdinfo.Controls["Tx_供应商"].Text = "";
                Kdinfo.Controls["Tx_供应商"].Focus();
                return;
            }

            m_rukukuinfo mrifo = new m_rukukuinfo();
          
                string upSql = string.Empty;
                for (int i = 0; i < Kdlist.Count; i++)
                {
                    upSql += Kdlist[i] + ":" + Kdinfo.Controls["Tx_" + Kdlist[i].ToString().Trim()].Text;
                    if (i < (Kdlist.Count - 1)) upSql += "@";
                }
                mrifo.快递信息 = upSql;
                mrifo.处罚人 = Isgys;



            Tb.Enabled = false;
            Tb.Text = "正在处理数据中...";
            mrifo.Updata("and id=" + id);
            doBack = true;
            Close();
            //保存逻辑
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Label Tb= sender as Label;
           
            if (Tb.Text == "取消") {
                doBack = false ;
                Close();
                return;
            }
            //供应商采购信息
            m_rukukuinfo mrifo = new m_rukukuinfo();
            if (IsNextup)
            {
                mrifo.过程信息 = Setinfo.Text.Trim();
                mrifo.处罚费用 = Wxtime * Isw;
                mrifo.终判类型 = Tb.Text.Trim();
                mrifo.IS完成 = 3;
            }
            else {
                mrifo.过程信息 = Setinfo.Text.Trim();
                mrifo.维修类型 = Tb.Text.Trim();
                mrifo.IS完成 = 1;
            }
 

            Tb.Enabled = false;
            Tb.Text = "正在处理数据中...";
            mrifo.Updata("and id=" + id);

            if (IsNextup) {
                //处理退款流程
                string mcode = IData.GetCode("chuna_cukuKu", "ZF");
                chuna_cukuKu cc = new chuna_cukuKu();
                cc.CODE = mcode;
                cc.BILLTYPE = "维修退款";
                cc.BILLDATE = SysTime.GetTime;
                cc.CLIENT = Dt[0].处罚人;
                cc.TAXRATE = 0;
                cc.TAXTYPE = "";
                cc.PAYTYPE = "";
                cc.BILLMAN = UserInfo.UName;
                cc.AUDITING = "";
                cc.INTRODUCER = UserInfo.UName;
                cc.INTRODUCERDATE = SysTime.GetTime;
                cc.BILLNOTE = "";
                cc.STORAGENAME = "";
                cc.MATERIALCODE = Dt[0].编号;
                cc.MATERIALNAME = Dt[0].物料;
                cc.SPECS = Dt[0].物料型号;
                cc.UNITNAME = Dt[0].单位;
                cc.QUANTITY = Dt[0].数量;
                cc.ORIGPRICE = 0;
                cc.PRICE = 1;
                cc.AMOUNT = Wxtime * Isw;
                cc.REFERQTY = 0;
                cc.KILLBILLQTY = 0;
                cc.PAYEDAMOUNT = 0;
                cc.REMARK ="";
                cc.BATCHNUMBER = Dt[0].维修单;
                cc.REFERCODE = "";
                cc.DISCOUNT = 0;
                cc.BOXES = 0;
                cc.GUSERDEF3 = "采购部";
                cc.Insert();
            }


            doBack = true;
            Close();
            //保存逻辑
        }

        private void SetCFtxt(Label cl)
        {
            Btn.Text = cl.Text;
            Btn.BackColor = cl.BackColor;
            Btn.ForeColor = cl.ForeColor;
        }
        private void Hg_Click(object sender, EventArgs e)
        {
            if (IsNextup) GysWxf_Click("维修费");
            SetCFtxt(sender as Label);
        }

        private void Bf_Click(object sender, EventArgs e)
        {
            if (IsNextup) GysWxf_Click("退款");
            SetCFtxt(sender as Label);
        }
    }
}
