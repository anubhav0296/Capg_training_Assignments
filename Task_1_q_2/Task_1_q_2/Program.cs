using System;

namespace Task_1_q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Accept average marks of five students. Display the highest marks obtained.
            int a, b, c, d, e, hig;
            Console.WriteLine("Enter Average marks of 5 students");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
            {
                hig = a;
                Console.WriteLine("Highest is a: "+hig);
            }
            else if(b > a && b > c && b > d && b > e)
            {
                hig = b;
                Console.WriteLine("Highest is b: " + hig);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                hig = c;
                Console.WriteLine("Highest is c: " + hig);
            }
            else if (d > a && d > b && d > c && d > e)
            {
                hig = d;
                Console.WriteLine("Highest is d: " + hig);
            }
            else if (e > a && e > b && e > c && e > d)
            {
                hig = e;
                Console.WriteLine("Highest is e: " + hig);
            }
            //Console.WriteLine("The highest number is :"+hig);
            Console.ReadLine();
        }
    }
}
