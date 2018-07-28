using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using makelanlan;
namespace 后台权限
{
    public partial class MRoot : Form
    {
        private IForm BFrom;
        private MTable Uman;
        private Label info = new Label();
        private List<string> Mlist = new List<string>();
        private string Uiname = string.Empty;
        private string Tiname = string.Empty;
        public MRoot()
        {
            InitializeComponent();
            BFrom = ISkin.NewForms(this, "后台权限管理", 5, 4);
        }
        private void MRoot_Load(object sender, EventArgs e)
        {
            //左侧布局
            Controls["lline"].BackColor = Color.White;
            BFrom._LeftPanel.BackColor = Color.White;
            BFrom._LeftPanel.Controls[2].Height = 50;
            BFrom._LeftPanel.Controls[1].Height = 30;
            info = Skincss.AddLable(BFrom._LeftPanel.Controls[1], "> 请选择用户", "top", "0/30", Skin.upBColor);
            Label ad = Skincss.AddLable(BFrom._LeftPanel.Controls[2], "保存", "0/10", BFrom._LeftPanel.Width + "/30", "#255255255", 10, "", 1, -1, false, Skin.upBColor);
            ad.Click += Ad_Click;
            Uman = BFrom._SetMan("and isstop<>'是' and dept<>'' order by dept", false);
            Uman.CellClick += Uman_CellClick;
            //右侧布局
            BFrom._MainPanel.Controls[1].Height = 40;
            Label Temp = new Label();




            //循环读取
            Temp = Skincss.AddLable(BFrom._MainPanel.Controls[1], "售后旧件管理", "0/0", "100/30", "#255255255", 10, "", 1, -1, false, Skin.upBColor);
            //循环读取


            Temp.Click += Temp_Click;



            //初始化
            Setlablist(ReadFistLabel("售后旧件管理"));


        }

        private void Ad_Click(object sender, EventArgs e)
        {
            if (Uiname == "" || Uiname is null || Tiname == "" || Tiname is null) return;

            string Miname = string.Empty;
            if (Mlist.Count <= 0)
            {
                Miname = "";
            }
            else
            {
                for (int i = 0; i < Mlist.Count; i++)
                {
                    Miname += Mlist[i] + ",";
                }
                Miname = Ifun.Left(Miname, Miname.Length - 1);
            }
         
            m_menu_list mml = new m_menu_list();
            List<m_menu_list> ms = mml.Select("and tname='" + Tiname + "' and uname='" + Uiname + "'");
            mml.Reset_m_menu_list();
            mml.UNAME = Uiname;
            mml.TNAME = Tiname;
            mml.MNAME = Miname;
            if (ms.Count > 0)
            {
                mml.Updata("and tname='" + Tiname + "' and uname='" + Uiname + "'");
            }
            else
            {
                mml.Insert();
            }

            Msg err = new Msg(3, "保存成功！");
        }

        private List<string> ReadFistLabel(string str)
        {
            List<string> l = new List<string>();
            l.Clear();
            if (str == "售后旧件管理")
            {
                l.Add("维修单-历史");
                l.Add("维修单-物料");
                l.Add("维修单-审核");
                l.Add("维修单-实施");
                l.Add("维修单-管理");
                l.Add("维修单-接收");
            }
            Tiname = str;
            return l;
        }

        private void Setlablist(List<string> li)
        {
            FlowLayoutPanel Fp = new FlowLayoutPanel();
            Fp.Dock = DockStyle.Fill;
            Fp.Parent = BFrom._MainPanel.Controls[0];

            for (int i = 0; i < li.Count; i++)
            {
                CheckBox CB = new CheckBox
                {
                    Width = 120,
                    Height = 30,
                    Text = li[i].Trim(),
                    Name =li[i].Trim(),
                    Parent = Fp
                };
                CB.CheckedChanged += CB_CheckedChanged;
            }
        }

        private void CB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cc = sender as CheckBox;

            if (cc.Checked)
            {
                Mlist.Add(cc.Text.Trim());
            }
            else
            {
                Mlist.Remove(cc.Text.Trim());
            }
        }



        private void Temp_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            Tiname = lb.Text.Trim();
            m_menu_list mml = new m_menu_list();
            mml.Select("and tname='" + Tiname + "' and uname='" + Uiname + "'");

        }

        private void Uman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < -1) return;

            info.Text = "用户：" + Uman.SelectedRows[0].Cells["turename"].Value;
            info.Text += " 职务：" + Uman.SelectedRows[0].Cells["dept"].Value;
            Uiname = Uman.SelectedRows[0].Cells["turename"].Value.ToString();
 

            List<m_menu_list> pp = new m_menu_list().Select("and tname='" + Tiname + "' and uname='" + Uiname + "'");
            SetCheckBox((from r in pp select r.MNAME).ToList());


        }

        private void SetCheckBox(List<string> Dalist)
        {
            Control Pc = BFrom._MainPanel.Controls[0].Controls[0];
            foreach (CheckBox hb in Pc.Controls)
            {
                hb.Checked = false;
            }
            if (Dalist.Count > 0 && Dalist[0].Trim() !="")
            {
                string str = Dalist[0];
              
                //判断是否是数组
                if (Ifun.IndexOf(str, ","))
                {
                    string[] ctr = str.Split(',');
                    for (int i=0;i<ctr.Count();i++) {
                        (Pc.Controls[ctr[i].Trim()] as CheckBox).Checked = true;
                    }

                } else {
                    (Pc.Controls[str.Trim()] as CheckBox).Checked = true;
                }

            }


        }

    }



}


 

