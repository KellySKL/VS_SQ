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
    public partial class 内部维修 : Form
    {
        public 内部维修()
        {
            InitializeComponent();
            Skin.NewFrom(this, "内部维修单据管理", 5);
        }
        Mcc MC = new Mcc();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MC.Get任务单();
            dataGridView2.DataSource = MC.Get已接收任务单();
        }
 
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                   
                        string sql = "Update cukuKu set freedte2='"+DateTime.Now.ToString()+"'  where id="+id;
                        BLL.SetToSql(BLL.数据库.默认数据库, sql);
                
                    dataGridView1.DataSource = MC.Get任务单();
                    dataGridView2.DataSource = MC.Get已接收任务单();
                }
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string y = "";
            if (dataGridView2.Columns[e.ColumnIndex].Name == "结束时间")
            {
                if (dataGridView2.Rows[e.RowIndex].Cells["结束时间"].Value != null && dataGridView2.Rows[e.RowIndex].Cells["结束时间"].Value.ToString() != "")
                {
                    y = "完成维修";
                    DataGridViewTextBoxCell bc = new DataGridViewTextBoxCell();
                    bc.Value = y;
                    dataGridView2.Rows[e.RowIndex].Cells["button1"] = bc;
                }
                else if (dataGridView2.Rows[e.RowIndex].Cells["开始时间"].Value != null && dataGridView2.Rows[e.RowIndex].Cells["开始时间"].Value.ToString() != "")
                {
                    y = "正在维修中...";
                    DataGridViewTextBoxCell bc = new DataGridViewTextBoxCell();
                    bc.Value = y;
                    dataGridView2.Rows[e.RowIndex].Cells["button1"] = bc;
                }
            }
            //if (dataGridView2.Columns[e.ColumnIndex].Name == "开始时间")
            //{
            //    if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null&& dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            //    {
            //        DataGridViewTextBoxCell bc = new DataGridViewTextBoxCell();
            //        bc.Value = "正在维修中...";
            //        dataGridView2.Rows[e.RowIndex].Cells["button1"] = bc;
            //    }
            //}
            //if (dataGridView2.Columns[e.ColumnIndex].Name == "结束时间")
            //{
            //    if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            //    {
            //        DataGridViewTextBoxCell bc = new DataGridViewTextBoxCell();
            //        bc.Value = "完成维修";
            //        dataGridView2.Rows[e.RowIndex].Cells["button1"] = bc;
            //    }
            //}
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridView2.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn && dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()!= "正在维修中..." && dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "完成维修")
                {
                    if (dataGridView2.CurrentRow.Cells["是否客户借用"].Value.ToString() == "客户借用")
                    {
                        panel2.Visible = true;
                    }
                    else
                    {
                        panel2.Visible = false;
                        string id = dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                      
                            string sql = "Update cukuKu set freedte3='" + DateTime.Now.ToString() + "'  where id=" + id;
                            BLL.SetToSql(BLL.数据库.默认数据库, sql);
                      
                       
                        dataGridView1.DataSource = MC.Get任务单();
                        dataGridView2.DataSource = MC.Get已接收任务单();
                    }                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView2.CurrentRow.Cells["开始时间"].Value != null) {
                MessageBox.Show("请开始作业！");
                return;
            }
            //string typ = "";
            //int 序号 = showCode("BILLnouse2", "YL");
            //string getcode = "YL" + BuildFrmTo获得服务器时间().ToString("yyyyMMdd") + 序号.ToString().PadLeft(4, '0');
            
         
                string sql = "";

                //售后出库——吴冬女
                //if (dataGridView2.CurrentRow.Cells["是否客户借用"].Value != null)
                //{
                //    if (dataGridView2.CurrentRow.Cells["是否客户借用"].Value.ToString() == "客户借用")
                //    {
                //        sql = "INSERT INTO  [BILLnouse2]";
                //        sql += " ([CODE],[BILLTYPE],[BILLDATE],[Client],[TAXTYPE],[BillMan],[Auditing],[BillNote],[StorageName],[StorageWhere], [introducer],[Paytype],[introducerDate],[finishdate],[materialCODE],[materialNAME],[SPECS],[UNITNAME],[QUANTITY],[discount],[freestr10],[REMARK],[batchnumber],[referCode],[boxes],[引用单号2],[MaxValue],[ORIGPRICE],[PRICE],[AMOUNT],[KillBillQty],[REFERQTY],[payedAMOUNT],[freestr8],[freestr9])";
                //        sql += " VALUES('" + getcode + "','售后维修收费','" + DateTime.Now.ToString("yyyyMMdd") + "','" + Bus_DataBus.Bus_CurrentUser_Fullname + "',' ',' ', ' ',' ', ' ', ' ','" + Bus_DataBus.Bus_CurrentUser_Fullname + "','" + dataGridView2.CurrentRow.Cells["外部维修单号"].Value.ToString() + "','" + DateTime.Now.ToString() + "','" + DateTime.Now.ToString("yyyyMMdd") + "','" + dataGridView2.CurrentRow.Cells["产品编码"].Value.ToString() + "','" + dataGridView2.CurrentRow.Cells["产品名称"].Value.ToString() + "','" + dataGridView2.CurrentRow.Cells["产品型号"].Value.ToString() + "','" + dataGridView2.CurrentRow.Cells["单位"].Value.ToString() + "','" + dataGridView2.CurrentRow.Cells["数量"].Value.ToString() + "','100','," + dataGridView2.CurrentRow.Cells["referCode"].Value.ToString() + "," + getcode + "',' ', ' ', '" + dataGridView2.CurrentRow.Cells["referCode"].Value.ToString() + "', 0,'" + dataGridView2.CurrentRow.Cells["referCode"].Value.ToString() + "',' ',0,0,0,0,-1,0,'" + dataGridView2.CurrentRow.Cells["外部维修单号"].Value.ToString() + "','售后返厂报废[维修单号：" + dataGridView2.CurrentRow.Cells["外部维修单号"].Value.ToString() + "]')";
                //        db.GetStrBySQL(sql);
                //        getcode = "YL" + BuildFrmTo获得服务器时间().ToString("yyyyMMdd") + 序号.ToString().PadLeft(4, '0');
                //    }
                //}
                //出库——卢龙

                //if (dataGridView2.CurrentRow.Cells["维修类型"].Value.ToString() == "售后返厂生产出库")
                //        {
                //            typ = "售后生产维修";
                //        }
                //        else if (dataGridView2.CurrentRow.Cells["维修类型"].Value.ToString() == "售后返厂采购出库")
                //        {
                //            typ = "售后采购维修";
                //        }
                //        else if (dataGridView2.CurrentRow.Cells["维修类型"].Value.ToString() == "售后返厂内部出库")
                //        {
                //            typ = "售后内部维修";
                //        }
                //        getcode = "YL" + BuildFrmTo获得服务器时间().ToString("yyyyMMdd") + 序号.ToString().PadLeft(4, '0');
                //        sql = "INSERT INTO  [BILLnouse2]";
                //        sql += " ([CODE],[BILLTYPE],[BILLDATE],[Client],[TAXTYPE],[BillMan],[Auditing],[BillNote],[StorageName],[StorageWhere], [introducer],[Paytype],[introducerDate],[finishdate],[materialCODE],[materialNAME],[SPECS],[UNITNAME],[QUANTITY],[discount],[freestr10],[REMARK],[batchnumber],[referCode],[boxes],[引用单号2],[MaxValue],[ORIGPRICE],[PRICE],[AMOUNT],[KillBillQty],[REFERQTY],[payedAMOUNT],[freestr8],[freestr9])";
                //        sql += " VALUES('" + getcode + "','" + typ + "','" + DateTime.Now.ToString("yyyyMMdd") + "','" + Bus_DataBus.Bus_CurrentUser_Fullname + "',' ',' ', ' ',' ', ' ', ' ','" + Bus_DataBus.Bus_CurrentUser_Fullname + "','" + dataGridView2.CurrentRow.Cells["外部维修单号"].Value.ToString() + "','" + DateTime.Now.ToString() + "','" + DateTime.Now.ToString("yyyyMMdd") + "','" + dataGridView2.CurrentRow.Cells["产品编码"].Value.ToString() + "','" + dataGridView2.CurrentRow.Cells["产品名称"].Value.ToString() + "','" + dataGridView2.CurrentRow.Cells["产品型号"].Value.ToString() + "','" + dataGridView2.CurrentRow.Cells["单位"].Value.ToString() + "','" + dataGridView2.CurrentRow.Cells["数量"].Value.ToString() + "','100','," + dataGridView2.CurrentRow.Cells["referCode"].Value.ToString() + "," + getcode + "',' ', ' ', '" + dataGridView2.CurrentRow.Cells["referCode"].Value.ToString() + "', 0,'" + dataGridView2.CurrentRow.Cells["referCode"].Value.ToString() + "',' ',0,0,0,0,-1,0,'" + dataGridView2.CurrentRow.Cells["外部维修单号"].Value.ToString() + "','售后返厂报废[维修单号：" + dataGridView2.CurrentRow.Cells["外部维修单号"].Value.ToString() + "]')";
                //        db.GetStrBySQL(sql);
                        //售后完工
                        sql = "UPDATE cukuku set freestr2='" + textBox1.Text.Trim() + "',freedte4='" + DateTime.Now.ToString() + "' where id=" + dataGridView2.CurrentRow.Cells["ID"].Value.ToString();
                BLL.SetToSql(BLL.数据库.默认数据库, sql);
                sql = "select count(*) from  cukuku where freedte4 is null and referCode='" + dataGridView2.CurrentRow.Cells["referCode"].Value.ToString() + "'";

                int i = (int)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Int, sql);
                if (i == 0)
                        {
                            sql = "  UPDATE RukuKu set freenum5='1' where referCode=( select referCode from BILLnouse2 where CODE=( select referCode from cukuKu where ID=" + dataGridView2.CurrentRow.Cells["ID"].Value.ToString() + ") group by referCode)";
                        }
                BLL.SetToSql(BLL.数据库.默认数据库, sql);
                
          
            dataGridView1.DataSource = MC.Get任务单();
            dataGridView2.DataSource = MC.Get已接收任务单();
        }
   
 
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView2.CurrentRow.Cells["单号"].Value.ToString();
            
            if (dataGridView2.CurrentRow.Cells["结束时间"].Value != null)
            {
                if (dataGridView2.CurrentRow.Cells["结束时间"].Value.ToString() != "")
                {
                    textBox1.Text = dataGridView2.CurrentRow.Cells["备注"].Value.ToString();
                    textBox1.ReadOnly = true;
                    button2.Visible = false;
                }
                else
                {
                    textBox1.Text = "";
                    button2.Visible = true;
                    textBox1.ReadOnly = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            string id = dataGridView2.CurrentRow.Cells["ID"].Value.ToString();
                string sql = "Update cukuKu set freedte3='" + DateTime.Now.ToString() + "',[freestr1]='" + textBox2.Text.Trim() + "'  where id=" + id;
            BLL.SetToSql(BLL.数据库.默认数据库, sql);
            dataGridView1.DataSource = MC.Get任务单();
            dataGridView2.DataSource = MC.Get已接收任务单();
        }

   
    }
}
