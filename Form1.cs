using System;
using System.Windows.Forms;

namespace ProjektForms
{
    public partial class Form1 : Form
    {
        private double udgifter = 0; // Variable to store expenses

        public Form1()
        {
            InitializeComponent();

            // Wire up event handlers to buttons
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            this.SubmitMåned.Click += new System.EventHandler(this.SubmitMåned_Click);
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the value from textBoxPenge and add it to udgifter
                double inputValue = UtilityFunctions.GetTextBoxValue(textBoxPenge);
                udgifter += inputValue;

                // Calculate the remaining amount (Månedsløn - Udgifter)
                double remainingAmount = double.Parse(textBoxMåned.Text) - udgifter;

                // Update the output textBox with the remaining amount rounded to 2 decimals
                textBoxOutput.Text = remainingAmount.ToString("0.00");
            }
            catch (ArgumentException ex)
            {
                // Handle invalid input
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubmitMåned_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the Månedsløn value
                double månedsløn = UtilityFunctions.GetTextBoxValue(textBoxMåned);

                // Calculate the remaining amount (Månedsløn - Udgifter)
                double remainingAmount = månedsløn - udgifter;

                // Update the output textBox with the remaining amount rounded to 2 decimals
                textBoxOutput.Text = remainingAmount.ToString("0.00");
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
