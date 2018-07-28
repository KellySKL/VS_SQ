using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using makelanlan;
namespace ScueFun
{
    public  class WebClass
    {
        public static List<PersonLOC> GetPep(int id, string type,string datetime)
        {
            List<PersonLOC> locs = new List<PersonLOC>();
            ClientService_kfku k = new ClientService_kfku();
            List<ClientService_kfku> ts = k.Select(" and id=" + id);
            string position;
            string lng;//经度
            string lat;//纬度
            if (ts.Count > 0)
            {
                position = ts[0].ZF29;
                string[] strs = position.Split(',');
                lng = strs[0];
                lat = strs[1];
            }
            //只取当天人的最新记录
            string sql = "select * from scue_user a where not exists(select 1 from scue_user b where b.userpu=a.userpu and b.id>a.id) and a.operatetime like ('" + datetime + "%')";
            List<scue_user> scue_s = BLL.SqlToList<scue_user>(new BLL.数据库(), sql);
            foreach (scue_user s in scue_s)
            {
                string[] strs = s.POINTS.Split(',');
                int count = strs.Length - 2;//最后一个是空的
                string newpoi = strs[count];
                string[] poi = newpoi.Split(':');
                PersonLOC o = new PersonLOC();
                o.userId = s.USERPU;
                o.userName = s.TURENAME;
                o.lng = Convert.ToDouble(poi[0]);
                o.lat = Convert.ToDouble(poi[1]);
                locs.Add(o);
            }

            //if (type.Trim() == "YW")
            //{

            //}
            //else if (type.Trim() == "YW")
            //{

            //}
            //else
            //{

            //}

            return locs;
        }



        public class PersonLOC
        {
            private string _userId;
            private string _userName;
            private double _lng;
            private double _lat;
            public string userId { get { return _userId; } set { _userId = value; } }
            public string userName { get { return _userName; } set { _userName = value; } }
            public double lng { get { return _lng; } set { _lng = value; } }
            public double lat { get { return _lat; } set { _lat = value; } }

        }
    }
}
