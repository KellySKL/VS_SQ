using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using makelanlan;
namespace ScueFun
{
   public  class Code
    {
        public static string BasicCode()
        {
            BLL.数据库 数据库=new BLL.数据库();
            List<object>  obj = BLL.SqlToObj(数据库, " select code from clientservice_visitBill where left(code,10)='YW'+CONVERT(varchar(12), getdate(),112)  order by id desc ");
            int maxV;
            if (obj.Count <= 0)
            {
                maxV = 1;
            }
            else
            {
                string dbcode = obj[obj.Count - 1].ToString();
                if (dbcode.Length >= 4)
                {
                    string str = dbcode.Substring(dbcode.Length - 4);
                    maxV = Convert.ToInt32(str) + 1;
                }
                else
                {
                    maxV = 1;
                }
            }
            List<clientservice_AfterServiceBill> objs = BLL.SqlToList<clientservice_AfterServiceBill>(数据库, " select b.id,b.code,b.billtype,b.client,b.billman,b.zf1,nouse_id as sz1 from (select id as nouse_id,paytype from BILLnouse2 where  BILLTYPE ='售后返厂维修' and (isnull(Paytype,'')<>'')and left(code,1)<>'*' and  (freenum5 is null or freenum5 < 1) ) as c left join clientservice_AfterServiceBill b on c.Paytype=b.code ");
            //单据号： YW+yyyyMMdd+四位流水号
            string code = "YW"+ System.DateTime.Now.ToString("yyyyMMdd") + maxV.ToString().PadLeft(4, '0');          
            return code;
        }

    }
}
