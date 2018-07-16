using System;

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

                repeat = RepeatCheck();
            }
            Console.WriteLine("Goodbye.");
            Console.Read();
        }

        static bool RepeatCheck()
        {
            Console.Write("Continue? (y/n): ");
            try
            {
                String repeatSelection = Console.ReadLine().ToLower();
                if (repeatSelection == "y" || repeatSelection == "yes")
                {
                    return true;
                }
                else if (repeatSelection == "n" || repeatSelection == "no")
                {
                    return false;
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
                return RepeatCheck();
            }
        }
    }
}
