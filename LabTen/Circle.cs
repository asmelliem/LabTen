using System;
using System.Collections.Generic;
using System.Text;

namespace LabTen
{
    public class Circle
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
                
        }

        public double CalculateCircumference()
        {
            //C = 2(pi)r
            var circumference = 2 * Math.PI * Radius;
            return circumference;

        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            //Area = (pi)r^2
            var area = (Math.PI) * Math.Pow(Radius, 2);
            return area;

        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        private string FormatNumber(double x)
        {
            var formattedNumber = Math.Round((Double)x, 2);
            return formattedNumber.ToString();
        }
    }
}
