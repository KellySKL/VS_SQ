using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScueFun
{
    public static class ScueMerge
    {
        /// <summary>
        /// 融合模板实体 到 请求的实体类 （只融合相同字段，存在覆盖性）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="merged">请求融合的实体类（模板）</param>
        /// <param name="model">被请求融合的实体类（模板）</param>
        public static T1 MergeFrom<T1,T2>(T1 merged, T2 model)
        {
            //System.Reflection.Assembly assembly = System.Reflection.Assembly.GetAssembly(typeof(T));
            //T1 entry = (T1)assembly.CreateInstance(typeof(T1).FullName);
            //System.Text.StringBuilder sb = new StringBuilder();
            //Type type = entry.GetType();

            //System.Reflection.Assembly assembly_2 = System.Reflection.Assembly.GetAssembly(typeof(T));
            //T2 entry_2 = (T2)assembly.CreateInstance(typeof(T2).FullName);
            //System.Text.StringBuilder sb_2 = new StringBuilder();
            //Type type_2 = entry.GetType();
            Dictionary<string, string> dic_model = GetProperties(model);
            Dictionary<string, string> dic_merged = GetProperties(merged);
            //遍历key
            foreach (string key in dic_model.Keys)
            {
                if (dic_merged.Keys.Contains(key) && key!= "")
                {
                    dic_merged[key] = dic_model[key];
                }
            }
            return GetEntityDictionaryToEntity<T1>(dic_merged);
        }

        /// <summary>
        /// 获得实体类的 Dictionary<string, string>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetProperties<T>(T t)
        {
            Dictionary<string, string> ret = new Dictionary<string, string>();

            if (t == null)
            {
                return null;
            }
            System.Reflection.PropertyInfo[] properties = t.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            if (properties.Length <= 0)
            {
                return null;
            }
            foreach (System.Reflection.PropertyInfo item in properties)
            {
                string key = item.Name;                                                  //实体类字段名称  
                object obj = item.GetValue(t, null);                //该字段的值  

                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    string value = string.Format("{0}", obj);
                    ret.Add(key, value);        //在此可转换value的类型  
                }
            }

            return ret;
        }

        /// <summary>
        /// 将实体类通过反射组装成字符串
        /// </summary>
        /// <param name="t">实体类</param>
        /// <returns>组装的字符串</returns>
        public static string GetEntityToString<T>(T t)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            Type type = t.GetType();
            System.Reflection.PropertyInfo[] propertyInfos = type.GetProperties();
            for (int i = 0; i < propertyInfos.Length; i++)
            {
                sb.Append(propertyInfos[i].Name + ":" + propertyInfos[i].GetValue(t, null) + ",");
            }
            return sb.ToString().TrimEnd(new char[] { ',' });
        }

        /// <summary>
        /// 将反射得到 dictionary 转换为对象
        /// </summary>
        /// <param name="dictionary">反射得到的Dictionary<string, string></param>
        /// <returns>实体类</returns>
        public static T GetEntityDictionaryToEntity<T>(Dictionary<string, string> dictionary)
        {
            //string[] array = str.Split('-');
            //string[] temp = null;
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //foreach (string s in array)
            //{
            //    temp = s.Split(':');
            //    dictionary.Add(temp[0], temp[1]);
            //}
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetAssembly(typeof(T));
            T entry = (T)assembly.CreateInstance(typeof(T).FullName);
            System.Text.StringBuilder sb = new StringBuilder();
            Type type = entry.GetType();
            System.Reflection.PropertyInfo[] propertyInfos = type.GetProperties();
            for (int i = 0; i < propertyInfos.Length; i++)
            {
                foreach (string key in dictionary.Keys)
                {
                    if (propertyInfos[i].Name == key.ToString())
                    {
                        propertyInfos[i].SetValue(entry, GetObject(propertyInfos[i], dictionary[key]), null);
                        break;
                    }
                }
            }
            return entry;
        }
        /// <summary>
        /// 转换值的类型
        /// </summary>
        /// <param name="p"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        static object GetObject(System.Reflection.PropertyInfo p, string value)
        {
            switch (p.PropertyType.Name.ToString().ToLower())
            {
                case "int16":
                    return Convert.ToInt16(value);
                case "int32":
                    return Convert.ToInt32(value);
                case "int64":
                    return Convert.ToInt64(value);
                case "string":
                    return Convert.ToString(value);
                case "datetime":
                    return Convert.ToDateTime(value);
                case "boolean":
                    return Convert.ToBoolean(value);
                case "char":
                    return Convert.ToChar(value);
                case "double":
                    return Convert.ToDouble(value);
                default:
                    return value;
            }
        }
    }
}
