using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            ////方法的重载
            ////单独调用，如何使用一个方法实现这几种调用——方法的重载；
            //m1(1, 2);
            //m2(1.2, 1.3);
            //m3(1, 2, 3);
            //m4("aaa", "bbb");

            //重载：方法的名称相同，参数不同；
            // 1、如果参数的个数相同，参数的类型就不能相同；
            // 2、如果参数的类型相同，参数的个数就不能相同；
            // 3、方法的返回值跟重载没有关系；
            //同一个方法，传入不同的参数；
            m(1, 2);
            m(1.2, 1.3);
            m(1, 2, 3);
            m("aaa", "bbb");
        }

        #region  重载方法m
        public static void m(int n1, int n2)
        {
            int result = n1 + n2;
        }
        public static double m(double d1, double d2)
        {
            return d1 + d2;
        }
        public static void m(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
        }
        public static string m(string s1, string s2)
        {
            return s1 + s2;
        }
        #endregion

        #region  4个单独的方法
        public static void m1(int n1, int n2)
        {
            int result = n1 + n2;
        }
        public static double m2(double d1, double d2)
        {
            return d1 + d2;
        }
        public static void m3(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
        }
        public static string m4(string s1, string s2)
        {
            return s1 + s2;
        }
        #endregion
    }
}
