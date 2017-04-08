using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170405判断闰年
{
    class Program
    {
        private static bool True;

        static void Main(string[] args)
        {
            //举例：写一个方法判断一个年份是否为闰年；
            string c="不是闰年";
            Console.WriteLine("请输入一个年份，用以判断是否为闰年：");
            string d = Console.ReadLine();
            int a = Convert.ToInt32(d);    //输入的字符串转换为整数； 
            //判断输入的是否为4位年份；
            if (d.Length != 4)
            {
                Console.WriteLine("请重新输入年份:");
                d = Console.ReadLine();
            }
           
            bool b=IsRun(a);
            if (b==True)
            {
                c = "是闰年";
            }
           // Console.WriteLine("您输入的年份是"+d+":"+c);
            Console.WriteLine("您输入的年份是{0}{1}" , d,c);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断给定的年份是否为闰年
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>是否是闰年</returns>
        public static bool IsRun(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 400 != 0);
            return b;
        }
    }
}
