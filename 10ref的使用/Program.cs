using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ref的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 5000;
            JiangJin(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey();
        }
        /// <summary>
        /// 奖金加500，使用ref，将一个变量带入方法中改变，改变后可以带出方法
        /// 方法及使用时都要使用ref；
        /// </summary>
        /// <param name="s">传入的参数</param>
        public static void JiangJin(ref double s)
        {
            s += 500;
            //return s;
        }
        public static void FaKuan(double s)
        {
            s -= 500;
        }
    }
}
