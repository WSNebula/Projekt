using System;
using System.Windows.Forms;

namespace ProjektForms
{
    public class ExpenseManager
    {
        public double TotalExpenses { get; private set; }

        public void AddExpense(double amount)
        {
            TotalExpenses += amount;
        }

        public void ClearExpenses()
        {
            TotalExpenses = 0;
        }
    }
    public class SalaryManager
    {
        // Definerer konstanter for skattesatser, fradrag og skattetærskler
        private const double arbejdsmarkedsbidragRate = 0.08;  // Skattesats for arbejdsmarkedsbidrag
        private const double kommuneRate = 0.251;             // Skattesats for kommuneskat
        private const double bundskatRate = 0.125;            // Skattesats for bundskat
        private const double personFradragYearly = 49700;     // Årligt personligt fradrag
        private const double topskatRate = 0.15;              // Skattesats for topskat
        private const double topskatThreshold = 640109;       // Skattetærskel for topskat

        // Metode til at beregne det resterende beløb efter fradrag af samlede udgifter fra den månedlige løn
        public double CalculateRemainingAmount(double månedsløn, double totalExpenses)
        {
            return månedsløn - totalExpenses;
        }

        // Metode til at beregne skattebeløbet baseret på forskellige skattesatser og tærskler
        public double CalculateTax(double månedslønBeforeTax, double extraDeductions)
        {
            double personFradragMonthly = personFradragYearly / 12;

            double taxableIncome = Math.Max(0, månedslønBeforeTax - personFradragMonthly - extraDeductions);

            double arbejdsmarkedsbidrag = taxableIncome * arbejdsmarkedsbidragRate;
            double kommuneskat = taxableIncome * kommuneRate;
            double bundskat = taxableIncome * bundskatRate;

            double remainingIncomeForTopTax = taxableIncome - topskatThreshold;

            double topskat = remainingIncomeForTopTax > 0 ? remainingIncomeForTopTax * topskatRate : 0;

            // Samlet skattebeløb
            double totalTax = arbejdsmarkedsbidrag + kommuneskat + bundskat + topskat;

            return totalTax;
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
                throw new ArgumentException("Invalid input. Please enter a valid number.");
            }
        }
    }
}
