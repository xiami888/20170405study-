using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入两个数字，计算这两个数字之间所有整数的和；
            //1、用户只能输入数字;
            //2、计算两个数字之间和；
            //3、要求第一个数字必须比第二个数字小  就重新输入；
            Console.WriteLine("题目：用户输入两个数字，计算这两个数字之间所有整数的和。");
            Console.WriteLine("请输入第一个数字：");
            string strNumberOne = Console.ReadLine();
            int numberOne = GetNumber(strNumberOne);
            Console.WriteLine("请输入第二个数字：");
            string strNumberTwo = Console.ReadLine();
            int numberTwo = GetNumber(strNumberTwo);

            //判断第一个数字是否小于第二个数字
            JudgeNumber(ref numberOne,ref numberTwo);
            //求和
            int sum = GetSum(numberOne,numberTwo);
            Console.WriteLine("您输入的两个整数为:{0}和{1}，中间所有整数和为：{2}。",numberOne,numberTwo,sum);
            Console.ReadKey();
        }
        /// <summary>
        /// 获得第一个数和第二个数之间整数的和；
        /// </summary>
        /// <param name="n1">用户输入的第一个整数</param>
        /// <param name="n2">用户输入的第二个整数</param>
        /// <returns>返回两个数之间整数的和</returns>
        public static int GetSum(int n1, int n2)
        {
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }


        /// <summary>
        /// 判断用户输入的第一个数和第二个数，得到的结果是第一个数小于第二个数
        /// </summary>
        /// <param name="n1">用户输入的第一个数</param>
        /// <param name="n2">用户输入的第二个数</param>
        public static void JudgeNumber(ref int n1, ref int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    //符合题意；
                    return;
                }
                else
                {
                    //不符合题意
                    Console.WriteLine("第一个数字不能大于或等于第二个数字，请重新输入第一个数字：");
                    string s1 = Console.ReadLine();
                    //调用GetNumber；
                    n1 = GetNumber(s1);
                    Console.WriteLine("请重新输入第二个数字：");
                    string s2 = Console.ReadLine();
                    n2 = GetNumber(s2);
                }
            }
        }

        /// <summary>
        /// 把一个输入的字符串转换为数字
        /// </summary>
        /// <param name="s">用户输入的字符串</param>
        /// <returns>转换后的数字</returns>
        public static int GetNumber(string s)
        {
            while(true)
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch (Exception)
                {
                    Console.WriteLine("输入有误，请重新输入：");
                    s = Console.ReadLine();
                }
        }
    }
}
