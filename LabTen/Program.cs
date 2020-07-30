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
                try
                {
                    Console.WriteLine("Enter radius:");
                    var radius = double.Parse(Console.ReadLine());

                    var circle = new Circle(radius);
                    circles.Add(circle);

                    Console.WriteLine($"Area: {circle.CalculateFormattedArea()}");
                    Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
                    Console.WriteLine("Continue? (y/n)");
                }
                catch (Exception)
                {
                    Console.WriteLine("Looks like there was something wrong with your input. Would you like to try again? (y/n)");
                }

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine($"Goodbye! You've created {circles.Count} Circle Object(s).");
        }
    }
}
