using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjektForms
{
    public class Udgift
    {
        public double Currency { get; set; }
    }

    public class Månedsløn
    {
        public double Salary { get; set; }
    }

    public static class UtilityFunctions
    {
        public static double GetTextBoxValue(TextBox textBoxPenge)
        {
            if (double.TryParse(textBoxPenge.Text, out double value))
            {
                return value;
            }
            else
            {
                // Handle invalid input
                throw new ArgumentException("Invalid input");
            }
        }
    }
}
