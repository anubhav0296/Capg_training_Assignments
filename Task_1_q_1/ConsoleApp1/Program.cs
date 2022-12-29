using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a instructions
            /*
             * 
             */
            int a, b, c, lar;
            Console.WriteLine("Enter the three numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    lar = a;
                }
                else
                {
                    lar = c;
                }
            }
            else
            {
                if (b > c)
                {
                    lar = b;
                }
                else
                {
                    lar = c;
                }
            }
            
            Console.WriteLine("The largest no is " + lar);
            Console.ReadLine();

        }
    }
}
