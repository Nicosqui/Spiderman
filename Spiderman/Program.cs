using System;

namespace Spiderman
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of buildings: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Spiderman has to go through " + number + " buildings and has " + CalculatePossiblePaths(number, number) 
                    + " possible paths");

        }

        static int CalculatePossiblePaths(int b, int number)
        {
            //Console.WriteLine("Current Building = " + b);
            Console.WriteLine(number - b);

            if (b >= 2)
            {
                //Console.WriteLine(b-(b-1));
                //Console.WriteLine(b -(b- 2));
                return CalculatePossiblePaths(b - 1, number) + CalculatePossiblePaths(b - 2, number);
            }
            else if (b == 1)
            {
                //Console.WriteLine(b-(b-1));
                return CalculatePossiblePaths(b - 1, number);
            }
            // There are no buildings left, a path has been completed.
            else
            {
                return 1;
            }
        }

    }
}
