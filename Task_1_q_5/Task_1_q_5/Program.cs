using System;

namespace Task_1_q_5
{
    class Program
    {
        public static double areaCircumference(double r,ref double area,ref double circumference)
        {
            //double area,circumference;
            
            area = 3.14 * r * r;
            circumference = 2 * 3.14 * r;
   

            //double[] array = new double[2];
            //array[0] = 3.14 * r * r;
            //array[1] = 2 * 3.14 * r;
            //return array;
        }
        static void Main(string[] args)
        {
            

            double area=0, circumference=0;
            //double r = Convert.ToDouble(Console.ReadLine());
            areaCircumference(r, ref area, ref circumference);
    
            //int[] array = areaCircumference(r);

            Console.WriteLine($"Area = {area}, circumference = {circumference}");
            //Console.WriteLine("Area:"+array[0]);

            Console.ReadLine();
        }
    }
}
