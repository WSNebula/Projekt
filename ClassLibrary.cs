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
        private Fradrag fradrag = new Fradrag();

        public double CalculateRemainingAmount(double månedsløn, double totalExpenses)
        {
            return månedsløn - totalExpenses;
        }

        public double CalculateTax(double månedslønBeforeTax, double extraDeductions)
        {
            return fradrag.CalculateTax(månedslønBeforeTax, extraDeductions);
        }
    }

    public class Fradrag
    {
        private const double arbejdsmarkedsbidragRate = 0.08;
        private const double kommuneRate = 0.251;
        private const double bundskatRate = 0.125;
        private const double personFradragYearly = 49700;
        private const double topskatRate = 0.15;
        private const double topskatThreshold = 640109;

        public double CalculateTax(double månedslønBeforeTax, double extraDeductions)
        {
            double personFradragMonthly = personFradragYearly / 12;
            double taxableIncome = Math.Max(0, månedslønBeforeTax - personFradragMonthly - extraDeductions);

            double arbejdsmarkedsbidrag = taxableIncome * arbejdsmarkedsbidragRate;
            double kommuneskat = taxableIncome * kommuneRate;
            double bundskat = taxableIncome * bundskatRate;
            double remainingIncomeForTopTax = taxableIncome - topskatThreshold;
            double topskat = remainingIncomeForTopTax > 0 ? remainingIncomeForTopTax * topskatRate : 0;

            return arbejdsmarkedsbidrag + kommuneskat + bundskat + topskat;
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
