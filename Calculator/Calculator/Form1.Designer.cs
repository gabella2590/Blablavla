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
            this.Asin = new System.Windows.Forms.Button();
            this.Acos = new System.Windows.Forms.Button();
            this.Powex = new System.Windows.Forms.Button();
            this.Lnx = new System.Windows.Forms.Button();
            this.Logxy = new System.Windows.Forms.Button();
            this.Xpow1y = new System.Windows.Forms.Button();
            this.Ctanx = new System.Windows.Forms.Button();
            this.Atanx = new System.Windows.Forms.Button();
            this.Log2x = new System.Windows.Forms.Button();
            this.Log10x = new System.Windows.Forms.Button();
            this.Pow2x = new System.Windows.Forms.Button();
            this.Pow10x = new System.Windows.Forms.Button();
            this.MidMath = new System.Windows.Forms.Button();
            this.Minusx = new System.Windows.Forms.Button();
            this.Div1x = new System.Windows.Forms.Button();
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
            this.PowXY.Location = new System.Drawing.Point(572, 157);
            this.PowXY.Name = "PowXY";
            this.PowXY.Size = new System.Drawing.Size(185, 48);
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
            // Asin
            // 
            this.Asin.Location = new System.Drawing.Point(424, 163);
            this.Asin.Name = "Asin";
            this.Asin.Size = new System.Drawing.Size(106, 51);
            this.Asin.TabIndex = 15;
            this.Asin.Text = "Asin";
            this.Asin.UseVisualStyleBackColor = true;
            this.Asin.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Acos
            // 
            this.Acos.Location = new System.Drawing.Point(429, 221);
            this.Acos.Name = "Acos";
            this.Acos.Size = new System.Drawing.Size(102, 60);
            this.Acos.TabIndex = 16;
            this.Acos.Text = "Acos";
            this.Acos.UseVisualStyleBackColor = true;
            this.Acos.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Powex
            // 
            this.Powex.Location = new System.Drawing.Point(305, 220);
            this.Powex.Name = "Powex";
            this.Powex.Size = new System.Drawing.Size(112, 60);
            this.Powex.TabIndex = 17;
            this.Powex.Text = "e^x";
            this.Powex.UseVisualStyleBackColor = true;
            this.Powex.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Lnx
            // 
            this.Lnx.Location = new System.Drawing.Point(305, 288);
            this.Lnx.Name = "Lnx";
            this.Lnx.Size = new System.Drawing.Size(111, 45);
            this.Lnx.TabIndex = 18;
            this.Lnx.Text = "Ln(x)";
            this.Lnx.UseVisualStyleBackColor = true;
            this.Lnx.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Logxy
            // 
            this.Logxy.Location = new System.Drawing.Point(429, 288);
            this.Logxy.Name = "Logxy";
            this.Logxy.Size = new System.Drawing.Size(101, 44);
            this.Logxy.TabIndex = 19;
            this.Logxy.Text = "Logx(y)";
            this.Logxy.UseVisualStyleBackColor = true;
            this.Logxy.Click += new System.EventHandler(this.Calculate);
            // 
            // Xpow1y
            // 
            this.Xpow1y.Location = new System.Drawing.Point(305, 339);
            this.Xpow1y.Name = "Xpow1y";
            this.Xpow1y.Size = new System.Drawing.Size(113, 47);
            this.Xpow1y.TabIndex = 20;
            this.Xpow1y.Text = "X^(1/y)";
            this.Xpow1y.UseVisualStyleBackColor = true;
            this.Xpow1y.Click += new System.EventHandler(this.Calculate);
            // 
            // Ctanx
            // 
            this.Ctanx.Location = new System.Drawing.Point(429, 338);
            this.Ctanx.Name = "Ctanx";
            this.Ctanx.Size = new System.Drawing.Size(102, 48);
            this.Ctanx.TabIndex = 21;
            this.Ctanx.Text = "ctan(x)";
            this.Ctanx.UseVisualStyleBackColor = true;
            this.Ctanx.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Atanx
            // 
            this.Atanx.Location = new System.Drawing.Point(572, 211);
            this.Atanx.Name = "Atanx";
            this.Atanx.Size = new System.Drawing.Size(185, 48);
            this.Atanx.TabIndex = 22;
            this.Atanx.Text = "Atan(x)";
            this.Atanx.UseVisualStyleBackColor = true;
            this.Atanx.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Log2x
            // 
            this.Log2x.Location = new System.Drawing.Point(572, 265);
            this.Log2x.Name = "Log2x";
            this.Log2x.Size = new System.Drawing.Size(185, 45);
            this.Log2x.TabIndex = 23;
            this.Log2x.Text = "Log2(x)";
            this.Log2x.UseVisualStyleBackColor = true;
            this.Log2x.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Log10x
            // 
            this.Log10x.Location = new System.Drawing.Point(572, 316);
            this.Log10x.Name = "Log10x";
            this.Log10x.Size = new System.Drawing.Size(185, 42);
            this.Log10x.TabIndex = 24;
            this.Log10x.Text = "Log10(x)";
            this.Log10x.UseVisualStyleBackColor = true;
            this.Log10x.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Pow2x
            // 
            this.Pow2x.Location = new System.Drawing.Point(572, 362);
            this.Pow2x.Name = "Pow2x";
            this.Pow2x.Size = new System.Drawing.Size(185, 47);
            this.Pow2x.TabIndex = 25;
            this.Pow2x.Text = "2^x";
            this.Pow2x.UseVisualStyleBackColor = true;
            this.Pow2x.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Pow10x
            // 
            this.Pow10x.Location = new System.Drawing.Point(303, 392);
            this.Pow10x.Name = "Pow10x";
            this.Pow10x.Size = new System.Drawing.Size(115, 48);
            this.Pow10x.TabIndex = 26;
            this.Pow10x.Text = "10^x";
            this.Pow10x.UseVisualStyleBackColor = true;
            this.Pow10x.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // MidMath
            // 
            this.MidMath.Location = new System.Drawing.Point(429, 392);
            this.MidMath.Name = "MidMath";
            this.MidMath.Size = new System.Drawing.Size(101, 48);
            this.MidMath.TabIndex = 27;
            this.MidMath.Text = "Сред Арифм";
            this.MidMath.UseVisualStyleBackColor = true;
            this.MidMath.Click += new System.EventHandler(this.Calculate);
            // 
            // Minusx
            // 
            this.Minusx.Location = new System.Drawing.Point(151, 227);
            this.Minusx.Name = "Minusx";
            this.Minusx.Size = new System.Drawing.Size(99, 32);
            this.Minusx.TabIndex = 28;
            this.Minusx.Text = "-x";
            this.Minusx.UseVisualStyleBackColor = true;
            this.Minusx.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Div1x
            // 
            this.Div1x.Location = new System.Drawing.Point(52, 227);
            this.Div1x.Name = "Div1x";
            this.Div1x.Size = new System.Drawing.Size(93, 32);
            this.Div1x.TabIndex = 29;
            this.Div1x.Text = "1/x";
            this.Div1x.UseVisualStyleBackColor = true;
            this.Div1x.Click += new System.EventHandler(this.OneArgCalc);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(821, 475);
            this.Controls.Add(this.Div1x);
            this.Controls.Add(this.Minusx);
            this.Controls.Add(this.MidMath);
            this.Controls.Add(this.Pow10x);
            this.Controls.Add(this.Pow2x);
            this.Controls.Add(this.Log10x);
            this.Controls.Add(this.Log2x);
            this.Controls.Add(this.Atanx);
            this.Controls.Add(this.Ctanx);
            this.Controls.Add(this.Xpow1y);
            this.Controls.Add(this.Logxy);
            this.Controls.Add(this.Lnx);
            this.Controls.Add(this.Powex);
            this.Controls.Add(this.Acos);
            this.Controls.Add(this.Asin);
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
        private System.Windows.Forms.Button Asin;
        private System.Windows.Forms.Button Acos;
        private System.Windows.Forms.Button Powex;
        private System.Windows.Forms.Button Lnx;
        private System.Windows.Forms.Button Logxy;
        private System.Windows.Forms.Button Xpow1y;
        private System.Windows.Forms.Button Ctanx;
        private System.Windows.Forms.Button Atanx;
        private System.Windows.Forms.Button Log2x;
        private System.Windows.Forms.Button Log10x;
        private System.Windows.Forms.Button Pow2x;
        private System.Windows.Forms.Button Pow10x;
        private System.Windows.Forms.Button MidMath;
        private System.Windows.Forms.Button Minusx;
        private System.Windows.Forms.Button Div1x;
    }
}

