namespace ProjektForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Submit = new Button();
            textBoxNavn = new TextBox();
            textBoxPenge = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxOutput = new TextBox();
            textBoxMåned = new TextBox();
            label1 = new Label();
            SubmitMåned = new Button();
            SuspendLayout();
            // 
            // Submit
            // 
            Submit.Location = new Point(80, 152);
            Submit.Name = "Submit";
            Submit.Size = new Size(100, 26);
            Submit.TabIndex = 0;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            // 
            // textBoxNavn
            // 
            textBoxNavn.Location = new Point(80, 65);
            textBoxNavn.Name = "textBoxNavn";
            textBoxNavn.Size = new Size(100, 23);
            textBoxNavn.TabIndex = 9;
            // 
            // textBoxPenge
            // 
            textBoxPenge.Location = new Point(80, 109);
            textBoxPenge.Name = "textBoxPenge";
            textBoxPenge.Size = new Size(100, 23);
            textBoxPenge.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 68);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 11;
            label2.Text = "Navn på udgift";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 113);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 12;
            label3.Text = "Antal penge";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 254);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 13;
            label4.Text = "Penge tilbage (output)";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(80, 251);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(100, 23);
            textBoxOutput.TabIndex = 14;
            // 
            // textBoxMåned
            // 
            textBoxMåned.Location = new Point(365, 65);
            textBoxMåned.Name = "textBoxMåned";
            textBoxMåned.Size = new Size(100, 23);
            textBoxMåned.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(471, 68);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 16;
            label1.Text = "Månedsløn";
            // 
            // SubmitMåned
            // 
            SubmitMåned.Location = new Point(365, 106);
            SubmitMåned.Name = "SubmitMåned";
            SubmitMåned.Size = new Size(100, 26);
            SubmitMåned.TabIndex = 17;
            SubmitMåned.Text = "Submit";
            SubmitMåned.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 639);
            Controls.Add(SubmitMåned);
            Controls.Add(label1);
            Controls.Add(textBoxMåned);
            Controls.Add(textBoxOutput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPenge);
            Controls.Add(textBoxNavn);
            Controls.Add(Submit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Submit;
        private TextBox textBoxNavn;
        private TextBox textBoxPenge;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxOutput;
        private TextBox textBoxMåned;
        private Label label1;
        private Button SubmitMåned;
    }
}