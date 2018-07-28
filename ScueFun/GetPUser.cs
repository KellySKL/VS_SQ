using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using makelanlan;
namespace ScueFun
{
    public class GetPUser
    {
        public static List<puku_user> PUser(string str_where)
        {
            puku_user user = new puku_user();
            return user.Select(str_where + " and ISSTOP <> '是' ");
        }
        public static List<puku_user> PUser()
        {
            puku_user user = new puku_user();
            return user.Select(" and ISSTOP <> '是' ");
        }
    }
}
