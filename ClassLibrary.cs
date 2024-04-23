using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjektForms
{
    public class Udgift 
    { 
        public double Currency { get; set; }
        public double Name { get; set; }
    }
    public class Månedsløn
    {
        public double Sallery { get; set; }
    }

    public double GetTextBoxValue(TextBox textBoxMåned)
    {
        double value;
        if (double.TryParse(textBoxMåned.Text, out value))
        {
            return value;
        }
        else
        {
            // Handle invalid input
            throw new ArgumentException("Invalid input");
        }
    }

    public double GetTextBoxValue(TextBox textBoxPenge)
    {
        double value;
        if (double.TryParse(textBoxPenge.Text, out value))
        {
        return value;
        }
        else
        {
            // Handle invalid input
            throw new ArgumentException("Invalid input");
        }
    }

public string GetTextBoxValue(TextBox textBoxNavn)
{
    return textBoxNavn.Text;
}
}
