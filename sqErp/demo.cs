using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using makelanlan;
using ScueFun;
using System.Xml;

namespace sqErp
{
    public partial class demo : Form
    {
        private IForm Bform;
        private puku PUKU = new puku();
        private List<puku> Pukulist = new List<puku>();
        private puku_user USER = new puku_user();
        private Button btn_rg;
        private Button btn_del;
        private Button btn_refresh;
        private MTable tb_user = new MTable();
        public demo()
        {
            InitializeComponent();
            //引用BASEform 
            Bform = new IForm(this, "Test", 5, 2);
        }

        private void demo_Load(object sender, EventArgs e)
        {
            List<puku> m = MUser.Get用户("");
            //加载数据区域
            Bform._mTable.数据表名称 = "puku_webservers_list";
            // Bform._mTable. = true;
            Bform._mTable.每页数量 = 300;
            Bform._mTable.ShowList(m);
            Bform._MainPanel.Dock = DockStyle.Fill;
            Bform._RightPanel.Width = 650;

            Panel p = new Panel();
            p.Dock = DockStyle.Right;
            p.Width = 650;

            // tb_user.分页 = true;
            tb_user.每页数量 = 200;
            tb_user.数据表名称 = "puku_webservers_list";
            tb_user.Dock = DockStyle.Right;
            tb_user.Width = 650;


            //Splitter splitter_right = new Splitter();
            //splitter_right.Width = 3;
            //splitter_right.BackColor = Skin.Set_Color(Skin.upBColor);
            //splitter_right.Parent = this;
            //splitter_right.Dock = DockStyle.Right;


            p.Controls.Add(tb_user);
            tb_user.ShowList(GetPUser.PUser());
            Bform._RightPanel.Controls[0].Controls.Add(p);
            Bform._RightPanel.Dock = DockStyle.Right;
            Bform._RightPanel.Parent = this;
            //List<string> list = new List<string> {"维修员","销售员" };
            //for (int i = 0; i < list.Count; i++)
            //{
            //    CheckBox cb = new CheckBox();
            //    cb.Name = "cb_" + list[i];
            //    cb.Text = list[i];
            //    cb.SetBounds(18, 120+30*i, 70, 30);
            //    Bform._LeftPanel.Controls[0].Controls.Add(cb);
            //}
            Bform._LeftPanel.Controls[1].Height = 30;
            Bform._LeftPanel.Width = 220;
            Bform._LeftPanel.Dock = DockStyle.Left;
            Bform._LeftPanel.Parent = this;
            //添加按钮方式
            //添加按钮方式
            btn_refresh = Skincss.AddButon(Bform._LeftPanel.Controls[0], "刷新数据", "0/560", "210/30", "#255255255", 10, "", 1, -1, false, Skin.upYcolor);
            btn_refresh.Click += btn_refresh_Click;

            btn_rg = Skincss.AddButon(Bform._LeftPanel.Controls[0], "注册", "0/600", "210/30", "#255255255", 10, "", 1, -1, false, Skin.upBColor);
            btn_rg.Click += Bt_Click;

            btn_del = Skincss.AddButon(Bform._LeftPanel.Controls[0], "取消注册", "0/640", "210/30", "#255255255", 10, "", 1, -1, false, Skin.upRcolor);
            btn_del.Visible = false;
            btn_del.Click += _del_Click;
            Label lb1 = Skincss.AddLable(Bform._LeftPanel.Controls[0], "密码：", "0/80", "80/30", "#100100100", 10, "", 1, -1, true);

            TextBox txtbox_pwd = Skincss.AddTxt(Bform._LeftPanel.Controls[0], "password", " ", "90/80", "120/30", "#100100100");

            Label lb2 = Skincss.AddLable(Bform._LeftPanel.Controls[0], "账号：", "0/40", "80/30", "#100100100", 10, "", 1, -1, true);

            TextBox txtbox_user = Skincss.AddTxt(Bform._LeftPanel.Controls[0], "user", " ", "90/40", "120/30", "#100100100");

            Label lb3 = Skincss.AddLable(Bform._LeftPanel.Controls[0], "姓名：", "0/0", "80/30", "#100100100", 10, "", 1, -1, true);

            TextBox txtbox_name = Skincss.AddTxt(Bform._LeftPanel.Controls[0], "truename", " ", "90/0", "120/30", "#100100100");

            Bform._mTable.CellDoubleClick += _mTable_CellDoubleClick;
            tb_user.CellDoubleClick += _tbuser_CellDoubleClick;
            _Refresh();

        }

