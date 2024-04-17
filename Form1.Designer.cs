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
            button1 = new Button();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(779, 184);
            button1.Name = "button1";
            button1.Size = new Size(140, 41);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(779, 159);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(88, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Tilføj penge";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(779, 134);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(87, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Fjern udgift";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(779, 109);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(95, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Ændre udgift";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(779, 84);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(87, 19);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Tilføj udgift";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(779, 59);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(122, 19);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "Ændre månedsløn";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(779, 34);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(114, 19);
            checkBox7.TabIndex = 7;
            checkBox7.Text = "Tilføj månedsløn";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(779, 16);
            label1.Name = "label1";
            label1.Size = new Size(217, 15);
            label1.TabIndex = 8;
            label1.Text = "Check box for at vælge hvad du vil gøre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 73);
            label2.Name = "label2";
            label2.Size = new Size(241, 15);
            label2.TabIndex = 11;
            label2.Text = "Navn på udgift (udfyld ikke hvis månedsløn)";
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
            label4.Location = new Point(186, 158);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 13;
            label4.Text = "Penge tilbage (output)";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(80, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 639);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
    }
}