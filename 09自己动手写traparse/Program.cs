using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09自己动手写traparse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            //bool b = int.TryParse("123",out num);
            bool b = MyTryParse("1233.", out num);
            Console.WriteLine(num);
            Console.WriteLine(b);
            Console.ReadKey();
        }
        public static bool MyTryParse(string s,out int result)
        {
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch 
            {
                result = 0;
                return false;
            }
        }
    }
}
