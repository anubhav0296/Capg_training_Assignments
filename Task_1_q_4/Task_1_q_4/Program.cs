using System;

namespace Task_1_q_4
{
    class Program
    {
        public static void swap(int a,int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"The swapped value is a={a} b={b}");
        }
        static void Main(string[] args)
        {
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            swap(x, y);
        }
    }
}
