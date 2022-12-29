using System;

namespace Task1_q_3
{
    class Program
    {
        public static int sum(params int[] list)
        {
            int sum1 = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum1 = sum1 + list[i];
            }
            return sum1;
            //Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int total;

            //Can also give input this way
            //UseParams(1, 2, 3, 4);

            // Or give input this way
            int[] inputArray = { 5, 6, 7, 8, 9 };
            total = sum(inputArray);
            Console.WriteLine("The sum is:" + total);
            Console.ReadLine();
        }
    }
}
