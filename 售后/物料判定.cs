using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using makelanlan;

namespace 售后
{
    public partial class 物料判定 : Form
    {
        public 物料判定(int _id, string _kf)
        {
            id = _id;
            Kf = _kf;
            InitializeComponent();
            Skin.NewFrom(this, _kf, 7);
            Width = 600;
            Height = 10;
            ShowDialog();
        }

        /// <summary>
        ///  申请免费
        /// </summary>
        Label MF = new Label();
        /// <summary>
        /// 申请优惠
        /// </summary>
        Label YH = new Label();

        List<m_rukukuinfo> Dt;
        public bool doBack = false;
 
        int id;

        TextBox Tbnum = new TextBox();
        TextBox Tbinfo = new TextBox();
        Label Btn = new Label();

        decimal Getck = 0;
       Label info = new Label(); //获取责任人和工时
        string Wxman = string.Empty;//维修人员
        string wxDD = string.Empty;
        decimal Wxtime = 0;
        /// <summary>
        /// 维修费用
        /// </summary>
        decimal WxFy = 0;
        /// <summary>
        /// 客户
        /// </summary>
        string Kf;//客户

        /// <summary>
        /// 信息反馈
        /// </summary>
        TextBox Setinfo = new TextBox();
        Label makeSay = new Label();

        //------------------------------------
        /// <summary>
        /// 终判类型  合格或是报废
        /// </summary>
        private string Is合格 = string.Empty;
        private string Is借用 = string.Empty;
        private string Is保修 = string.Empty;
        private string Is客户 = string.Empty;

        private bool Is留用 = false;
        private bool Is免费 = false;
        private bool Is新件 = false;
        private bool Is优惠 = false;
 





