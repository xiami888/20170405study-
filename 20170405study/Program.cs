using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170405study
{
    public enum Gender
    {
        男,
        女
    }

    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }

    class Program
    {
        //方法的作用域：可以使用静态字段，模拟全局变量
        public static int _number = 10;
        static void Main(string[] args)
        {
            ////枚举测试
            ////Gender gender = Gender.男;
            //string s = "男";
            //Gender g = (Gender)Enum.Parse(typeof(Gender), s);
            //Console.WriteLine(g);
            ////常量、枚举、结构、数组
            ////const int number = 10;

            ////结构测试
            //Person myperson;
            //myperson._age = 20;
            //myperson._gender = Gender.男;
            //myperson._name = "测试";
            //Console.WriteLine(myperson._age);
            //Console.ReadKey();

            //参数的作用域
            int a = 3;
            Test(a);
            Console.WriteLine(a);//作为参数传递时可以找到a；
            Console.WriteLine(_number);//全局变量可以访问；
            Console.ReadKey();
        }
        public static void Test(int a )
        {
            a = a + 5;
        }

        //该方法找不到a，会报错，因为参数的作用域不同；
        //static void Main(string[] args)
        //{         
        //    //参数的作用域
        //    int a = 3;
        //    Test(a);
        //    Console.WriteLine(a);
        //    Console.WriteLine(_number);
        //    作为参数传递时可以找到a；
        //    Console.ReadKey();
        //}
        //public static void Test(int a)
        //{
        //    a = a + 5;
        //}
    }
}
