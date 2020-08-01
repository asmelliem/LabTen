using System;
using System.Collections.Generic;
using System.Text;

namespace LabTen
{
    public static class Validator
    {       
        public static bool CheckIfDouble(string input, out double radius)
        {
            return Double.TryParse(input, out radius);
        }
    }
}