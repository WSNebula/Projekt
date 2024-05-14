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
            const double kommuneKirkeskatRate = 0.251;
            const double bundskatRate1 = 0.08; // Rate for the first bracket
            const double bundskatRate2 = 0.195; // Rate for the second bracket
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

            // Calculate municipal and church tax (bundskat)
            double bundskat = 0;
            if (taxableIncome <= 55200)
            {
                bundskat = taxableIncome * bundskatRate1;
            }
            else if (taxableIncome <= 583600)
            {
                double firstBracketTax = 55200 * bundskatRate1;
                double remainingIncome = taxableIncome - 55200;
                bundskat = firstBracketTax + (remainingIncome * bundskatRate2);
            }
            else
            {
                double firstBracketTax = 55200 * bundskatRate1;
                double secondBracketTax = (583600 - 55200) * bundskatRate2;
                double remainingIncome = taxableIncome - 583600;
                bundskat = firstBracketTax + secondBracketTax + (remainingIncome * kommuneKirkeskatRate);
            }

            // Calculate top tax if applicable
            double remainingIncomeForTopTax = taxableIncome - topskatThreshold;
            double topskat = remainingIncomeForTopTax > 0 ? remainingIncomeForTopTax * topskatRate : 0;

            // Sum up the taxes
            tax = arbejdsmarkedsbidrag + bundskat + topskat;

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
