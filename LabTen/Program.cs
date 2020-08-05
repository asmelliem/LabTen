using System;
using System.Collections.Generic;

namespace LabTen
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Circle Tester!");
            List<Circle> circles = new List<Circle>();

            do
            {
                Console.WriteLine("Enter radius:");

                var input = Console.ReadLine();

                if (Validator.CheckIfDouble(input, out var radius) && Validator.CheckIfPositive(radius))
                {
                    var circle = new Circle(radius);
                    circles.Add(circle);

                    Console.WriteLine($"Area: {circle.CalculateFormattedArea()}");
                    Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
                }               
                else
                {
                    Console.WriteLine("Whoops, looks like there was something wrong with your input.");
                }
            } while (ContinueProgram());

            Console.WriteLine($"Goodbye! You've created {circles.Count} Circle Object(s).");
        }

        public static bool ContinueProgram()
        {           
            while (true)
            {
                Console.WriteLine("Would you like to continue? (y/n)");
                var input = Console.ReadLine().ToUpper();

                if (input == "Y")
                {
                    return true;
                }
                else if (input == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("You didn't enter a 'Y' or 'N'");                    
                }
            };
            
        }
    }
}