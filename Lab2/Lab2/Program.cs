using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            bool repeat = true;
            double length, width, height;

            while (repeat)
            {
                try
                {
                    Console.Write("\nEnter Length: ");
                    length = Math.Abs(double.Parse(Console.ReadLine()));
                    Console.Write("Enter Width: ");
                    width = Math.Abs(double.Parse(Console.ReadLine()));
                    Console.Write("Enter Height: ");
                    height = Math.Abs(double.Parse(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("Invalid input. Must be a number.");
                    continue;
                }

                Console.WriteLine("\nArea: " + (length * width) + " square feet");
                Console.WriteLine("Volume: " + (length * width * height) + " cubic feet");
                Console.Write("Perimeter: ");
                DoubleToFeetInches(2 * length + 2 * width);

                repeat = CheckRepeat();
            }
            Console.WriteLine("\nGoodbye!");

            Console.Read();
        }

        static bool CheckRepeat()
        {
            String repeatSelection;

            Console.Write("Continue? (y/n): ");
            repeatSelection = Console.ReadLine().ToLower();
            if (repeatSelection == "n" || repeatSelection == "no")
            {
                return false;
            }
            else if (repeatSelection != "y" && repeatSelection != "yes")
            {
                Console.WriteLine("Invalid selection.");
                return CheckRepeat();
            }
            else return true;
        }

        static void DoubleToFeetInches(double feetAsDouble)
        {
            int feet = (int)Math.Floor(feetAsDouble);
            int inches = (int)(feetAsDouble - feet) * 12;
            Console.WriteLine(feet + "' " + inches + "\"");
        }
    }
}
