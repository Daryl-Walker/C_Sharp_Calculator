using System;

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
            this.outPutTxtBx = new System.Windows.Forms.RichTextBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.AllClear = new System.Windows.Forms.Button();
            this.deci = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outPutTxtBx
            // 
            this.outPutTxtBx.Font = new System.Drawing.Font("MS Gothic", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outPutTxtBx.Location = new System.Drawing.Point(38, 77);
            this.outPutTxtBx.Name = "outPutTxtBx";
            this.outPutTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.outPutTxtBx.Size = new System.Drawing.Size(434, 80);
            this.outPutTxtBx.TabIndex = 0;
            this.outPutTxtBx.Text = "0";
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.White;
            this.num1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(57, 443);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 72);
            this.num1.TabIndex = 1;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.button_click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.White;
            this.num2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(175, 443);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 72);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.button_click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.White;
            this.num3.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(287, 443);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 72);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.button_click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Red;
            this.add.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(397, 228);
            this.add.Name = "add";
            this.add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.add.Size = new System.Drawing.Size(75, 72);
            this.add.TabIndex = 4;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.operator_click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.White;
            this.num4.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(57, 335);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 72);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.button_click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.White;
            this.num5.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(175, 335);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 72);
            this.num5.TabIndex = 6;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.button_click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.White;
            this.num6.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(287, 335);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 72);
            this.num6.TabIndex = 7;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.button_click);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.Color.Red;
            this.subtract.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(397, 335);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(75, 72);
            this.subtract.TabIndex = 8;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.operator_click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.White;
            this.num7.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(57, 228);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 72);
            this.num7.TabIndex = 9;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.button_click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.White;
            this.num8.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(175, 228);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 72);
            this.num8.TabIndex = 10;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.button_click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.White;
            this.num9.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(287, 228);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 72);
            this.num9.TabIndex = 11;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.button_click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.Red;
            this.multiply.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(397, 443);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 72);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.operator_click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.White;
            this.num0.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(57, 546);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(75, 72);
            this.num0.TabIndex = 13;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.button_click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.White;
            this.equals.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(57, 646);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(193, 72);
            this.equals.TabIndex = 14;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.Red;
            this.divide.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(397, 546);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 72);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.operator_click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Clear.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(287, 646);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 72);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "CE";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.backspace_click);
            // 
            // AllClear
            // 
            this.AllClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AllClear.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllClear.Location = new System.Drawing.Point(397, 646);
            this.AllClear.Name = "AllClear";
            this.AllClear.Size = new System.Drawing.Size(75, 72);
            this.AllClear.TabIndex = 17;
            this.AllClear.Text = "AC";
            this.AllClear.UseVisualStyleBackColor = false;
            this.AllClear.Click += new System.EventHandler(this.AllClear_Click);
            // 
            // deci
            // 
            this.deci.BackColor = System.Drawing.Color.White;
            this.deci.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deci.Location = new System.Drawing.Point(175, 546);
            this.deci.Name = "deci";
            this.deci.Size = new System.Drawing.Size(75, 72);
            this.deci.TabIndex = 18;
            this.deci.Text = ".";
            this.deci.UseVisualStyleBackColor = false;
            this.deci.Click += new System.EventHandler(this.button_click);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.Color.Red;
            this.percent.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(287, 546);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(75, 72);
            this.percent.TabIndex = 19;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.operator_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(523, 743);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.deci);
            this.Controls.Add(this.AllClear);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.add);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.outPutTxtBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.RichTextBox outPutTxtBx;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button AllClear;
        private System.Windows.Forms.Button deci;
        private System.Windows.Forms.Button percent;
    }
}

