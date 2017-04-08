using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法，求一个数组中的最大值、最小值、总和、平均值
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //将要返回的4个值，放到一个数组中返回:该种方法可以返回同一组类型的，
            //如int，但是不能返回混合类型；使用out参数可以；
            //out 参数就侧重于在一个方法中可以返回多个不同类型的值；

            //int[] res = GetMaxMinSumAvg(numbers);
            //Console.WriteLine("最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}",res[0],res[1],res[2],res[3]);
            //Console.ReadKey();

            PrintMyGetString(numbers);

            int max;
            int min;
            int sum;
            int avg;
            bool b;
            string s;
            double d;
            Test(numbers, out max, out min, out sum, out avg,out b,out s,out d);
            Console.WriteLine("最大值为：{0}",max);
            Console.WriteLine("最小值为：{0}", min);
            Console.WriteLine("总和为：{0}", sum);
            Console.WriteLine("平均值为：{0}", avg);
            Console.WriteLine("bool值为：{0}", b);
            Console.WriteLine("字符串为：{0}", s);
            Console.WriteLine("double值为：{0}", d);
            Console.ReadKey();


        }
        /// <summary>
        /// 计算一个给定数组的最大值最小值总和平均值；
        /// </summary>
        /// <param name="nums">给定的数组</param>
        /// <returns>返回的数组</returns>
        public static int[] GetMaxMinSumAvg(int[] nums)
        {
            int[] res = new int[4];
            //假设res[0] 最大值  res[1]最小值  res[2]总和  res[3]平均值
            res[0] = nums[0];//最大值
            res[1] = nums[0];//最小值
            res[2] = 0;//总和
            for (int i = 0; i < nums.Length; i++)
            {
                //如果当前循环到的元素比我假定的最大值还大，就将当前值赋给我的最大值；
                if (nums[i] > res[0])
                {
                    res[0] = nums[i];
                }
                //如果当前循环到的元素比我假定的最小值还小，就将当前值赋给我的最小值；
                if (nums[i] < res[1])
                {
                    res[1] = nums[i];
                }
                res[2] += nums[i];
            }
            res[3] = res[2] / nums.Length;
            return res;        }


        /// <summary>
        /// 计算最大值最小值总和平均值
        /// </summary>
        /// <param name="nums">要求值得数组</param>
        /// <param name="max">最大值</param>
        /// <param name="min">最小值</param>
        /// <param name="sum">总和</param>
        /// <param name="avg">平均值</param>
        public static void Test(int[] nums,out int max,out int min,out int sum,out int avg,out bool b,out string s,out double d )
        {
            //out参数要求在方法的内部必须为其赋值；
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i=0;i<nums.Length;i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i]<min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;
            b = true;
            s = "123123adf";
            d = 3.14;
        }
        /// <summary>
        /// 把给定的数组输出到屏幕中
        /// </summary>
        /// <param name="str">给定的数组</param>
        public static void PrintMyGetString(int[] str)
        {
            string s = "";
            for (int i = 0; i < str.Length; i++)
            {
                s += str[i].ToString()+" ";
            }
            Console.WriteLine("给定的数组为：{0}",s);
        }


        #region 使用数组的方法返回多个值；
        //static void Main(string[] args)
        //{
        //    //写一个方法，求一个数组中的最大值、最小值、总和、平均值
        //    int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    //将要返回的4个值，放到一个数组中返回:该种方法可以返回同一组类型的，
        //    //如int，但是不能返回混合类型；使用out参数可以；
        //    //out 参数就侧重于在一个方法中可以返回多个不同类型的值；
        //    int[] res = GetMaxMinSumAvg(numbers);
        //    Console.WriteLine("最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}", res[0], res[1], res[2], res[3]);
        //    Console.ReadKey();
        //}
        ///// <summary>
        ///// 计算一个给定数组的最大值最小值总和平均值；
        ///// </summary>
        ///// <param name="nums">给定的数组</param>
        ///// <returns>返回的数组</returns>
        //public static int[] GetMaxMinSumAvg(int[] nums)
        //{
        //    int[] res = new int[4];
        //    //假设res[0] 最大值  res[1]最小值  res[2]总和  res[3]平均值
        //    res[0] = nums[0];//最大值
        //    res[1] = nums[0];//最小值
        //    res[2] = 0;//总和
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        //如果当前循环到的元素比我假定的最大值还大，就将当前值赋给我的最大值；
        //        if (nums[i] > res[0])
        //        {
        //            res[0] = nums[i];
        //        }
        //        //如果当前循环到的元素比我假定的最小值还小，就将当前值赋给我的最小值；
        //        if (nums[i] < res[1])
        //        {
        //            res[1] = nums[i];
        //        }
        //        res[2] += nums[i];
        //    }
        //    res[3] = res[2] / nums.Length;
        //    return res;
        //}
        #endregion
    }
}
