using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScueFun;

namespace ScueFun
{
    public class InnerHtml
    {
        public static string SetForm<T>(T t)
        {
            string form_str = string.Empty;
            Dictionary<string,string> dic = ScueMerge.GetProperties(t);
            foreach (string key in dic.Keys)
            {
                string a = key + "id";
                form_str += "<p>" + key + "：<input id=\"" + key + "id\" type=\"" + dic[key] + 
                    "\" name=\"" + key + "name\" class=\"f\" /> </p> ";
            }
            return form_str;
        }
    }
}
