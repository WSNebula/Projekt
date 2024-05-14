using System;
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

    public class Fradrag
    {
        public double Amount { get; set; }

        public double CalculateTax(double månedslønBeforeTax, double extraDeductions)
        {
            // Tax rates and thresholds
            const double arbejdsmarkedsbidragRate = 0.08;
            const double kommuneRate = 0.251;
            const double bundskatRate = 0.125; // Corrected rate for the bottom tax
            const double personFradragYearly = 49700; // Yearly standard deduction
            const double topskatRate = 0.15;
            const double topskatThreshold = 640109;

            // Convert yearly standard deduction to monthly
            double personFradragMonthly = personFradragYearly / 12;

            // Apply deductions
            double taxableIncome = Math.Max(0, månedslønBeforeTax - personFradragMonthly - extraDeductions);

            // Calculate tax
            double tax = 0;

            // Calculate labor market contribution
            double arbejdsmarkedsbidrag = taxableIncome * arbejdsmarkedsbidragRate;

            // Calculate municipal tax
            double kommuneskat = taxableIncome * kommuneRate;

            // Calculate bottom tax (bundskat)
            double bundskat = taxableIncome * bundskatRate; // Corrected calculation for the bottom tax

            // Calculate top tax if applicable
            double remainingIncomeForTopTax = taxableIncome - topskatThreshold;
            double topskat = remainingIncomeForTopTax > 0 ? remainingIncomeForTopTax * topskatRate : 0;

            // Sum up the taxes
            tax = arbejdsmarkedsbidrag + kommuneskat + bundskat + topskat;

            return tax;
        }


    }

    public static class GetTextBoxValues
    {
        public static double GetTextBoxValue(TextBox textBox)
        {
            if (double.TryParse(textBox.Text, out double value))
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
