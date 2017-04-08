using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取输入的整数，
            //多次调用（如果用户输入的是数字，则返回，否则提示用户重新输入）
            Console.WriteLine("请输入一个数字");
            string input = Console.ReadLine();
           int number= GetNumber(input);
            Console.WriteLine(number);
            Console.ReadKey();
    
        }
        /// <summary>
        /// 获取输入的数字，转换为整数；
        /// </summary>
        /// <param name="s">传入的参数，如果转换错误，则赋值为用户新输入的字符串</param>
        /// <returns>返回转换后的整数</returns>
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("您输入的有误，请重新输入：");
                    s = Console.ReadLine();
                }
            }
        }
        //该写法不推荐，使用方法；
        //static void Main(string[] args)
        //{
        //    //读取输入的整数，
        //    //多次调用（如果用户输入的是数字，则返回，否则提示用户重新输入）
        //    while (true)
        //    {
        //        Console.WriteLine("请输入一个数字");
        //        try
        //        {
        //            int number = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine(number);
        //            break;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("输入有误！！！！");
        //        }
        //    }
        //    Console.ReadKey();
        //}
    }
}