        private void _del_Click(object sender, EventArgs e)
        {
            string password = Bform._LeftPanel.Controls[0].Controls["password"].Text;
            string user = Bform._LeftPanel.Controls[0].Controls["user"].Text;

            RegistBS(password, user, "Cancle");
            _Refresh();
        }

        private void _tbuser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_rg.Text = "修改";
            btn_del.Visible = true;
            string get_pwd = ScueFun.BitLock.RealseLock_L(tb_user.SelectedRows[0].Cells["MM"].Value.ToString());
            Bform._LeftPanel.Controls[0].Controls["password"].Text = get_pwd;
            Bform._LeftPanel.Controls[0].Controls["user"].Text = tb_user.SelectedRows[0].Cells["USERPU"].Value.ToString();
            Bform._LeftPanel.Controls[0].Controls["truename"].Text = tb_user.SelectedRows[0].Cells["TURENAME"].Value.ToString();
        }

        private void _mTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_rg.Text = "注册";
            btn_del.Visible = false;
            Bform._LeftPanel.Controls[0].Controls["password"].Text = Bform._mTable.SelectedRows[0].Cells["MM"].Value.ToString();
            Bform._LeftPanel.Controls[0].Controls["user"].Text = Bform._mTable.SelectedRows[0].Cells["USERPU"].Value.ToString();
            Bform._LeftPanel.Controls[0].Controls["truename"].Text = Bform._mTable.SelectedRows[0].Cells["TURENAME"].Value.ToString();
        }

        private void check_query()
        {

        }

        private void Bt_Click(object sender, EventArgs e)
        {
            string password = Bform._LeftPanel.Controls[0].Controls["password"].Text;
            string user = Bform._LeftPanel.Controls[0].Controls["user"].Text;
            if (user == "" || password == "")
            {
                Msg msg = new Msg(3, "请先选择用户！");
            }
            else
            {
                if (btn_rg.Text == "注册")
                {
                    RegistBS(password, user, "Regist");
                }
                else
                {
                    RegistBS(password, user, "Modify");
                }
                _Refresh();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void _Refresh()
        {
            List<puku_user> list_user = USER.Select(" and ISSTOP <> '是'  ");
            List<puku> list_puku = MUser.Get用户("  and USERPU not in (select USERPU from puku_user where ISSTOP <> '是')  ");
            //for (int i = 0; i < list_puku.Count; i++)
            //{
            //    for (int j = 0; j < list_user.Count; j++)
            //    {
            //        if (list_puku[i].USERPU == list_user[j].USERPU)
            //        {
            //            list_puku.Remove(list_puku[i]);
            //        }
            //    }
            //}

            Bform._mTable.ShowList(list_puku);
            tb_user.ShowList(list_user);
        }
        private void RegistBS(string password, string user, string type)
        {
            string user_mm = ScueFun.BitLock.GetLock_L(password);
            string str_idept = "";
            string dept = "";
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is CheckBox && ((CheckBox)ctrl).Checked)
                {
                    dept = ctrl.Text;
                    if (ctrl.Text == "维修员")
                    {
                        str_idept += "SW0002,FJ0001,";
                    }
                    else if (ctrl.Text == "业务员")
                    {
                        str_idept += "SW0001,SW0002,FJ0001,FJ0002,FJ0003,FJ0004,";
                    }
                    else if (ctrl.Text == "销售内勤")
                    {
                        str_idept += "SW0001,SW0002,FJ0001,FJ0002,FJ0003,FJ0004,AD0003,";
                    }
                    else if (ctrl.Text == "业务经理")
                    {
                        str_idept += "AD0001,AD0002,AD0003,FJ0003";
                    }
                    else if (ctrl.Text == "维修经理")
                    {
                        str_idept += "AD0001,AD0002,AD0003,FJ0003";
                    }
                    else if (ctrl.Text == "总经理")
                    {
                        str_idept += "SW0001,SW0002,FJ0001,FJ0002,FJ0003,FJ0004,AD0001,AD0002,AD0003,";
                    }
                    else if (ctrl.Text == "后台")
                    {
                        str_idept += "SW0001,SW0002,FJ0001,FJ0002,FJ0003,FJ0004,AD0001,AD0002,AD0003,";
                    }
                    else { }
                    ((CheckBox)ctrl).Checked = false;
                }
            }
            if (str_idept.Length > 0)
            {
                str_idept = str_idept.Substring(0, str_idept.Length - 1);//去掉最后一个","
            }
            //---------------------
            // string Mcode = (string)Ifun.IsDBnull(Bform._mTable.SelectedRows[0].Cells["code"].Value.ToString(), "");
            // puku tb_user = new puku();
            //List<puku> lis = tb_user.Select("and code='" + Mcode + "'");
            // puku p = new puku();
            // p.CODE = Bform._mTable.SelectedRows[0].Cells["code"].Value.ToString();
            // p.Insert();
            //-------------------
            if (type.ToUpper().Trim() == "REGIST")
            {
                List<puku> list_puku = MUser.Get用户(" and USERPU='" + user + "'  ");
                //PUKU.Select("and USERPU='" + user + "' and ISSTOP <> '是' ");
                puku_user User = new puku_user();
                User = ScueFun.ScueMerge.MergeFrom(User, list_puku[0]);
                User.MM = user_mm;
                User.DEPT = dept;
                User.允许管理物料BY仓库名称 = str_idept;
                User.Insert();
                Msg msg = new Msg(3, "注册成功！");
            }
            else if (type.ToUpper().Trim() == "MODIFY")
            {
                List<puku_user> list_user = GetPUser.PUser(" and USERPU='" + user + "' ");
                //USER.Select("and USERPU='" + user + "'  and ISSTOP <> '是' ");
                puku_user UU = new puku_user();
                UU.MM = user_mm;
                UU.允许管理物料BY仓库名称 = str_idept;
                UU.Updata(" and id =" + list_user[0].ID);
                Msg msg = new Msg(3, "修改成功！");
            }
            else if (type.ToUpper().Trim() == "CANCLE")
            {
                List<puku_user> list_user = GetPUser.PUser(" and USERPU='" + user + "' ");

                puku_user m_user = list_user[0];
                m_user.Reset_puku_user();
                m_user.ISSTOP = "是";
                m_user.Updata(" and id =" + list_user[0].ID);
                //  m_user.ScueUpdate(ScueMerge.GetProperties(m_user), " and id =" + list_user[0].ID);
                Msg msg = new Msg(3, "取消注册成功！");
            }
            else
            {
                List<puku> list_puku = MUser.Get用户(" and USERPU='" + user + "'  ");
                puku_user User = new puku_user();
                User = ScueFun.ScueMerge.MergeFrom(User, list_puku[0]);
                User.MM = user_mm;
                User.DEPT = str_idept;
                User.Insert();
                Msg msg = new Msg(3, "注册成功！");
            }
            Bform._LeftPanel.Controls[0].Controls["password"].Text = "";
            Bform._LeftPanel.Controls[0].Controls["user"].Text = "";
            Bform._LeftPanel.Controls[0].Controls["truename"].Text = "";
        }
    }
}