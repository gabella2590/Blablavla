namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Addition = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.POW = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.PowXY = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(52, 157);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(45, 58);
            this.Addition.TabIndex = 0;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Calculate);
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(103, 157);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(42, 58);
            this.Substraction.TabIndex = 1;
            this.Substraction.Text = "-";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.Calculate);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(151, 157);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(53, 58);
            this.Multiply.TabIndex = 2;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Calculate);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(210, 157);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(39, 58);
            this.Division.TabIndex = 3;
            this.Division.Text = "\\";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Calculate);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(303, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(572, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Первая переменная";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Вторая переменная";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат";
            // 
            // POW
            // 
            this.POW.Location = new System.Drawing.Point(572, 99);
            this.POW.Name = "POW";
            this.POW.Size = new System.Drawing.Size(185, 52);
            this.POW.TabIndex = 10;
            this.POW.Text = "X^2";
            this.POW.UseVisualStyleBackColor = true;
            this.POW.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(303, 99);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(115, 52);
            this.Sin.TabIndex = 11;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(424, 99);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(107, 52);
            this.Cos.TabIndex = 12;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // PowXY
            // 
            this.PowXY.Location = new System.Drawing.Point(576, 166);
            this.PowXY.Name = "PowXY";
            this.PowXY.Size = new System.Drawing.Size(180, 48);
            this.PowXY.TabIndex = 13;
            this.PowXY.Text = "x^y";
            this.PowXY.UseVisualStyleBackColor = true;
            this.PowXY.Click += new System.EventHandler(this.Calculate);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(305, 163);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(112, 51);
            this.Tan.TabIndex = 14;
            this.Tan.Text = "Tg";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ctg";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(821, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.PowXY);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.POW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Substraction);
            this.Controls.Add(this.Addition);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Substraction;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button POW;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button PowXY;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button button1;
    }
}

