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
    public partial class 维修完成处理 : Form
    {
        Mcc MC = new Mcc();
        public 维修完成处理()
        {
            InitializeComponent();
        }

        private void 维修完成处理_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MC.Get已接收任务单();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            string typ = "";
            string f4 = "";
            string f7 = "";
            string node = "";
            string f5 = textBox2.Text.Trim();
            string fd1 = "1900-01-01";
            decimal fn1 = 0;
            fd1.PadLeft(4, '0');
            if (radioButton2.Checked)
            {
                typ = "售后返厂报废";
                f4 = "";
                f7 = "";
            }
            else if (radioButton1.Checked)
            {
                typ = "维修完工";
                f4 = "";
                f7 = "";
            }
            string getcode = IData.GetCode ("BILLnouse2", "YL");
           
          
                string sql = "INSERT INTO  [BILLnouse2]";
                sql += " ([CODE],[BILLTYPE],[BILLDATE],[Client],[TAXTYPE],[BillMan],[Auditing],[BillNote],[StorageName],[StorageWhere], [introducer],[Paytype],[introducerDate],[finishdate],[materialCODE],[materialNAME],[SPECS],[UNITNAME],[QUANTITY],[discount],[freestr10],[REMARK],[batchnumber],[referCode],[boxes],[引用单号2],[MaxValue],[ORIGPRICE],[PRICE],[AMOUNT],[KillBillQty],[REFERQTY],[payedAMOUNT],[freestr8],[freestr9],[freestr4],[freestr3],[freestr7],[freenum1],[freedte1],[freestr5])";
                sql += " VALUES('" + getcode + "','" + typ + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + userInfo.uName + "',' ',' ', ' ',' ', ' ', ' ','" + userInfo.uName  + "','" + dataGridView1.CurrentRow.Cells["外部维修单号"].Value.ToString() + "','" + DateTime.Now.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + dataGridView1.CurrentRow.Cells["产品编码"].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells["产品名称"].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells["产品型号"].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells["单位"].Value.ToString() + "','" + textBox3.Text.Trim() + "','100',',"+ dataGridView1.CurrentRow.Cells["referCode"].Value.ToString() + "','" + getcode + "',' ', '" + dataGridView1.CurrentRow.Cells["referCode"].Value.ToString() + "', 0,'" + dataGridView1.CurrentRow.Cells["referCode"].Value.ToString() + "',' ',0,0,0,0,-1,0,'" + dataGridView1.CurrentRow.Cells["外部维修单号"].Value.ToString() + "','售后返厂报废[维修单号：" + dataGridView1.CurrentRow.Cells["外部维修单号"].Value.ToString() + "]','" + f4 + "','" + node + "','" + f7 + "','" + fn1 + "','" + DateTime.Parse(fd1) + "','" + f5 + "')";
                BLL.SetToSql(BLL.数据库.默认数据库, sql);

                decimal q = decimal.Parse( dataGridView1.CurrentRow.Cells["数量"].Value.ToString());

                sql = "select sum(QUANTITY) from BILLnouse2 where referCode='" + dataGridView1.CurrentRow.Cells["referCode"].Value.ToString() + "'";
               
            int sq = (int)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Int, sql);
            decimal n = decimal.Parse(textBox3.Text.Trim());
                if (sq+(int)n >= (int)q)
                {

                    sql = "UPDATE cukuKu set freenum5='1' ,freestr9='"+textBox2.Text.Trim()+"' where id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'";
                BLL.SetToSql(BLL.数据库.默认数据库, sql);
                sql = "select SUM(QUANTITY) from BILLnouse2 where Paytype='" + dataGridView1.CurrentRow.Cells["外部维修单号"].Value.ToString() + "' and billtype ='维修完工' or billtype ='售后返厂报废' and materialCODE='" + dataGridView1.CurrentRow.Cells["产品编码"].Value.ToString() + "'";
                    
                int i = (int)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Int, sql);
                int s = (int)decimal.Parse(dataGridView1.CurrentRow.Cells["数量"].Value.ToString());
                    int y = i + s;
                    sql = "select SUM(QUANTITY) from RukuKu where billtype ='售后待维修' and storagename='维修零件库' and paytype<>'' and Paytype='" + dataGridView1.CurrentRow.Cells["外部维修单号"].Value.ToString() + "' and materialCODE='" + dataGridView1.CurrentRow.Cells["产品编码"].Value.ToString() + "'";
                     
                int o = (int)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Int, sql);
                if (y >= o)
                    {
                        sql = "UPDATE RukuKu set freenum5='1' where Paytype='" + dataGridView1.CurrentRow.Cells["外部维修单号"].Value.ToString() + "' and materialCODE='" + dataGridView1.CurrentRow.Cells["产品编码"].Value.ToString() + "'";
                    BLL.SetToSql(BLL.数据库.默认数据库, sql);
                }
               
                }
                dataGridView1.DataSource = MC.Get已接收任务单();
           
            button2.Enabled = false;
            textBox2.ReadOnly = true;
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            button2.Enabled = true;
            textBox2.ReadOnly = false;
            label3.Text = dataGridView1.CurrentRow.Cells["单号"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["结束时间"].Value != null)
            {
                if (dataGridView1.CurrentRow.Cells["结束时间"].Value.ToString() != "")
                {
                    textBox1.Text = dataGridView1.CurrentRow.Cells["备注"].Value.ToString();
                }
            }
            decimal q = decimal.Parse(dataGridView1.CurrentRow.Cells["数量"].Value.ToString());
            int sq = 0;
            
                string sql = "select sum(QUANTITY) from BILLnouse2 where referCode='" + dataGridView1.CurrentRow.Cells["单号"].Value.ToString()+"'";
                sq = (int)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Int, sql);

            
           
                textBox3.Text = (q-sq).ToString();
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            decimal q = decimal.Parse(dataGridView1.CurrentRow.Cells["数量"].Value.ToString());
            int sq=0;
          
                string sql = "select sum(QUANTITY) from BILLnouse2 where referCod=" + dataGridView1.CurrentRow.Cells["单号"].Value.ToString();
                sq = (int)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Int, sql);
                int n = int.Parse(textBox3.Text.Trim());
                if (q < sq+n)
                {
                    MessageBox.Show("当前可处理量小于输入数量！");
                    textBox3.Text = (q - sq).ToString();
                }
           
        }
    }
}