        private void 物料判定_Load(object sender, EventArgs e)
        {
            m_rukukuinfo mr = new m_rukukuinfo();
            Dt = mr.Select("and id =" + id);
            int toHeig = 50;
            Is合格 = Dt[0].终判类型;
            Is借用 = Dt[0].借用类型;
            Is客户 = Dt[0].处罚部门;
            m_rukuku  bn = new m_rukuku();
            List<m_rukuku> bs=  bn.Select("and id=" + Dt[0].FID);
            Is保修 = bs[0].质保;

            string sNumm = string.Format("{0}/数量:{2}/{1}/{3}", Dt[0].物料, Is借用, Dt[0].数量, Is保修);
            if (Is借用=="新件维修") sNumm = string.Format("{0}/数量:{2}/{1}", Dt[0].物料, Is借用, Dt[0].数量);
            string zRumm = string.Format("由{0}-{1}维修  维修结果为:{2}", Is客户, Dt[0].责任人, Is合格);
            string fNumm = string.Format("处罚部门[{0}] 处罚人[{1}] 费用[{2}]", Dt[0].处罚部门, Dt[0].处罚人, Dt[0].处罚费用);

            if (Is客户=="客户问题")    zRumm = string.Format("由{0}  结果为:{1}", Is客户, Is合格);

            Skincss.AddLable(this, " > " + sNumm, "10/" + toHeig, (Width - 20) + "/30", "#100100100", 10, "", 0, -1, false, "#240240240");
            toHeig += 40;
            Skincss.AddLable(this, " > " + zRumm, "10/" + toHeig, (Width - 20) + "/30", "#100100100", 10, "", 0, -1, false, "#240240240");

            if (Dt[0].处罚部门 !=null) { 
            toHeig += 40;
            Skincss.AddLable(this, " > " + fNumm, "10/" + toHeig, (Width - 20) + "/30", "#100100100", 10, "", 0, -1, false, "#240240240");
            }
            toHeig += 40;
            info = Skincss.AddLable(this, "", "10/" + toHeig, (Width - 20) + "/30", "#100100100", 10, "", 0, -1, false, "#240240240");


            //----------智能提示------------------
            if (Is合格 == "合格")
            {
                string jRumm = "当前物料无借用,请安排人员实施安装！";
                toHeig += 40;
                Label SetWl = Skincss.AddLable(this, " > " + jRumm, "10/" + toHeig, (Width - 20) + "/30", Skin.upRcolor, 10, "", 0, -1, false, "#240240240");
                SetWl.Name = "借用拆回";
                if (Is借用 == "客户借用") {
                    Getck = ReadNum();
                    decimal GetSq = ReadSenqing();

                    if (Getck == 0)
                    {
                        if (GetSq > 0) {
                            SetWl.Text = "已经推送消息给仓库，待仓库入库";
                            SetWl.Click += SetWl_Click;
                        }
                        else{
                            SetWl.Text = "当前物料客户借用，请换回物料！[点击执行]";
                            SetWl.Click += SetWl_Click;
                        }
                    
                    }
                    else {
                        SetWl.Text = "维修人员已换回数量：["+ Getck + "]";
                    }
                   
                } 
                
            }
            //----------智能提示------------------

            

            Label titile = new Label();
            toHeig += 40;
            Label Bf = new Label();
            if (Is合格 == "报废") {
                if (Is借用 =="客户借用") {
                    Bf = Skincss.AddLable(this, "借用件留用", "10/" + toHeig, "120/30", "#100100100", 10, "", 1, -1, false, "#240240240");
                    Bf.Click += Bf_Click;
                } else {
                    Bf = Skincss.AddLable(this, "新物件领用", "10/" + toHeig, "120/30", "#100100100", 10, "", 1, -1, false, "#240240240");
                    Bf.Click += Bf_Click1;
                }
        
            }

            if (Is客户=="客户问题" || Is保修 =="保外") {
            if (Is借用 != "新件维修") { 
            MF = Skincss.AddLable(this, "申请免费", (Width - 180) + "/" + toHeig, "80/30", "#100100100", 10, "", 1, -1, false, "#240240240");
            MF.Click += MF_Click;
 
            YH = Skincss.AddLable(this, "申请优惠", (Width - 90) + "/" + toHeig, "80/30", "#100100100", 10, "", 1, -1, false, "#240240240");
            YH.Click += MF_Click;
            }
                //YH.Click += Cf_Click;
            }




            toHeig += 40;
             Skincss.AddLable(this, "服务费:", "10/" + toHeig, "140/30", "#100100100");
            toHeig += 40;
            TextBox box= Skincss.AddTxt(this, "Setinfo", "0", "10/" + toHeig, (Width - 20) + "/30", Skin.upBColor, 18);
            box.TextChanged += FYBox_TextChanged;

            toHeig += 40;
            titile = Skincss.AddLable(this, "维修总结", "10/" + toHeig, "140/30", "#100100100");
            toHeig += 40;
            Setinfo = Skincss.AddTxt(this, "Setinfo", "无", "10/" + toHeig, (Width - 20) + "/140", "#100100100", 10, -1, true);
            toHeig += 100;
            //------------------------------
            //        给出处理方案
            //------------------------------
         




            toHeig += 40;
            makeSay = Skincss.AddLable(this, BackInfo(), "10/" + toHeig, "140/30", Skin.upBColor);
            makeSay.Click += MakeSay_Click;

            Height += toHeig + 60;
            Btn = Skincss.AddLable(this, "保  存", "10/" + (Height - 60), (Width - 20) + "/50", "#255255255", 10, "", 1, -1, false,Skin.upBColor);
            Btn.Click += Btn_Click;





            if (Is保修 == "保内" && Is合格 == "报废" && Is借用 == "客户借用") {
                Bf_Click(Bf, null);
                Bf.Click -= Bf_Click;
            }
 

         


            }

