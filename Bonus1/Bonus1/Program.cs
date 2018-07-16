using System;

namespace Bonus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter!");

            bool repeat = true;
            int numGrade;
            String letterGrade;

            while (repeat)
            {
                Console.Write("\nEnter a numerical grade: ");
                numGrade = int.Parse(Console.ReadLine());
                letterGrade = GradeParse(numGrade);
                Console.WriteLine(letterGrade);
                repeat = RepeatCheck();
            }
            Console.WriteLine("Goodbye!");
            Console.Read();
        }

        static String GradeParse(int numGrade)
        {
            if (numGrade >= 98) { return "A+"; }
            else if (numGrade >= 92) { return "A"; }
            else if (numGrade >= 88) { return "A-"; }
            else if (numGrade >= 85) { return "B+"; }
            else if (numGrade >= 83) { return "B"; }
            else if (numGrade >= 80) { return "B-"; }
            else if (numGrade >= 75) { return "C+"; }
            else if (numGrade >= 70) { return "C"; }
            else if (numGrade >= 67) { return "C-"; }
            else if (numGrade >= 64) { return "D+"; }
            else if (numGrade >= 62) { return "D"; }
            else if (numGrade >= 60) { return "D-"; }
            else return "F";
        }

        static bool RepeatCheck()
        {
            String repeatSelection;

            Console.Write("\nContinue? (y/n): ");
            try
            {
                repeatSelection = Console.ReadLine().ToLower();
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
                Console.WriteLine("Invalid selection.");
                return RepeatCheck();
            }
        }
    }
}
