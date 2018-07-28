using System;
using System.Collections;
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
    public partial class 领取物料 : Form
    {

        private int id;
        private string Iscode = string.Empty;
        private string Kf = string.Empty;
        MTable Mt;
        MTable mMt;
        BILLnouse2 bi = new BILLnouse2();
        private string GetSqllist= string.Empty;
        string Nbcode = string.Empty;

        public 领取物料(string _Iscode,int _id, string _kf)
        {
            Iscode = _Iscode;
            id = _id;
            Kf = _kf;
            InitializeComponent();
            Skin.NewFrom(this, _kf, 7);
            Width = 720;
            Height = 700;
            ShowDialog();
        }

        private void 领取物料_Load(object sender, EventArgs e)
        {
            //模拟数据
          //  Iscode = "CL001254";

            m_rukukuinfo Tp = new m_rukukuinfo();
            m_rukuku Ftp = new m_rukuku();
            List<m_rukuku> fmrt = Ftp.Select(" and id =" + Tp.Select(" and id =" + id)[0].FID);
 
            GetSqllist = "and billtype = '旧件维修' and freestr9 ='" + Iscode + "' and referCode ='"+fmrt[0].CODE+ "'  and Paytype ='" + fmrt[0].维修单 + "'  and introducer = '" + UserInfo.UName + "' ";
            Label tmep = new Label();

            //-----领料清单------
            tmep = Skincss.AddLable(this, "领料清单", "10/45", "300/30", "#050050050");
            mMt = new MTable
            {
                分页 = false,
                皮肤设置 = MTable.Skinlist.默认皮肤,
                数据表名称 = "m_rukuku_内部维修_领料清单",
                Width = Width - 20,
                Left = 10,
                Top = 85,
                Height = 195,
                Parent = this,
                ReadOnly = true
            };
            mMt.ShowList(bi.Select(GetSqllist));


            string sql = "WITH locs (id,materialCODE,completecode )AS( ";
            sql += "select id, materialCODE, completecode  from peiLiaodanku where completecode = '"+ Iscode + "' UNION ALL SELECT p.ID, p.materialCODE, p.completecode  FROM peiLiaodanku p  inner join locs as c on c.materialCODE = p.completecode ) ";
            sql += " select * from peiLiaodanku where ID in(select id from locs) OPTION(MAXRECURSION 0)";

            WBLL wBLL = new WBLL();
            wBLL.Start(BLL.数据库.默认数据库, BLL.数据类型.Table, sql);
            wBLL.WBLL_BgWorker.RunWorkerCompleted += WBLL_BgWorker_RunWorkerCompleted;

            // DataTable  cdd = (DataTable)BLL.SqltoView();



            //-------选料清单------
            tmep = Skincss.AddLable(this, "选料清单", "10/290", "300/30", "#050050050");
           Mt = new MTable
            {
                分页 = true,
                皮肤设置 = MTable.Skinlist.默认皮肤,
                每页数量 = 200,
                数据表名称 = "m_rukuku_内部维修_选料清单",
                Width = Width - 20,
                Name = "m_rukuku_内部维修_选料清单",
                Left = 10,
                Top = 330,
                Height = 300,
                Parent = this,
                ReadOnly = true
            };
           // 

            Label lld  = Skincss.AddLable(this, "生成领料单", "10/650", "180/30", "#255255255",10,"",1,-1,false,Skin.upBColor);
            lld.Click += Lld_Click;
 

        }

        private void WBLL_BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Mt.ShowData(e.Result as DataTable);
        }

        private void ReadData() {
            mMt.ShowList(bi.Select(GetSqllist));
        }
        private void Lld_Click(object sender, EventArgs e)
        {
            DataTable dt = Ifun.GetDgvToTable(Mt, true ,true);
            明细显示 m = new 明细显示(id, Kf,Iscode,dt, ReadData);
        }
    }
}
