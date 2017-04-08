using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ref的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用方法来交换两个int类型的变量
            int n1 = 10;
            int n2 = 20;
            ////使用第三个变量存储；
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;

            ////不使用第三个变量交换值
            //n1 = n1 - n2; //-10  20
            //n2 = n1 + n2; //-10 10
            //n1 = n2 - n1; //20 10
            
            //ref参数要求在方法外必须为其赋值，方法内部可以不赋值；
            //out参数要求在方法内部必须为其赋值，方法外部可以不赋值；

            //调用方法；
            ChangeTwoInt(ref n1, ref n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.ReadKey();
        }
        public static void ChangeTwoInt(ref int n1,ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;

        }
    }
}
