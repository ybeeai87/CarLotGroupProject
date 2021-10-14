using System;
using System.Collections.Generic;
using System.Text;

namespace Validator
{
    class Validator
    {//general things to reuse :).
        public static double GetNumber()
        {
            double result = 0;

            while(true)
            {
                try
                {
                    result = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was not a number. Try again.");
                }
            }

            return result;
        }



        public static double GetNumber(double min, double max)
        {
            double result;
            while (true)
            {
                result = GetNumber();
                if (result < min || result > max)
                {
                    Console.WriteLine($"That was outside of the valid range. Please try again entering a number within {min} and {max}");
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public static bool GetContinue()
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine("Would you like to keep running the program? y/n?");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
              
                else
                {
                    Console.WriteLine("That was not a valid choice.");
                }
            }
            return result;
        }

        public static bool GetContinue(string prompt)
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine($"{prompt} y/n");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y" || choice == "yes")
                    
                {
                    result = true;
                    break;
                }
                else if (choice == "n" || choice == "no")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid choice.");
                }
            }
            return result;
        }
        public static int GetRandom(int x)
        {
            Random rando = new Random();
            return rando.Next(1, x);
        }

        public static bool IsAbove(int value, int min)
        {
            if (value > min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsAboveOrEqual(int value, int min)
        {
            if (value >= min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsEqual(int x, int y)
        {
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
