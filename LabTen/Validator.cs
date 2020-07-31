using System;
using System.Collections.Generic;
using System.Text;

namespace LabTen
{
    public class Validator
    {
        public string Input { get; set; }

        public Validator(string input)
        {
            Input = input;
        }

        public bool CheckIfDouble()
        {
            return Double.TryParse(Input, out var radius);
        }

        public double ConvertToDouble()
        {
            return Convert.ToDouble(Input);
        }
    }
}