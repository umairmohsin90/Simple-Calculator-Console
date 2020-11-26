using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Class1
    {

        public static void Main(string[] args)
        {
            var KP = Console.ReadKey();
            if (KP.Key == ConsoleKey.F2)
            {
                return;
            }

            string UserName = KP.KeyChar + Console.ReadLine();

            Console.WriteLine(UserName);
            Console.ReadLine();
        }
    }
}
