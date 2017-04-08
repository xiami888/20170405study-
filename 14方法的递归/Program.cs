using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14方法的递归
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法的递归;方法自己调用自己
            TellStory();
            Console.ReadKey();
        }
        //静态字段，当做全局变量来处理；
        public static int i = 0;

        /// <summary>
        /// 方法的递归，自己调用自己；
        /// </summary>
        public static void TellStory()
        {
            //int i = 0;
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有个老和尚和小和尚");
            Console.WriteLine("有一天，小和尚哭了，老和尚给小和尚讲了一个故事：");
            i++;
            if (i >= 10)
            {
                return;
            }
            TellStory();//会陷入死循环，就算方法的递归总也有一个停止的条件
        }
    }
}