        private void SetWl_Click(object sender, EventArgs e)
        {
            Add("借用拆回", "-", true, false,0, id);
            Controls["借用拆回"].Text = "消息已经推送到仓库！";
            Controls["借用拆回"].Click -= SetWl_Click;  //按钮失效！
        }
        private decimal ReadSenqing()
        {
            decimal BNum = 0;
            BILLnouse2 r = new BILLnouse2();
            List<BILLnouse2> ru = r.Select("and billtype='借用拆回' and materialcode='" + Dt[0].编号 + "'and FREENUM2='"+id+"' and paytype='" + Dt[0].维修单 + "' ");
            BNum= decimal.Parse((from a in ru select a.QUANTITY).Sum().ToString());
            return BNum;
        }
        private decimal ReadNum() {
            decimal BNum = 0;
            RukuKu   r = new RukuKu();
            List<RukuKu> ru = r.Select("and billtype='售后借用拆回' and FREENUM2='"+ id +"' and materialcode='" + Dt[0].编号+"' and paytype='"+Dt[0].维修单+"' ");
            BNum = decimal.Parse((from a in ru select a.QUANTITY).Sum().ToString());
            return BNum;
        }


        private void Bf_Click1(object sender, EventArgs e)
        {
            //启动当前物料推送
            SetXJtxt(sender as Label);

        }

        private string BackInfo() {
            string zn = string.Empty;
            if (Is借用 != "新件维修") {
            if (Is保修 == "保内") zn = "智能提示：保内免费";
            if (Is保修 == "保外") zn = "智能提示：保外收费";
            if (Is客户 == "客户问题") zn = "智能提示：" + Is保修 + "收费";
            }
            return zn;
        }

        private void MF_Click(object sender, EventArgs e)
        {
            Label cl = sender as Label;
            //  SetManlist("'业务员','销售部经理'");


            if (cl.Text =="申请免费") { 
            if (Is免费) {
                cl.BackColor = Skin.Set_Color("#240240240");
                cl.ForeColor = Skin.Set_Color("#100100100");
                makeSay.Text =  BackInfo();
                Is免费 = false;
                Is优惠 = true;
                info.Controls.Clear();
                info.Text = "";
            } else {

                    //修改申请优惠背景色
                    YH.BackColor = Skin.Set_Color("#240240240");
                    YH.ForeColor = Skin.Set_Color("#100100100");
                    SetManlist("'业务员','销售部经理'");
                    cl.BackColor = Skin.Set_Color(Skin.upBColor);
                cl.ForeColor = Color.White;
                string zn = string.Empty;
                zn = "智能提示：" + Is保修 + "免费";
                makeSay.Text = zn;
                Is免费 = true;
                Is优惠 = false;
                }
            }


            if (cl.Text == "申请优惠")
            {

                if (Is优惠)
                {
                    cl.BackColor = Skin.Set_Color("#240240240");
                    cl.ForeColor = Skin.Set_Color("#100100100");
                    makeSay.Text = BackInfo();
                    Is优惠 = false;
                    Is免费 = true;
                    info.Controls.Clear();
                    info.Text = "";
                }
                else
                {
                    //修改申请优惠背景色
                    MF.BackColor = Skin.Set_Color("#240240240");
                    MF.ForeColor = Skin.Set_Color("#100100100");
                    SetManlist("'业务员','销售部经理'");
                    cl.BackColor = Skin.Set_Color(Skin.upBColor);
                    cl.ForeColor = Color.White;
                    string zn = string.Empty;
                    zn = "智能提示：" + Is保修 + "收费";
                    makeSay.Text = zn;
                    Is免费 = false ;
                    Is优惠 = true ;
                }


            }













            }

        private void MakeSay_Click(object sender, EventArgs e)
        {
            string inp = (sender as Label).Text;
            Msg Minfo = new Msg(0, Ifun.Right(inp, inp.Length - 7), Ifun.Right(Ifun.Left(inp, 6), 4), 1);
        }

  

      

