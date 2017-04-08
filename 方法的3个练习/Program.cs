using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////2 学习循环时，只允许用户输入y或n，请改成方法；
            ////该方法用于判断用户输入的是否为yes或no，否则重新输入；
            ////输入yes 看，输入no 不能看
            //Console.WriteLine("请输入yes或者no");
            //string str = Console.ReadLine();
            //string resulet = IsYesOrNo(str);
            //Console.WriteLine(resulet);
            //Console.ReadKey();

            //4计算输入的数组的和：int sum（int[] values）
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int sum = GetSum(nums);
            Console.WriteLine("数组的总和为：{0}",sum);
            Console.ReadKey();

        }
        #region 限定用户输入的只能是yes或者no
        /// <summary>
        /// 限定用户只能输入yes或者no，并且返回
        /// </summary>
        /// <param name="input">用户的输入</param>
        /// <returns>返回yes或者no</returns>
        public static string IsYesOrNo(string input)
        {
            while (true)
            {
                if (input == "yes" || input == "no")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("只能输入yes或者no，请重新输入：");
                    input = Console.ReadLine();
                }
            }

        }
        #endregion

        #region 求一个数组的和
        /// <summary>
        /// 求一个数组的和
        /// </summary>
        /// <param name="nums">输入的数组</param>
        /// <returns>返回数组的和</returns>
        public static int GetSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        #endregion
    }
}
