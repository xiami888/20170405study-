using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {

            //// int[] score= {99,88,33,33};
            ////params 可变参数；使用时，可以传任意多的参数；
            ////params 必须是参数列表中的最后一个；只能传递一个可变参数；
            ////将实参列表中跟可变参数数组类型一致的元素，都处理为数组中的元素；
            // Test("张三", 99, 88, 33, 33,90);
            // Test("张三", 99, 88, 33);
            // Console.ReadKey();

            //求任意长度数组的和
            int result = GetSum(1, 2, 3, 4, 5);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        /// <summary>
        /// 给定一个name和一个数组，打印这个名字及数组的和
        /// </summary>
        /// <param name="name">给定的name参数</param>
        /// <param name="score">可变参数</param>
        public static void Test(string name,params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}这次考试的总成绩是{1}",name,sum);
        }

        /// <summary>
        /// 求一个不定长度的数组的和
        /// </summary>
        /// <param name="n">不定长度的数组</param>
        /// <returns>返回和</returns>
        public static int GetSum(params int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum;
        }

        ////引入params
        //static void Main(string[] args)
        //{
        //    int[] score = { 99, 88, 33, 33 };
        //    Test("张三", score);
        //    Console.ReadKey();
        //}
        //public static void Test(string name, int[] score)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < score.Length; i++)
        //    {
        //        sum += score[i];
        //    }
        //    Console.WriteLine("{0}这次考试的总成绩是{1}", name, sum);
        //}
    }
}
