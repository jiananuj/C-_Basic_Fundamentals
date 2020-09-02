using System;

namespace _03_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);


            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double x = 1.0;
            double y = 3.0;
            Console.WriteLine(x / y);

            decimal r = 1.0M;
            decimal s = 3.0M;
            Console.WriteLine(r / s);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }
    }
}
