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
    public partial class 获取单据 : Form
    {
        List<clientservice_AfterServiceBill> Wxinfo;
        private string GetDgvCodelist = string.Empty;
        private int id;
        public decimal num;
        private MTable Dg = new MTable();
        private Label Lis = new Label();
        private Panel panel2 = new Panel();
        private Splitter Sp = new Splitter();
        private string Sx = "";
        TextBox SearchBo = new TextBox();
 
        Label lb = new Label();
        Label lb1 = new Label();
        Label lb2 = new Label();
        Label lb3 = new Label();
        Label lb4 = new Label();
        Label lb5 = new Label();
  

        /// <summary>
        /// 客户
        /// </summary>
        private string KF;//客户
        /// <summary>
        /// 机床码
        /// </summary>
        private string JC;//机床码
        /// <summary>
        /// 维修员
        /// </summary>
        private string WXM;//维修员
        /// <summary>
        /// 保修内外
        /// </summary>
        private string WXB;//保修内外

        private List<string> GetQuing = new List<string>();
    
        public 获取单据()
        {
            InitializeComponent();
            GetQuing=IRoot.MRoot("售后旧件管理");  //获取权限
            PBmain(); //主架构
            Skin.NewFrom(this, "内部维修单据管理", 5);//获取皮肤层
        }
 
        #region nothing 

        private void PBmain()
        {
            this.SuspendLayout();
            panel2.Dock = DockStyle.Top;
            panel2.Height = 30;
            panel2.BackColor = Skin.Set_Color(Skin.upBColor);

            Sp.Dock = DockStyle.Left;
            Sp.Width = 5;
            Sp.BackColor = Skin.Set_Color(Skin.upBColor);

            Lis.Dock = DockStyle.Left;
            Lis.Text = "";
            Lis.Width = 220;
            Dg.分页 = true;
            Dg.皮肤设置 = MTable.Skinlist.默认皮肤;
            Dg.每页数量 = 200;

            Dg.数据表名称 = "售后服务";
            Dg.Dock = DockStyle.Fill;
            Dg.CellClick += Dg_CellClick;
        


            //------
            // 加载功能
            //------

            Dg.Parent = this;
            panel2.Parent = this;
            Sp.Parent = this;
            Lis.Parent = this;
            #endregion
            if (IRoot.Internalmenu(GetQuing, "维修单-历史"))
            {
                lb2 = Skincss.AddLable(panel2, " + 维修单-历史", "left", "120/30");
                lb2.Click += Lb2_Click;
            }
            if (IRoot.Internalmenu(GetQuing, "维修单-物料"))
            {
                lb5 = Skincss.AddLable(panel2, " + 维修单-物料", "left", "120/30");
                lb5.Click += Lb5_Click;
            }
            if (IRoot.Internalmenu(GetQuing, "维修单-审核"))
            {
                lb3 = Skincss.AddLable(panel2, " + 维修单-审核", "left", "120/30");
                lb3.Click += Lb3_Click;
            }
            if (IRoot.Internalmenu(GetQuing, "维修单-实施"))
            {
                lb4 = Skincss.AddLable(panel2, " + 维修单-实施", "left", "120/30");
                lb4.Click += Lb4_Click;
            }
            if (IRoot.Internalmenu(GetQuing, "维修单-管理"))
            {
                lb1 = Skincss.AddLable(panel2, " + 维修单-管理", "left", "120/30");
                lb1.Click += Lb1_Click;
            }
            if (IRoot.Internalmenu(GetQuing, "维修单-接收"))
            {
                lb = Skincss.AddLable(panel2, " + 维修单-接收", "left", "120/30");
                lb.Click += Lb_Click;
            }


            lb.MouseEnter += Imouse._MouseEnter;
            lb.MouseLeave += Imouse._MouseLeave;
            lb1.MouseEnter += Imouse._MouseEnter;
            lb1.MouseLeave += Imouse._MouseLeave;
            lb2.MouseEnter += Imouse._MouseEnter;
            lb2.MouseLeave += Imouse._MouseLeave;
            lb3.MouseEnter += Imouse._MouseEnter;
            lb3.MouseLeave += Imouse._MouseLeave;
            lb4.MouseEnter += Imouse._MouseEnter;
            lb4.MouseLeave += Imouse._MouseLeave;
            lb5.MouseEnter += Imouse._MouseEnter;
            lb5.MouseLeave += Imouse._MouseLeave;
            this.ResumeLayout(false);

        }

   

        private void GetWxinfo(IEnumerable<string> Plist) {
            string mm = string.Empty;
            foreach (var c in Plist) {
                mm += "'" + c + "',";
            }
            if (mm == string.Empty) return;
            mm = Ifun.Left(mm, mm.Length - 1);
            clientservice_AfterServiceBill cab = new clientservice_AfterServiceBill();
            Wxinfo = cab.Select(" and code in (" + mm + ")");
        }



        private void SetButton(Label cl, string cTxt) {
            Sx = cTxt;
            lb.Tag = "X";
            lb1.Tag = "X";
            lb2.Tag = "X";
            lb3.Tag = "X";
            lb4.Tag = "X";
            lb5.Tag = "X";
 
            Imouse.MouseOver(lb, "#", "#200200200");
            Imouse.MouseOver(lb1, "#", "#200200200");
            Imouse.MouseOver(lb2, "#", "#200200200");
            Imouse.MouseOver(lb3, "#", "#200200200");
            Imouse.MouseOver(lb4, "#", "#200200200");
            Imouse.MouseOver(lb5, "#", "#200200200");
 
            Imouse.MouseOver(cl, "#030164045", "#255255255");
            cl.Tag = "T";
            Resetinfo();
      
        }
 

        /// <summary>
        /// 维修部重新定义单据：保内外，免收费？
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lb5_Click(object sender, EventArgs e)
        {
            SetButton(lb5, "客户");
            m_rukukuinfo mr = new m_rukukuinfo();
 
            Dg.数据表名称 = "m_rukuku_内部维修_客户";
            List<m_rukukuinfo> ts = mr.Select("and  is完成=3");
            var m = from r in ts select r.维修单;
            Dg.ShowList(ts);
            GetWxinfo(m);
        }


        /// <summary>
        /// 历史单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lb2_Click(object sender, EventArgs e)
        {
            SetButton(lb2, "历史");
            m_rukuku mr = new m_rukuku();
 
            Dg.数据表名称 = "m_rukuku_内部维修_评判";
            List<m_rukuku> ts = mr.Select("and  is完成=4  order by id desc");
            var m = from r in ts select r.维修单;
            Dg.ShowList(ts);
            GetWxinfo(m);

    
        }
        /// <summary>
        /// 维修单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lb1_Click(object sender, EventArgs e)
        {
            SetButton(lb1, "评判");
            m_rukuku mr = new m_rukuku();
 
            Dg.数据表名称 = "m_rukuku_内部维修_评判";
            List<m_rukuku> ts = mr.Select("and  isnull(is完成,0)=0  and 数量!=已处理 ");
            var m = from r in ts select r.维修单;
            Dg.ShowList(ts);
            GetWxinfo(m);

        }
        /// <summary>
        /// 接收物料单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lb_Click(object sender, EventArgs e)
        {
            SetButton(lb, "接收");
 
            Dg.数据表名称 = "BILLnouse2_内部维修_接收";
            BILLnouse2 JC = new BILLnouse2();
            string where = "and  BILLTYPE ='售后返厂维修' and (isnull(Paytype,'')<>'')and left(code,1)<>'*' and  (freenum5 is null or freenum5 < 1)";
            List<BILLnouse2> bs = JC.Select(where);
            var m = from r in bs select r.PAYTYPE;
            Dg.ShowList(bs);
            GetWxinfo(m);
        }
        private void Lb4_Click(object sender, EventArgs e)
        {
            SetButton(lb4, "实施");
            m_rukukuinfo mr = new m_rukukuinfo();
            string sql = "and isnull(is完成,0)=0";
            if (UserInfo.UName != "lxd" && UserInfo.UName != "郑昌仁" && UserInfo.UName != "连查柳")
            {
                sql += " and 责任人='" + UserInfo.UName + "'";
            }
            List<m_rukukuinfo> lmr = mr.Select(sql);
            var m = from r in lmr select r.维修单;
 
            Dg.数据表名称 = "BILLnouse2_内部维修_实施";
            Dg.ShowList(lmr);
            GetWxinfo(m);
            List<string> tim = new List<string>
            {
                "开始维修时间",
                "结束完成时间"
            };
            Ifun.重置Dgv时间(Dg, tim);


        }

        private void Lb3_Click(object sender, EventArgs e)
        {
            SetButton(lb3, "审核");

            m_rukukuinfo mr = new m_rukukuinfo();
            string sql = "and isnull(is完成,0)=1";
            List<m_rukukuinfo> lmr = mr.Select(sql);
            var m = from r in lmr select r.维修单;
 
            Dg.数据表名称 = "BILLnouse2_内部维修_审核";
            Dg.ShowList(lmr);
            GetWxinfo(m);

        }
      
        private void Dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < -1) return;
            string Wxname = "维修单";
            Lis.Controls.Clear();
            this.SuspendLayout();
            id = int.Parse(Dg.SelectedRows[0].Cells["id"].Value.ToString());
            if (Wxinfo.Count < 0)
            {
               // mc.SetLabel(Lis, "无法读取数据！", true);
            }
            else
            {
                Label tmep = Skincss.AddLable(Lis, " ", "top", "0/40");
                if (Sx == "历史")
                {
                    Label Bmx = Skincss.AddLable(tmep, "查看分配明细", "10/0", (tmep.Width - 20) + "/30", "#255255255", 12, "", 1, -1, false, "#030164045");
                    Bmx.Click += Bmx_Click;
                }
                if (Sx == "接收") {
                    Wxname = "paytype";
                    Label Bbt = Skincss.AddLable(tmep, Sx, "10/0", (tmep.Width - 20) + "/30", "#255255255", 12, "", 1, -1, false, "#030164045");
                    Bbt.Click += Bbt_Click;
                }
                if (Sx == "评判")
                {
                    Label Bbt = Skincss.AddLable(tmep, "物料初步评判", "10/0", (tmep.Width - 20) + "/30", "#255255255", 12, "", 1, -1, false, "#030164045");
                    Bbt.Click += Bbt_Click;
                }
                if (Sx == "审核") {
                    Label pctmep = Skincss.AddLable(Lis, " ", "top", "0/40");
                  //  Label CNMX = Skincss.AddLable(pctmep, "提交总经办审批", "10/0", (tmep.Width - 20) + "/30", "#255255255", 12, "", 1, -1, false, "#030164045");
                    Label Bbt = Skincss.AddLable(tmep, "审核", "10/0", (tmep.Width - 20) + "/30", "#255255255", 12, "", 1, -1, false, "#030164045");
                    Bbt.Click += Bbt_Click6;
                    Printinfo();
                }
                if (Sx == "实施")
                {
                    //一步步读取 下一步

                    if (Dg.SelectedRows[0].Cells["接收人"].Value.ToString() == "")
                    {
                        Label Bbt = Skincss.AddLable(tmep, "接收维修单", "10/0", (tmep.Width - 20) + "/30", "#255255255", 12, "", 1, -1, false, "#030164045");
                        Bbt.Click += Bbt_Click1;
                    }
                    else if (DateTime.Parse(Dg.SelectedRows[0].Cells["开始维修时间"].Value.ToString()) == DateTime.MinValue)
                    {
                        Label Bbt = Skincss.AddLable(tmep, "开始维修", "10/0", (tmep.Width - 20) + "/30", "#255255255", 12, "", 1, -1, false, "#030164045");
                        Bbt.Click += Bbt_Click2;
                    }
                    else if (DateTime.Parse(Dg.SelectedRows[0].Cells["结束完成时间"].Value.ToString()) == DateTime.MinValue)
                    {
                        Label Bbt = Skincss.AddLable(tmep, "完成维修", "10/0", (tmep.Width - 20) + "/30", "#255255255", 12, "", 1, -1, false, "#030164045");
                        Bbt.Click += Bbt_Click3;
                    } else {
                        快递和反馈信息(tmep);
                    }

                }
                if (Sx == "客户")
                {
                    Printinfo();
                    Label Bbt = Skincss.AddLable(tmep, "物料判定", "10/0", (tmep.Width - 20) + "/30", "#255255255", 12, "", 1, -1, false, "#030164045");
                    Bbt.Click += Bbt_Click7;
                }

                //-----------------------
                //基础显示模块
                //-----------------------

                List<clientservice_AfterServiceBill> Tm = Wxinfo.Where(x => x.CODE == Dg.SelectedRows[0].Cells[Wxname].Value.ToString()).ToList();
                KF = Tm[0].CLIENT.ToString();
                JC = Tm[0].ZF1.ToString();
                WXM = Tm[0].BILLMAN.ToString();
                WXB = Tm[0].BILLTYPE.ToString() ;

                Label Pdinfo = Skincss.AddLable(Lis, "\n\r维修判断:\n\r" + Ifun.IsDBnull(Tm[0].ZF5, "无记录"), "top", "0/56", "#050050050", 10, "", 3);
                Pdinfo.Click += MsgShowIinfo_Click;
                tmep = Skincss.AddLable(Lis, "维修员:" + WXM, "top", "0/35", "#050050050");
                tmep = Skincss.AddLable(Lis, "机床码:" + JC, "top", "0/35", "#050050050");
                tmep = Skincss.AddLable(Lis, "类型:" + WXB, "top", "0/35", "#050050050");
                tmep = Skincss.AddLable(Lis, "客户:" + KF, "top", "0/35", "#050050050");

                tmep = Skincss.AddLable(Lis, "维修单信息", "top", "0/30", "#255255255", 12, "", 1, -1, false, Skin.upBColor);
                this.ResumeLayout(false);
            }
        }

        private void Bmx_Click(object sender, EventArgs e)
        {

            明细显示 mx = new 明细显示(int.Parse(Dg.SelectedRows[0].Cells["id"].Value.ToString()), KF);

        }

        private void Bbt_Click7(object sender, EventArgs e)
        {
            (sender as Label).Enabled = false;
            物料判定 wl = new 物料判定(id, KF);
            if (wl.doBack) Dg.Rows.RemoveAt(Dg.SelectedRows[0].Index);

        }

        private void Bbt_Click6(object sender, EventArgs e)
        {
            (sender as Label).Enabled = false;
            旧件终审 zp = new 旧件终审(id, KF);
            if (zp.doBack) Dg.Rows.RemoveAt(Dg.SelectedRows[0].Index);
        }


        private void Printinfo() {

            Label MsgShowIinfo = Skincss.AddLable(Lis, "\n\r维修报告:\n\r" + Dg.SelectedRows[0].Cells["过程信息"].Value.ToString(), "top", "0/56", "#050050050", 10, "", 3);
            MsgShowIinfo.Click += MsgShowIinfo_Click;


            //打印快递信息
            string kdinfo = Dg.SelectedRows[0].Cells["快递信息"].Value.ToString();
            string upinfo = string.Empty;
            if (Ifun.IndexOf(kdinfo, "@"))
            {
                string[] Fn = kdinfo.Split('@');

                for (int i = 0; i < Fn.Length; i++)
                {
                    upinfo += Fn[i] + "\n\r";
                }
            }
            else
            {
                if (upinfo == "")
                {
                    upinfo = "无信息记录";
                }
                else
                {
                    upinfo = kdinfo;
                }

            }
            Label CgMsgShowIinfo = Skincss.AddLable(Lis, "\n\r快递信息:\n\r" + upinfo, "top", "0/56", "#050050050", 10, "", 3);
            CgMsgShowIinfo.Click += MsgShowIinfo_Click;



        }
        private void 快递和反馈信息(Label lbs) {
            if (Dg.SelectedRows[0].Cells["过程信息"].Value.ToString() == "")
            {
                Label Bbt = Skincss.AddLable(lbs, "维修报告", "10/0", (lbs.Width - 20) + "/30", "#255255255", 12, "", 1, -1, false, "#030164045");
                Bbt.Click += Bbt_Click5;
            }


            if (Dg.SelectedRows[0].Cells["责任部门"].Value.ToString() == "采购部" && Dg.SelectedRows[0].Cells["快递信息"].Value.ToString() == "")
            {
                Label pctmep = Skincss.AddLable(Lis, " ", "top", "0/40");
                Label Bbt = Skincss.AddLable(pctmep, "快递信息", "10/0", (pctmep.Width - 20) + "/30", "#255255255", 12, "", 1, -1, false, "#030164045");
                Bbt.Click += Bbt_Click4;
            }
            if (Dg.SelectedRows[0].Cells["责任部门"].Value.ToString() == "生产部")
            {
                Label wpctmep = Skincss.AddLable(Lis, " ", "top", "0/40");
                Label wBbt = Skincss.AddLable(wpctmep, "生产领料", "10/0", (wpctmep.Width - 20) + "/30", "#255255255", 12, "", 1, -1, false, "#030164045");
                wBbt.Click += WBbt_Click;
            }

                Printinfo();
        }

        private void WBbt_Click(object sender, EventArgs e)
        {
            (sender as Label).Enabled = false;
            领取物料 bg = new 领取物料(Dg.SelectedRows[0].Cells["编号"].Value.ToString(),id, KF);
        }

        private void MsgShowIinfo_Click(object sender, EventArgs e)
        {
            // ----\n\r 是做为一个字节
            string inp = (sender as Label).Text;
            Msg Minfo = new Msg(0, Ifun.Right(inp, inp.Length - 7), Ifun.Right(Ifun.Left(inp, 6), 4), 1);
        }

        private void Bbt_Click5(object sender, EventArgs e)
        {
            (sender as Label).Enabled = false;
            维修报告 bg = new 维修报告(int.Parse(Dg.SelectedRows[0].Cells["id"].Value.ToString()), KF, false);
            if (bg.doBack) Dg.Rows.RemoveAt(Dg.SelectedRows[0].Index);
        }

        private void Bbt_Click4(object sender, EventArgs e)
        {
            (sender as Label).Enabled = false;
            维修报告 bg = new 维修报告(int.Parse(Dg.SelectedRows[0].Cells["id"].Value.ToString()), KF, true);
           
        }

        private void Bbt_Click3(object sender, EventArgs e)
        {
            (sender as Label).Enabled = false;
            m_rukukuinfo m = new m_rukukuinfo
            {
                结束完成时间 = SysTime.GetTime
            };
            m.Updata("and id=" + id);
            Dg.SelectedRows[0].Cells["结束完成时间"].Value = SysTime.GetTime;
            维修报告 bg = new 维修报告(int.Parse(Dg.SelectedRows[0].Cells["id"].Value.ToString()), KF, false);
            if (bg.doBack) Dg.Rows.RemoveAt(Dg.SelectedRows[0].Index);

        }

        private void Bbt_Click2(object sender, EventArgs e)
        {
            (sender as Label).Enabled = false;
            m_rukukuinfo m = new m_rukukuinfo
            {
                开始维修时间 = SysTime.GetTime
            };
            m.Updata("and id=" + id);
            Dg.SelectedRows[0].Cells["开始维修时间"].Value = SysTime.GetTime;

            if (Dg.SelectedRows[0].Cells["责任部门"].Value.ToString() == "采购部")
            {
                维修报告 bg = new 维修报告(int.Parse(Dg.SelectedRows[0].Cells["id"].Value.ToString()), KF, true);
            }

            if (Dg.SelectedRows[0].Cells["责任部门"].Value.ToString() == "生产部" || Dg.SelectedRows[0].Cells["责任部门"].Value.ToString() == "售后部")
            {
                领取物料 bg = new 领取物料(Dg.SelectedRows[0].Cells["编号"].Value.ToString(), id, KF);
            }


        }

        private void Bbt_Click1(object sender, EventArgs e)
        {
            (sender as Label).Enabled = false;
            m_rukukuinfo m = new m_rukukuinfo
            {
                接收人 = UserInfo.UName
            };
            m.Updata("and id=" + id);
            Dg.SelectedRows[0].Cells["接收人"].Value = UserInfo.UName;
        }

        private void NMX_Click(object sender, EventArgs e)
        {
            String sqllist = "select * from  m_rukukuinfo where Fid=" + Dg.SelectedRows[0].Cells["id"].Value;
        }

        /// <summary>
        /// 接收或是处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bbt_Click(object sender, EventArgs e)
        {
            Label bt = sender as Label;

            if (Sx == "接收") {
                bt.Enabled = false;
                BILLnouse2 bi = new BILLnouse2();
                bi.FREENUM5 = 1;
                bi.Updata(" and id=" + id);
                //mc.Update接收维修信息(id);
                string getcode = IData.GetCode("m_rukuku", "NB");

                m_rukuku Mr = new m_rukuku
                {
                    CODE = getcode,
                    关联ID = id,
                    关联号 = (string)Ifun.IsDBnull(Dg.SelectedRows[0].Cells["code"].Value.ToString(), ""),
                    维修单 = Dg.SelectedRows[0].Cells["paytype"].Value.ToString(),
                    录单人 = UserInfo.UName,
                    录单时间 = SysTime.GetTime,
                    借用类型 = Ifun.IsDBnull(Dg.SelectedRows[0].Cells["freestr7"].Value.ToString(), "无借用").ToString(),
                    编号 = Dg.SelectedRows[0].Cells["materialCODE"].Value.ToString(),
                    物料 = Dg.SelectedRows[0].Cells["materialNAME"].Value.ToString(),
                    物料型号 = Dg.SelectedRows[0].Cells["specs"].Value.ToString(),
                    单位 = Dg.SelectedRows[0].Cells["UNITNAME"].Value.ToString(),
                    质保 = WXB,
                    数量 = decimal.Parse(Dg.SelectedRows[0].Cells["QUANTITY"].Value.ToString()),
                    仓库 = "维修库",
                    客户 = KF,
                    机床码 = JC,
                    维修人 = WXM

                };
                Mr.Insert();
                Dg.Rows.RemoveAt(Dg.SelectedRows[0].Index);

            }
            if (Sx == "评判")
            {
                decimal A = decimal.Parse(Dg.SelectedRows[0].Cells["数量"].Value.ToString());
                decimal B = Dg.SelectedRows[0].Cells["已处理"].Value.ToString() == "" ? 0 : decimal.Parse(Dg.SelectedRows[0].Cells["已处理"].Value.ToString());
                if (A - B > 0)
                {
                    num = A - B;
                    旧件处理 Js = new 旧件处理(id, num, KF);
                    if (Js.doBack) Lb1_Click(null, null);
                }
                else
                {
                    Msg err = new Msg(3, "单据数量已处理完!");
                }
            }

        }
 
        private void Resetinfo() {
            Lis.Controls.Clear();
            Label gg = Skincss.AddLable(Lis, "选择右侧物料信息", "top", "0/80", "#050050050", 9,"",1);
            Label tt = Skincss.AddLable(Lis, "维修单信息", "top", "0/30", "#255255255", 12, "", 1, -1, false, Skin.upBColor);
        }
        private void 获取单据_Shown(object sender, EventArgs e)
        {
            // Lb_Click(null, null);
            string str = "";
            int clnum = panel2.Controls.Count;
            if (clnum > 0)  str = panel2.Controls[clnum - 1].Text.Replace("+","").Trim();
            if (str == "维修单-历史") Lb2_Click(lb2, null);
            if (str == "维修单-物料") Lb5_Click(lb5, null);
            if (str == "维修单-审核") Lb3_Click(lb2, null);
            if (str == "维修单-实施") Lb4_Click(lb4, null);
            if (str == "维修单-管理") Lb1_Click(lb1, null);
            if (str == "维修单-接收") Lb_Click(lb, null);
 

        }


    }
}
