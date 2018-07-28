using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using makelanlan;
using System.Drawing;

namespace 售后
{
    //---帮助文档----
    //select * from m_rukuku                  //主线数据
    // select* from dbo.m_rukukuinfo           //分支数据
    //
    //
    //
    class Ifnn {
        public static string 保内外(string str)
        {
            return str == "保修" ? "保内" : "保外";
        }



        public static decimal CheaTxttoini(TextBox Tb,decimal Wxtime,decimal old=0) {

            if (!decimal.TryParse(Tb.Text, out Wxtime))
            {
                Tb.Text = old.ToString();
                Wxtime = old;
            }
            else
            {
                Wxtime = decimal.Parse(Tb.Text);
            }
            return Wxtime;
        }



    }
    class Mcc
    {
        //界面A 
   

        public void SetTo维修库(string sql) =>  BLL.SetToSql(BLL.数据库.默认数据库, sql);
         
       
        public DataTable Get物料申请单()
        {
            DataTable dt = new DataTable();
            string sql = "select" +
                " Paytype as 维修单, introducer as 录单人,materialNAME as 物料, materialCODE as 编号,SPECS as 型号,UNITNAME as 单位, QUANTITY as 数量,freestr7 as 借用,code,ID  " +
                "from BILLnouse2 where BILLTYPE ='售后返厂维修' and (isnull(Paytype,'')<>'')and left(code,1)<>'*' and freenum4 is null";
            dt = (DataTable)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Table, sql);
            return dt;
        }

        public void Update接收维修信息(int _id) {
            string sql = "update BILLnouse2 set freenum5=1 where ID =" + _id;
            BLL.SetToSql(BLL.数据库.默认数据库,sql);
        }



            public DataTable Get维修单info(string DD)
            {
            DataTable dt = new DataTable();
            string sql = " select top 1  zf5 as 判断,"+
                 " (select 出厂日期 from cukku_SerialNumber where 出厂编号 = clientservice_AfterServiceBill.zf1)as 出厂日期 , "+
                 "  BillMan as 维修员,zf1 as 机床码 ,  BILLTYPE as 类型 , Client as 客户 " +
                  "from clientservice_AfterServiceBill where code ='"+DD+"'" ;
            dt = (DataTable)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Table, sql);
            return dt;
             }

        public DataTable Get维修单s(bool b=false)
        {
            DataTable dt = new DataTable();
            string setp = " isnull(is完成,'')='' ";
            if (b) setp = " is完成='1' ";
            // ID, CODE, 关联ID, 关联号, 维修单, 录单人, 录单时间, 类型, 编号, 物料, 单位, 数量, 已处理, 仓库, 客户, 机床码, 维修人, 审核人, 维修类型, 责任人, 要求时间, 初判费用, IS完成
            string Sj = " ID, CODE,维修单 ,录单时间,维修人 ,关联ID, 关联号, 编号, 物料, 单位, 数量, 已处理, 客户, 机床码 ";
 
            string sql = "select "+ Sj  + " from m_rukuku where 1=1 " +
           "     and  " + setp + " and Left(Code,1)<> '*' ";
            dt = (DataTable)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Table, sql);
            return dt;
        }

        public DataTable 分配维修单(string _id)
        {
            DataTable dt = new DataTable();
            string Scd = " ";
            Scd = " and id=" + _id;
            string sql = "select id,code, 编号,物料,单位,数量,客户,维修人,已处理 from m_rukuku where 1=1 " +
            "  and Left(Code,1)<> '*' " + Scd;
            dt = (DataTable)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Table, sql);
            return dt;
        }
        public DataTable Get维修单()
        {
            DataTable dt = new DataTable();
            string sql = "select * from m_rukuku where 1=1 " +
            "  and Left(Code,1)<> '*' ";
            dt = (DataTable)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Table, sql);
            return dt;
        }

        //界面B
        public DataTable Get待处理量(string str)
        {
            DataTable dt = new DataTable();
            string sql = "select  ID,CODE 单号," +
                " QUANTITY 数量 " +
                " from BILLnouse2  " +
                " where billtype in('售后返厂报废','售后生产维修（出库）','售后采购维修（出库）'," +
                "'售后内部维修（出库）','售后领料归还') and referCode='" + str + "' ";

            dt = (DataTable)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Table, sql);
            return dt;
        }

        public DataTable Get入库量(string str)
        {
            DataTable dt = new DataTable();
            string sql = "select ID,CODE 单号, Paytype 外部维修单号,introducerDate 录入时间," +
                "materialCODE 产品编码,materialNAME 产品名称,SPECS 产品型号, QUANTITY 数量," +
                "freestr1 责任人,freestr4 内部维修部门, freestr7 是否客户借用 from " +
                "RukuKu where referCode= '" + str + "'";


            dt = (DataTable)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Table, sql);
            return dt;
        }

        public DataTable Get部门人员(string str)
        {
            DataTable dt = new DataTable();
            string sql = "  select turename +'|' + dept from puku where dept in(" + str + ") and isStop<>'是'";
            dt = (DataTable)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Table, sql);
            return dt;
        }


        //------------------内部维修-------------------

        public DataTable Get已接收任务单()
        {
            DataTable dt = new DataTable();
            string sql = "select ID,CODE 单号,BILLTYPE 维修类型,referCode, Paytype 外部维修单号,introducerDate 录入时间,materialCODE 产品编码,materialNAME 产品名称,SPECS 产品型号, QUANTITY 数量,UNITNAME 单位,freestr1 责任人,freestr4 内部维修部门, freestr7 是否客户借用,freedte3,freedte4,freedte1 要求完成时间,freestr2 备注 from cukuKu where  billtype in('售后返厂内部出库','售后返厂生产出库','售后返厂采购出库') and freestr5='" + UserInfo.UName + "' and freedte2 <>'' ";
            dt = (DataTable)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Table, sql);
            return dt;
        }



        public DataTable Get任务单()
        {
            DataTable dt = new DataTable();
            string sql = "select r.编号,r.物料,r.单位,r.数量 ,i.*,r.CODE ,r.维修单 from m_rukuku r,m_rukukuinfo i where i.Fid =r.ID and (i.责任部门='' or i.责任人='') order by i.要求时间  ";
            dt = (DataTable)BLL.SqltoView(BLL.数据库.默认数据库, BLL.数据类型.Table, sql);
            return dt;
        }

        //--------------------------------------

  


        //------------------基础块---------------------


        public void SetLabel(Label l, string str, bool n = false) {
            Label lb = new Label
            {
                Text =str,
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft 
                
            };
            if (n)  lb.AutoSize = true;
            lb.Parent = l;

        }

       
        //--------------------------------------------------





    }
}