        private void Btn_Click(object sender, EventArgs e)
        {
   
            //----------------------------
            
            Label Tb = sender as Label;
            if (Is合格 == "合格" && Is借用 == "客户借用" && Is留用==false) {
                if (Dt[0].数量 > Getck) {
                    Msg Err = new Msg(3, "未换回客户借用件！请先处理！");
                    return;
                }
            }

            Tb.Enabled = false;
 
            if (Setinfo.Text.Trim() == "")
            {
                Msg cc = new Msg(3, "没有维修信息总结！单据无法继续");
                Tb.Enabled = true;
                return;
            }


            //------------
            //--获取所有记录信息
            
            string SetTo = info.Text + " 优惠金额:" + Wxtime + "，";//发送给配件销售人员

            string Zpsx = SetTo;
             Zpsx += makeSay.Text +"，";
            if (Is留用) Zpsx += UserInfo.UName + "选择借用件留用，";
            if (Is免费) Zpsx += UserInfo.UName + "选择申请免费，";
            if (Is新件) Zpsx += UserInfo.UName + "选择新物件领用，";

           

            // ------物料流向----------
            //第一情况：
            if (Is合格=="合格" && Is借用 =="客户借用") {
                //Add("借用件换回", Zpsx,true,false);
                //Zpsx += "合格+客户借用--无需出库";
                Add("维修零件结算", Zpsx,false,true, WxFy);
                #region 删除
                //RukuKu Rk = new RukuKu();
                //Rk.MATERIALCODE = Dt[0].编号;
                //Rk.REMARK = "";
                //Rk.BOXES = 0;
                //Rk.GUSERDEF3 = "";
                //Rk.PRICE = 0;
                //Rk.AMOUNT = 0;
                //Rk.PAYEDAMOUNT = 0;
                //Rk.PAYTYPE =Dt[0].维修单;
                //Rk.INTRODUCERDATE = SysTime.GetTime;
                //Rk.BILLTYPE = "借用件换回";
                //Rk.ORIGPRICE = 0;
                //Rk.REFERCODE = Dt[0].维修单;
                //Rk.TAXRATE = 0;
                //Rk.BILLNOTE = Zpsx;
                //Rk.SPECS = Dt[0].物料型号;
                //Rk.KILLBILLQTY = 0;
                //Rk.GUSERDEF5 = "";
                //Rk.BILLDATE = SysTime.GetTime;
                //Rk.STORAGEWHERE = "";
                //Rk.UNITNAME = Dt[0].单位;
                //Rk.QUANTITY = Dt[0].数量;
                //Rk.REFERQTY = 0;
                //Rk.BATCHNUMBER = Dt[0].维修单;
                //Rk.GUSERDEF1 = "";
                //Rk.CODE = Mcode;
                //Rk.CLIENT = Kf;
                //Rk.TAXTYPE = "";
                //Rk.BILLMAN = UserInfo.UName;
                //Rk.AUDITING = "系统自动审核";
                //Rk.STORAGENAME = "原材料库";
                //Rk.DISCOUNT = 100;
                //Rk.GUSERDEF2 = "";
                //Rk.GUSERDEF4 = "";
                //Rk.MAXVALUE = "";
                //Rk.FREESTR10 = ","+ Dt[0].维修单;
                //Rk.Insert();
                #endregion
            }

            if (Is合格 == "合格" && Is借用 != "客户借用")
            {
                Zpsx += "维修完成+无借用--无需出库";
                Add("维修零件结算", Zpsx, false, true, WxFy);
            }
            if (Is合格 == "合格" && Is借用 == "新件维修")
            {
              //  Msg Err = new Msg(3, "vvvvvvvvvvvvvvvvvv");
                //Zpsx += "维修完成+无借用--无需出库";
                //Add("维修零件结算", Zpsx, false, true, WxFy);
            }

            if (Is合格 == "报废" && Is借用 == "客户借用")
            {
                string Temp = string.Empty;
                Temp = Zpsx;
                Zpsx = Temp + "报废+客户借用--无需出库";
                Add("维修零件结算", Zpsx, true, true, WxFy);
                Zpsx = Temp + "报废+客户借用--报废件入库";
                Add("售后返厂报废", Zpsx, true, false, 0);
            }

            if (Is合格 == "报废" && Is借用 != "客户借用" && Is借用 != "新件维修")
            {
                Zpsx += "报废+客户借用--必须出库";
                Add("维修零件结算", Zpsx, true, true, WxFy);
            }

            if (Is合格 == "报废" && Is借用 == "新件维修")
            {
                Add("新件维修", Zpsx, true, false, WxFy);
            }

            if (Is新件) {
                Add("售后服务领料", Zpsx, true, false, WxFy);
            }

            m_rukukuinfo mp = new m_rukukuinfo
            {
                物判内容 = Zpsx,
                物判总结 = Setinfo.Text,
                物判费用 = WxFy,
                IS完成 = 4
            };
            mp.Updata("and id=" + id);
            mp.Reset_m_rukukuinfo();

            //---修改单据状态--------
            m_rukukuinfo mc = new m_rukukuinfo();
            m_rukuku mx = new m_rukuku();
            //查询合计数:
            decimal SumUpNum = mc.Select("and is完成=4 and  fid=" + Dt[0].FID).Sum(r => r.数量);
            decimal SumFNum = mx.Select("and id=" + Dt[0].FID).Sum(r => r.数量);
           // Msg A = new Msg(3, "分单总量：" + SumUpNum + "/ 总单数量：" + SumFNum);
            if (SumUpNum == SumFNum)
            {
                mx.Reset_m_rukuku();
                mx.IS完成 = 4;
                mx.Updata("and id=" + Dt[0].FID);
            }

            //m_rukuku mx = new m_rukuku
            //{
            //    IS完成 = 4
            //};
            //mx.Updata("and id=" + Dt[0].FID);
            //-------------------





            //-------------------------
            doBack = true;
            Close();
        }

