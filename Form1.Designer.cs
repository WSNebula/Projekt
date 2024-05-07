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
            textBoxPenge = new TextBox();
            label4 = new Label();
            textBoxOutput = new TextBox();
            textBoxMåned = new TextBox();
            SubmitMåned = new Button();
            button1 = new Button();
            label2 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // Submit
            // 
            Submit.Font = new Font("Arial Rounded MT Bold", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            Submit.Location = new Point(80, 106);
            Submit.Name = "Submit";
            Submit.Size = new Size(100, 26);
            Submit.TabIndex = 0;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            // 
            // textBoxPenge
            // 
            textBoxPenge.Font = new Font("Arial Rounded MT Bold", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPenge.Location = new Point(80, 63);
            textBoxPenge.Name = "textBoxPenge";
            textBoxPenge.Size = new Size(100, 21);
            textBoxPenge.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(186, 254);
            label4.Name = "label4";
            label4.Size = new Size(133, 14);
            label4.TabIndex = 13;
            label4.Text = "Penge tilbage |output|";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Font = new Font("Arial Rounded MT Bold", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOutput.Location = new Point(80, 251);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(100, 21);
            textBoxOutput.TabIndex = 14;
            // 
            // textBoxMåned
            // 
            textBoxMåned.Font = new Font("Arial Rounded MT Bold", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMåned.Location = new Point(365, 65);
            textBoxMåned.Name = "textBoxMåned";
            textBoxMåned.Size = new Size(100, 21);
            textBoxMåned.TabIndex = 15;
            // 
            // SubmitMåned
            // 
            SubmitMåned.Font = new Font("Arial Rounded MT Bold", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitMåned.Location = new Point(365, 106);
            SubmitMåned.Name = "SubmitMåned";
            SubmitMåned.Size = new Size(100, 26);
            SubmitMåned.TabIndex = 17;
            SubmitMåned.Text = "Submit";
            SubmitMåned.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(80, 197);
            button1.Name = "button1";
            button1.Size = new Size(75, 48);
            button1.TabIndex = 18;
            button1.Text = "Fjern Alle Udgifter";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(93, 45);
            label2.Name = "label2";
            label2.Size = new Size(68, 14);
            label2.TabIndex = 19;
            label2.Text = "Udgift i kr.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(365, 45);
            label5.Name = "label5";
            label5.Size = new Size(102, 14);
            label5.TabIndex = 20;
            label5.Text = "Antal penge i kr.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 120);
            ClientSize = new Size(1010, 639);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(SubmitMåned);
            Controls.Add(textBoxMåned);
            Controls.Add(textBoxOutput);
            Controls.Add(label4);
            Controls.Add(textBoxPenge);
            Controls.Add(Submit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Submit;
        private TextBox textBoxPenge;
        private Label label4;
        private TextBox textBoxOutput;
        private TextBox textBoxMåned;
        private Button SubmitMåned;
        private Button button1;
        private Label label2;
        private Label label5;
    }
}