using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法概念
{
    class Program
    {
        static void Main(string[] args)
        {
            //比较两个数字的大小，返回最大值；
            int a1 = 10;
            int a2 = 20;
            int max=getMax(a1, a2);//实参
            Console.WriteLine(max);
            Console.ReadKey();
        }
        /// <summary>
        /// 比较两个数的大小，返回数字较大的；
        /// </summary>
        /// <param name="n1">第一个数</param>
        /// <param name="n2">第二个数</param>
        /// <returns>返回的最大值</returns>
        public static int getMax(int n1,int n2)//形参
        {
           int max= n1 > n2 ? n1 : n2;
            return max;
        }
    }
}
