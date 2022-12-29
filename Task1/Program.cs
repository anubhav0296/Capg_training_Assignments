using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum, diff, mul, div;
            Console.WriteLine("Enter 2 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            diff = a - b;
            mul = a * b;
            div = a / b;
            Console.WriteLine("The addition of 2 number is:" + sum);
            Console.WriteLine("The subtraction of 2 number is:" + diff);
            Console.WriteLine("The multiplication of 2 number is:" + mul);
            Console.WriteLine("The division of 2 number is:" + div);
            Console.ReadLine();

        }
    }
}
