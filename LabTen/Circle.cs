﻿using System;
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
            return 2 * Math.PI * Radius;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            //Area = (pi)r^2
            return (Math.PI) * Math.Pow(Radius, 2);            
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
    }
}