        private void Add(string 业务类型, string 备注, bool 物料清单 = false, bool 维修费 = false, decimal Fuf = 0,int frNum2=0) {
            string Mcode = IData.GetCode("BILLnouse2", "YL");
            string 审核 = "系统自动审核";
            if (Is免费 || Is优惠 || Is新件) 审核 = "";
            if (物料清单) { 
            BILLnouse2 bl = new BILLnouse2
            {
                CODE = Mcode,
                BILLTYPE = 业务类型,// "借用件换回",
                BILLDATE = DateTime.Now.Date,
                CLIENT = Kf,
                TAXRATE = 1,
                PAYTYPE = Dt[0].维修单,
                BILLMAN = UserInfo.UName,
                BILLNOTE = 备注, //Zpsx,
                STORAGENAME = "",
                STORAGEWHERE = "",
                AUDITING = 审核,
                INTRODUCER = UserInfo.UName,
                INTRODUCERDATE = DateTime.Now,
                FINISHDATE = DateTime.Now,
                MATERIALCODE = Dt[0].编号,
                MATERIALNAME = Dt[0].物料,
                SPECS = Dt[0].物料型号,
                UNITNAME = Dt[0].单位,
                QUANTITY = Dt[0].数量,
                ORIGPRICE = 0,
                PRICE = 0,
                AMOUNT = 0,
                KILLBILLQTY = 0,
                REFERQTY = -1,
                PAYEDAMOUNT = 0,
                BATCHNUMBER = "",
                REFERCODE = Dt[0].维修单,
                DISCOUNT = 100,
                BOXES = 0,
                GUSERDEF1 = "",
                GUSERDEF4 = "",
                GUSERDEF5 = "",
                MAXVALUE = "",
                FREENUM2 =frNum2,
                FREESTR7 = "",
                FREESTR8 = Dt[0].维修单,
                FREESTR9 = Mcode,
                FREESTR10 = "," + Dt[0].维修单,
                引用单号2 = Mcode
            };
            bl.Insert();
            }

            if (维修费) {
                //产生维修服务费
            BILLnouse2 cbl = new BILLnouse2
            {
                CODE = Mcode,
                BILLTYPE = 业务类型,// "借用件换回",
                BILLDATE = DateTime.Now.Date,
                CLIENT = Kf,
                TAXRATE = 1,
                PAYTYPE = Dt[0].维修单,
                BILLMAN = UserInfo.UName,
                BILLNOTE = 备注, //Zpsx,
                STORAGENAME = "",
                STORAGEWHERE = "",
                AUDITING = 审核,
                INTRODUCER = UserInfo.UName,
                INTRODUCERDATE = DateTime.Now,
                FINISHDATE = DateTime.Now,
                MATERIALCODE = "99.001",
                MATERIALNAME = "维修费",
                SPECS ="",
                UNITNAME = "次",
                QUANTITY = 1,
                ORIGPRICE = 0,
                PRICE = Fuf,
                AMOUNT = 0,
                KILLBILLQTY = 0,
                REFERQTY = -1,
                PAYEDAMOUNT = 0,
                BATCHNUMBER = "",
                REFERCODE = Dt[0].维修单,
                DISCOUNT = 100,
                BOXES = 0,
                GUSERDEF1 = "",
                GUSERDEF4 = "",
                GUSERDEF5 = "",
                MAXVALUE = "",
                FREESTR7 = "",
                FREENUM2 = frNum2,
                FREESTR8 = Dt[0].维修单,
                FREESTR9 = Mcode,
                FREESTR10 = "," + Dt[0].维修单,
                引用单号2 = Mcode
            };
            cbl.Insert();

            }
        }

