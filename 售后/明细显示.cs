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
    public partial class 明细显示 : Form
    {

        private int id;
        private string Kf = string.Empty;
        string Fcode = string.Empty;
        DataTable Dc = new DataTable();
        MTable Mt;
        decimal getInt;
        Action ResData;

        public 明细显示(int _id, string _kf, string _Fcode = null, DataTable _Dc=null,Action _ResData=null)
        {
            id = _id;
            Kf = _kf;
            Fcode = _Fcode;
            Dc = _Dc;
            ResData = _ResData;
            InitializeComponent();
            Skin.NewFrom(this, _kf, 7);
            Width = 900;
            Height = 600;
            ShowDialog();
            
        }

        private void 明细显示_Load(object sender, EventArgs e)
        {

           


             Mt = new MTable
            {
                分页 = true,
                每页数量 = 200,
                Width = Width - 20,
                Left = 10,
                Top = 60,
                Height = Height - 125,
                Parent = this
               
            };

            if (Dc != null)
            {
                Mt.分页 = false;
                Width = 530;
                Mt.Width = Width - 20;
                Mt.数据表名称 = "m_rukuku_内部维修_领料list";
                Mt.ShowData(Dc);
                Mt.ReadOnly = false;
                for (int i=0;i<Mt.ColumnCount;i++) {
                  if(Mt.Columns[i].HeaderText!="数量")  Mt.Columns[i].ReadOnly = true;
                }
                Label Btn = Skincss.AddLable(this, "确定", "10/" + (Mt.Top +Mt.Height +10), "120/30", "#255255255", 10, "", 1, -1, false, Skin.upBColor);
                Btn.Click += Btn_Click;
                Mt.CellClick += Mt_CellClick;
                Mt.CellEndEdit += Mt_CellEndEdit;
            }
            else {
                m_rukukuinfo mr = new m_rukukuinfo();
                List<m_rukukuinfo> lmr = new List<m_rukukuinfo>();
                lmr = mr.Select("and fid=" + id);
                Mt.数据表名称 = "m_rukuku_内部维修_明细";
                Mt.ShowList(lmr);

             
            }
 
            


        }

        private void Mt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           if(!decimal.TryParse(Mt.Rows[e.RowIndex].Cells["数量"].Value.ToString(), out decimal pp))
            {
                Mt.Rows[e.RowIndex].Cells["数量"].Value = getInt;
            } else{
            if (getInt <= decimal.Parse(Mt.Rows[e.RowIndex].Cells["数量"].Value.ToString())) {
                Mt.Rows[e.RowIndex].Cells["数量"].Value = getInt;
            }
            }
        }

        /// <summary>
        /// 当点击单元格时，找到数量列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            getInt = decimal.Parse(Mt.Rows[e.RowIndex].Cells["数量"].Value.ToString());
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            (sender as Label).Text = "正在保存中...";
            (sender as Label).Enabled = false;

            m_rukukuinfo Tp = new m_rukukuinfo();
            m_rukuku Ftp = new m_rukuku();
            List<m_rukukuinfo> mrt = Tp.Select(" and id =" + id);
            List<m_rukuku> fmrt = Ftp.Select(" and id =" + mrt[0].FID);
            string Iscode = IData.GetCode("BILLnouse2", "YL");

            for (int i =0;i< Mt.RowCount;i++) {
            BILLnouse2 bl = new BILLnouse2
            {
                CODE = Iscode,
                BILLTYPE = "旧件维修",
                BILLDATE = DateTime.Now.Date,
                CLIENT = Kf,
                TAXRATE = 1,
                PAYTYPE = mrt[0].维修单,
                BILLMAN = UserInfo.UName,
                BILLNOTE ="",
                STORAGENAME ="",
                STORAGEWHERE ="",
                AUDITING = "",
                INTRODUCER = UserInfo.UName,
                INTRODUCERDATE = DateTime.Now,
                FINISHDATE =DateTime.Now,
                MATERIALCODE =Mt.Rows[i].Cells["物料编码"].Value.ToString(),
                MATERIALNAME= Mt.Rows[i].Cells["物料名称"].Value.ToString(),
                SPECS = Mt.Rows[i].Cells["物料型号"].Value.ToString(),
                UNITNAME= Mt.Rows[i].Cells["单位"].Value.ToString(),
                QUANTITY =decimal.Parse(Mt.Rows[i].Cells["数量"].Value.ToString()),
                ORIGPRICE =0,
                PRICE =0,
                AMOUNT=0,
                KILLBILLQTY =0,
                REFERQTY =-1,
                PAYEDAMOUNT =0,
                BATCHNUMBER ="",
                REFERCODE = fmrt[0].CODE,
               DISCOUNT =100,
               BOXES =0,
               GUSERDEF1 ="",
               GUSERDEF4 ="",
               GUSERDEF5="",
               MAXVALUE ="",
               FREESTR7 ="",
               FREESTR8 = mrt[0].维修单,
               FREESTR9 = Fcode,
               FREESTR10=","+ mrt[0].维修单+","+ fmrt[0].CODE,
               引用单号2 = mrt[0].维修单

            };
            bl.Insert();
            }


            ResData();
            Close();



        }
    }
}
