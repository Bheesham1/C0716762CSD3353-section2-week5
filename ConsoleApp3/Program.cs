using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodA();
        }
        public static void methodA()
        {
            while (peanut())
            {
                Console.WriteLine("Help ! i am stuck in an infinite loop1");
            }
        }
        public static bool peanut()
        {
            return true;
        }
    }

}