        private void Bf_Click(object sender, EventArgs e)
        {
           SetCFtxt(sender as Label);
        }
        private void SetManlist(string strlist)
        {
            info.Text = "";
            info.Controls.Clear();
            puku pk = new puku();
            //下次改写，全局读取用户，然后选择用户，最好提升到系统级别读取用户，因为使用频率非常高。
            List<puku> lpk = pk.Select("and dept in (" + strlist + ") and isStop <>'是'");
            List<string> Gys = (from r in lpk select r.TURENAME).ToList();
            Msg m = new Msg(Msg._Type.单选, "请选择相关责任人", "责任人", 1, "320/80", "确定/取消", Gys, 4, 120);
            if (m.Msg_button == "确定")
            {
                Wxman = m.Msg_Value_str;
                info.Text = "申请人:[" + m.Msg_Value_str + "]";
                if (Is免费) {
                Label gs = Skincss.AddLable(info, "优惠:", "right", "160/30", "#100100100", 10, "", 0);
                TextBox box = Skincss.AddTxt(gs, "Wxgs", "0", "right", "120/30", Skin.upBColor, 18);
                box.TextChanged += Box_TextChanged;
                }
            }
        }
        private void SetCFtxt(Label cl)
        {

            if (Is留用)
            {
                cl.BackColor = Skin.Set_Color("#240240240");
                cl.ForeColor = Skin.Set_Color("#100100100");
                Is留用 = false;
            }
            else
            {
                cl.BackColor = Skin.Set_Color(Skin.upBColor);
                cl.ForeColor = Color.White;
                Is留用 = true;
            }


        }
        private void SetXJtxt(Label cl)
        {

            if (Is新件)
            {
                cl.BackColor = Skin.Set_Color("#240240240");
                cl.ForeColor = Skin.Set_Color("#100100100");
                Is新件 = false;
            }
            else
            {
                cl.BackColor = Skin.Set_Color(Skin.upBColor);
                cl.ForeColor = Color.White;
                Is新件 = true;
            }


        }
        

        /// <summary>
        /// 处理客户优惠
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_TextChanged(object sender, EventArgs e)
        {
            Wxtime= Ifnn.CheaTxttoini((sender as TextBox), Wxtime);
            
        }

        /// <summary>
        /// 处理维修费用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FYBox_TextChanged(object sender, EventArgs e)
        {
            WxFy = Ifnn.CheaTxttoini((sender as TextBox), WxFy);
        }

        private void 物料判定_Shown(object sender, EventArgs e)
        {
            Top = Skin.hScreen / 2-Height/2;
            Left = Skin.wScreen / 2 - Width / 2;
        }
    }
}
