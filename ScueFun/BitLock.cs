using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ScueFun
{
   public class BitLock
   {
        private static Random random = new Random();
        public static string GetLock(string password,string ckey)
        {
            string lock_password = string.Empty;
            foreach (char str in password)
            {
                lock_password = str+"."+ lock_password;//倒序
            }
             
            lock_password = RandomStr.NextString(random, 1, false)+ lock_password + RandomStr.NextString(random, 1, false);//前后任意添加1位大写字符
            return MyAlgorithm.Encrypt(lock_password, ckey);
        }
        public static string GetLock_S(string password, string ckey)
        {
             
            string lock_password = string.Empty;
            foreach (char str in password)
            {
                lock_password = str + RandomStr.NextString(random, 1, false) + lock_password;//倒序
            }
            
           // lock_password = RandomStr.NextString(random, 1, false) + lock_password + RandomStr.NextString(random, 1, false);//前后任意添加1位大写字符
            return MyAlgorithm.Encrypt(lock_password, ckey);
        }
        public static string RealseLock(string lock_password,string ckey)
        {
            string password = string.Empty;
            string get_str = MyAlgorithm.Decrypt(lock_password, ckey);//得到解密后的字符串
            int count = get_str.Length - 2;
            get_str = get_str.Substring(1, count);
            foreach (char str in get_str)
            {
                if (str.Equals('.'))
                {
                    continue;
                }
                else
                {
                    password = str + password;
                }
            }
            return password;
        }
        public static string RealseLock_S(string lock_password, string ckey)
        {
            string password = string.Empty;
            string get_str = MyAlgorithm.Decrypt(lock_password, ckey);//得到解密后的字符串
            // int count = get_str.Length - 2;
            //  get_str = get_str.Substring(1, count);
            int sum = 0;
            foreach (char str in get_str)
            {
                sum++;
                if (sum % 2 == 0)
                {
                    continue;
                }
                else
                {
                    password = str + password;
                }
            }
            return password;
        }
        public static string GetLock_L(string password)
        {
            string lock_password = string.Empty;
            foreach (char str in password)
            {
                lock_password = str + RandomStr.NextString(random, 1, false) + lock_password;//倒序
            }
            return MyAlgorithm.Encode(lock_password);
        }
        public static string RealseLock_L(string lock_password)
        {
            string password = string.Empty;
            string get_str = MyAlgorithm.Decode(lock_password);//得到解密后的字符串
            int sum = 0;
            foreach (char str in get_str)
            {
                sum++;
                if (sum % 2 == 0)
                {
                    continue;
                }
                else
                {
                    password = str + password;
                }
            }
            return password;
        }
        public static string GetLock_KS(string password)
        {
            string lock_password = string.Empty;
            foreach (char str in password)
            {
                lock_password = str + "." + lock_password;//倒序
            }
             
            lock_password = RandomStr.NextString(random, 1, false) + lock_password + RandomStr.NextString(random, 1, false);//前后任意添加1位大写字符
            return MyAlgorithm.Encrypt_KS(lock_password);

        }
        public static string RealseLock_KS(string lock_password)
        {
            string password = string.Empty;
            string get_str = MyAlgorithm.Decrypt_KS(lock_password);//得到解密后的字符串
            int count = get_str.Length - 2;
            get_str = get_str.Substring(1, count);
            foreach (char str in get_str)
            {
                if (str.Equals('.'))
                {
                    continue;
                }
                else
                {
                    password = str + password;
                }
            }
            return password;
        }

    }
}
