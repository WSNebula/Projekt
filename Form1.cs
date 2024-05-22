using System;
using System.Windows.Forms;

namespace ProjektForms
{
    public partial class Form1 : Form
    {
        private ExpenseManager expenseManager = new ExpenseManager();
        private SalaryManager salaryManager = new SalaryManager();

        public Form1()
        {
            InitializeComponent();

            // Wire up event handlers to buttons
            this.Submit.Click += new EventHandler(Submit_Click);
            this.SubmitMåned.Click += new EventHandler(SubmitMåned_Click);
            this.button1.Click += new EventHandler(button1_Click);
            this.SubmitMåned2.Click += new EventHandler(SubmitMåned2_Click);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                double inputValue = GetTextBoxValues.GetTextBoxValue(textBoxPenge);
                expenseManager.AddExpense(inputValue);

                double remainingAmount = salaryManager.CalculateRemainingAmount(
                    GetTextBoxValues.GetTextBoxValue(textBoxMåned), expenseManager.TotalExpenses);

                textBoxOutput.Text = remainingAmount.ToString("0.00");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubmitMåned_Click(object sender, EventArgs e)
        {
            try
            {
                double remainingAmount = salaryManager.CalculateRemainingAmount(
                    GetTextBoxValues.GetTextBoxValue(textBoxMåned), expenseManager.TotalExpenses);

                textBoxOutput.Text = remainingAmount.ToString("0.00");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubmitMåned2_Click(object sender, EventArgs e)
        {
            try
            {
                double månedslønBeforeTax = GetTextBoxValues.GetTextBoxValue(textBoxMåned2);
                double extraDeductions = GetTextBoxValues.GetTextBoxValue(textBoxFradrag);

                double tax = salaryManager.CalculateTax(månedslønBeforeTax, extraDeductions);
                textBoxOutput2.Text = tax.ToString("0.00");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expenseManager.ClearExpenses();
            textBoxOutput.Text = string.Empty;
        }
    }
}
