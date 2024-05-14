using System;
using System.Windows.Forms;

namespace ProjektForms
{
    public partial class Form1 : Form
    {
        private double udgifter = 0; // Variable to store expenses
        private Fradrag fradrag = new Fradrag();

        public Form1()
        {
            InitializeComponent();

            // Wire up event handlers to buttons
            this.Submit.Click += new EventHandler(Submit_Click);
            this.SubmitM�ned.Click += new EventHandler(SubmitM�ned_Click);
            this.button1.Click += new EventHandler(button1_Click);
            this.SubmitM�ned2.Click += new EventHandler(SubmitM�ned2_Click);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the value from textBoxPenge and add it to udgifter
                double inputValue = GetTextBoxValues.GetTextBoxValue(textBoxPenge);
                udgifter += inputValue;

                // Calculate the remaining amount (M�nedsl�n - Udgifter)
                double remainingAmount = double.Parse(textBoxM�ned.Text) - udgifter;

                // Update the output textBox with the remaining amount rounded to 2 decimals
                textBoxOutput.Text = remainingAmount.ToString("0.00");
            }
            catch (ArgumentException ex)
            {
                // Handle invalid input
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubmitM�ned_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the M�nedsl�n value
                double m�nedsl�n = GetTextBoxValues.GetTextBoxValue(textBoxM�ned);

                // Calculate the remaining amount (M�nedsl�n - Udgifter)
                double remainingAmount = m�nedsl�n - udgifter;

                // Update the output textBox with the remaining amount rounded to 2 decimals
                textBoxOutput.Text = remainingAmount.ToString("0.00");
            }
            catch (ArgumentException ex)
            {
                // Handle invalid input
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubmitM�ned2_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the M�nedsl�n value before tax
                double m�nedsl�nBeforeTax = GetTextBoxValues.GetTextBoxValue(textBoxM�ned2);

                // Get the extra deductions
                double extraDeductions = GetTextBoxValues.GetTextBoxValue(textBoxFradrag);

                // Calculate the tax
                double tax = fradrag.CalculateTax(m�nedsl�nBeforeTax, extraDeductions);

                // Update the output textBox with the tax amount rounded to 2 decimals
                textBoxOutput2.Text = tax.ToString("0.00");
            }
            catch (ArgumentException ex)
            {
                // Handle invalid input
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the udgifter and output textBoxes
            udgifter = 0;
            textBoxOutput.Text = "";
        }
    }
}
