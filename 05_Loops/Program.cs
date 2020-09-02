using System;

namespace _05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            first();
            second();

            
        }

        static void first()
        {
            Console.WriteLine("");
            Console.WriteLine("--------------Inside First---------");


            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }
        }

        static void second()
        {
            Console.WriteLine("");
            Console.WriteLine("--------------Inside Second---------");
            Console.WriteLine("--------------Branches and loops combined---------");


            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
