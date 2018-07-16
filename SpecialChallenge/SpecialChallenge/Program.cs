using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Secret Special Sum Checker!");
            Console.WriteLine("Enter a natural number, and this app will return the sum of all multiples of 3 or 5 which are less than that number.");

            int cap = 0, sum = 0;
            bool success = true, repeat = true;
            String repeatSelection;

            while (repeat)
            {
                do
                {
                    try
                    {
                        Console.Write("Enter your cap: ");
                        cap = int.Parse(Console.ReadLine());
                        if (cap < 0) throw new Exception();
                        success = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input. Must be a natural number.");
                        success = false;
                    }
                }
                while (!success);

                sum = 0;

                for (int threes = 3; threes < cap; threes += 3)
                {
                    sum += threes;
                }

                for (int fives = 5; fives < cap; fives += 5)
                {
                    if ((fives % 3) != 0)
                    {
                        sum += fives;
                    }
                }

                Console.WriteLine(sum);

                Console.Write("Continue? (y/n): ");
                repeatSelection = Console.ReadLine().ToLower();
                if(repeatSelection != "y" && repeatSelection != "yes")
                {
                    repeat = false;
                }
            }
            Console.Read();
        }
    }
}
