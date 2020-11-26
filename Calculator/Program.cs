using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("\t\t\tSimple Calculator Program\n\n\n");
            

                


            Program p = new Program();
            
            p.Calculate();
           
        }


        //public ,private ,protected,internal ,protected internal(Access modifiers)

     public void Calculate()
        {
            double a, b, c;
            char ch, p;
            System.Threading.Thread.Sleep(500);
            Console.Write("Enter First Value:\t");
         a = Convert.ToDouble(Console.ReadLine());
           // a = Convert.ToDouble(Console.ReadLine());
        


            Console.Write("Enter Second Value:\t");
            b = Convert.ToDouble(Console.ReadLine());
         
         Console.Write("\n\nTell What You Want To Do !!!!!!!\n[a=add,s=subtract,m=multiply,d=divide]:\t");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    c = a + b;
                    Console.WriteLine("{0} + {1} = {2}",a,b,c);
                    break;
                case 's':
                    c = a - b;
                    Console.WriteLine("{0} - {1} = {2}", a, b, c);
                    break;
                case 'm':
                    c = a * b;
                    Console.WriteLine("{0} * {1} = {2}", a, b, c);
                    break;
                case 'd':
                    c = a / b;
                    Console.WriteLine("{0} / {1} = {2}", a, b, c);
                    break;
                default:
                    Console.WriteLine("Invalid Operation!!!!!!!!!!!");
                    break;
            }


            System.Threading.Thread.Sleep(500);

            Console.Write("Want to perform another opeartion :[Y/N]\n");
            p = Convert.ToChar(Console.ReadLine());
            if (p == 'y')
            {

                Calculate();


            }
            else if (p != 'n')
            {
                Console.Write("Please press a desired key:\t");
                p = Convert.ToChar(Console.ReadLine());
                if (p == 'n')
                {
                    Console.Write("Good Bye!!!!!!!");
                    System.Threading.Thread.Sleep(500);
                    Environment.Exit(0);

                }
                 else if (p == 'y')
                {

                    Calculate();


                }
                else
                {
                    Console.Write("Input error occur program is terminating....................");
                    System.Threading.Thread.Sleep(1500);
                    Environment.Exit(0);

                }
            }
            else
            {
                Console.Write("Good Bye!!!!!!!");
                System.Threading.Thread.Sleep(500);
                Environment.Exit(0);
                
            }


            //Console.Write("you enter: " +ch);
          
        }
    }
}
