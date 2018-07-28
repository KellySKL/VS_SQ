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
    public partial class 旧件终审 : Form
    {
        List<m_rukukuinfo> Dt;
        public bool doBack = false;
     
        int id;
 
        TextBox Tbnum = new TextBox();
        TextBox Tbinfo = new TextBox();
        Label Btn = new Label();
 
 
        Label info = new Label(); //获取责任人和工时
        string Wxman = string.Empty;//维修人员
        string wxDD = string.Empty;
        string CfBmn = string.Empty;
        decimal Wxtime = 0;
        /// <summary>
        /// 客户
        /// </summary>
        string Kf;//客户
 
        /// <summary>
        /// 信息反馈
        /// </summary>
        TextBox Setinfo = new TextBox();
       
        public 旧件终审(int _id,string _kf)
        {
            id = _id;
            Kf = _kf;
            InitializeComponent();
            Skin.NewFrom(this, _kf, 7);
            Width = 450;
            Height = 10;
            ShowDialog();
        }

        private void 旧件终审_Load(object sender, EventArgs e)
        {

            m_rukukuinfo  mr = new m_rukukuinfo();
            Dt = mr.Select("and id =" + id);

            int toHeig = 50;

            //基础信息
            string zRumm = string.Format("维修部门[{0}] 维修人[{1}] 类型[{2}] 工时[{3}]", Dt[0].责任部门, Dt[0].责任人, Dt[0].维修类型, Dt[0].要求时间);
            string sNumm = string.Format("物料[{0}] 类型[{1}] 数量[{2}]", Dt[0].物料, Dt[0].借用类型, Dt[0].数量);
    
            Skincss.AddLable(this, " > "+ sNumm, "10/" + toHeig, (Width - 20) + "/30", "#100100100", 10, "", 0, -1, false, "#240240240");
            toHeig += 40;
            Skincss.AddLable(this, " > " + zRumm, "10/" + toHeig, (Width - 20) + "/30", "#100100100", 10, "", 0, -1, false, "#240240240");
 

            toHeig += 40;
            info = Skincss.AddLable(this, "", "10/" + toHeig, (Width - 20) + "/30", "#100100100", 10, "", 0, -1, false, "#240240240");

            toHeig = 170;
            Label titile = new Label();


            if (Dt[0].处罚部门  == null)
            {
            Label Cf = Skincss.AddLable(this, "处罚", (Width - 70) + "/" + toHeig, "60/30", "#255255255", 10, "", 1, -1, false, Skin.upBColor);
            Cf.Click += Cf_Click;
            }
            string isButname = "取消";
            string isButBcolor = "#220220220";
            string isButFcolor = "#100100100";
            if (Dt[0].终判类型 == null)
            {
                Label Bf = Skincss.AddLable(this, "报废", "10/" + toHeig, "60/30", "#255255255", 10, "", 1, -1, false, Skin.upRcolor);
                Bf.Click += Bf_Click; ;
                Label Hg = Skincss.AddLable(this, "合格", "80/" + toHeig, "60/30", "#255255255", 10, "", 1, -1, false, Skin.upYcolor);
                Hg.Click += Hg_Click;

            }
            else {
                isButname = Dt[0].终判类型.ToString();
                isButFcolor = "#255255255";
                if (isButname== "报废") isButBcolor = Skin.upRcolor;
                if (isButname== "合格") isButBcolor = Skin.upYcolor;
            }
            toHeig += 40;
            titile = Skincss.AddLable(this, "维修信息总结", "10/" + toHeig, "140/30", "#100100100");
            toHeig += 40;
            Setinfo = Skincss.AddTxt(this, "Setinfo", "无", "10/" + toHeig, (Width - 20) + "/160", "#100100100", 10, -1, true);
            toHeig += 130;
            Height += toHeig + 60;
            Btn = Skincss.AddLable(this, isButname, "10/" + (Height - 60), (Width - 20) + "/50", isButFcolor, 10, "", 1, -1, false, isButBcolor);
            Btn.Click += Btn_Click;  
        }

        private void Cf_Click(object sender, EventArgs e)
        {
            string str = string.Empty;


            List<string> Gys = new List<string>
            {
                "供应商问题",
                "客户问题",
                "售后部门",
                "生产部门"
            };
            Msg m = new Msg(Msg._Type.单选, "请选择相关责任人", "责任人", 1, "320/80", "确定/取消", Gys, 4, 120);
            if (m.Msg_button == "确定")
            {
                info.Text = "";
                info.Controls.Clear();
                CfBmn = m.Msg_Value_str;
                if (m.Msg_Value_str == "售后部门") str = "'维修员','服务部经理'";
                if (m.Msg_Value_str == "生产部门") str = "'电器员工','电器主管','机械员工','机械主管'";
                if (m.Msg_Value_str == "客户问题" || m.Msg_Value_str == "供应商问题")
                {
                    info.Text = Kf;
                    Label gs = Skincss.AddLable(info, "费用:", "right", "160/30", "#100100100", 10, "", 0);
                    TextBox box = Skincss.AddTxt(gs, "Wxgs", "0", "right", "120/30", Skin.upBColor, 18);
                    box.TextChanged += Box_TextChanged;
                   
                }
                else {
                    SetManlist(str);
                }
 
               

            }
           
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //处罚人     
            //处罚费用   不为空
            //----------------------------

            Label Tb = sender as Label ;
            Tb.Enabled = false;
            if (Tb.Text == "取消") {
                doBack = false;
                Close();
            }
            
            //if (Wxman == "") {
            //    Msg cc = new Msg(3, "没有判定处罚人！单据无法继续");
            //    Tb.Enabled = true;
            //    return;
            //}

            if (Setinfo.Text.Trim() == "")
            {
                Msg cc = new Msg(3, "没有维修信息总结！单据无法继续");
                Tb.Enabled = true;
                return;
            }
            //m_rukuku mr = new m_rukuku();
            //mr.IS完成 = 3;

            //------------------
            m_rukukuinfo mp = new m_rukukuinfo
            {
                终判类型 = Tb.Text.Trim(),
                终判信息 = Setinfo.Text.Trim(),
                处罚费用 = Wxtime,
                处罚人 = Wxman,
                处罚部门 = CfBmn,
                IS完成 = 3
            };
            mp.Updata("and id=" + id);
           // mr.Updata("and id=" + Dt[0].FID);
            //-------------------
            doBack = true;
            Close();
        }
  
        private void Hg_Click(object sender, EventArgs e)
        {
            SetCFtxt(sender as Label);
        }

        private void Bf_Click(object sender, EventArgs e)
        {
            SetCFtxt(sender as Label);
        }
 
        private void SetManlist(string strlist)
        {
            puku pk = new puku();
            //下次改写，全局读取用户，然后选择用户，最好提升到系统级别读取用户，因为使用频率非常高。
            List<puku> lpk = pk.Select("and dept in (" + strlist + ") and isStop <>'是'");
            List<string> Gys = (from r in lpk select r.TURENAME).ToList();
            Msg m = new Msg(Msg._Type.单选, "请选择相关责任人", "责任人", 1, "320/80", "确定/取消", Gys, 4, 120);
            if (m.Msg_button == "确定")
            {
                Wxman = m.Msg_Value_str;
                info.Text = "维修员:[" + m.Msg_Value_str + "]";
                Label gs = Skincss.AddLable(info, "费用:", "right", "160/30", "#100100100", 10, "", 0);
                TextBox box = Skincss.AddTxt(gs, "Wxgs", "0", "right", "120/30", Skin.upBColor, 18);
                box.TextChanged += Box_TextChanged;
            }
        }
        private void SetCFtxt(Label cl)
        {
            Btn.Text = cl.Text;
            Btn.BackColor = cl.BackColor;
            Btn.ForeColor = cl.ForeColor;
        }
        private void Box_TextChanged(object sender, EventArgs e)
        {

            Wxtime = Ifnn.CheaTxttoini((sender as TextBox), Wxtime);

           
        }









    }
}
