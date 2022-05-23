
namespace ComplexNumbersCalculator
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textX1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textY1 = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Button();
            this.ConvToPolar = new System.Windows.Forms.Button();
            this.Expon = new System.Windows.Forms.Button();
            this.Rooting = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textX2 = new System.Windows.Forms.TextBox();
            this.textY2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Z1 = ";
            // 
            // textX1
            // 
            this.textX1.Location = new System.Drawing.Point(53, 8);
            this.textX1.Name = "textX1";
            this.textX1.Size = new System.Drawing.Size(100, 22);
            this.textX1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "+ i *";
            // 
            // textY1
            // 
            this.textY1.Location = new System.Drawing.Point(197, 8);
            this.textY1.Name = "textY1";
            this.textY1.Size = new System.Drawing.Size(100, 22);
            this.textY1.TabIndex = 4;
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(9, 109);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(138, 63);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(159, 109);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(138, 63);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(9, 187);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(138, 63);
            this.Mult.TabIndex = 2;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(159, 187);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(138, 63);
            this.Division.TabIndex = 3;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(15, 98);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(138, 63);
            this.Module.TabIndex = 4;
            this.Module.Text = "|Z|";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.Module_Click);
            // 
            // ConvToPolar
            // 
            this.ConvToPolar.Location = new System.Drawing.Point(159, 98);
            this.ConvToPolar.Name = "ConvToPolar";
            this.ConvToPolar.Size = new System.Drawing.Size(138, 63);
            this.ConvToPolar.TabIndex = 5;
            this.ConvToPolar.Text = "polar";
            this.ConvToPolar.UseVisualStyleBackColor = true;
            this.ConvToPolar.Click += new System.EventHandler(this.ConvToPolar_Click);
            // 
            // Expon
            // 
            this.Expon.Location = new System.Drawing.Point(15, 177);
            this.Expon.Name = "Expon";
            this.Expon.Size = new System.Drawing.Size(138, 63);
            this.Expon.TabIndex = 6;
            this.Expon.Text = "Z^n";
            this.Expon.UseVisualStyleBackColor = true;
            this.Expon.Click += new System.EventHandler(this.Expon_Click);
            // 
            // Rooting
            // 
            this.Rooting.Location = new System.Drawing.Point(159, 177);
            this.Rooting.Name = "Rooting";
            this.Rooting.Size = new System.Drawing.Size(138, 63);
            this.Rooting.TabIndex = 7;
            this.Rooting.Text = "Z^(1/n)";
            this.Rooting.UseVisualStyleBackColor = true;
            this.Rooting.Click += new System.EventHandler(this.Rooting_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(359, 42);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Result.Size = new System.Drawing.Size(354, 282);
            this.Result.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(323, 302);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textY1);
            this.tabPage1.Controls.Add(this.textX2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textX1);
            this.tabPage1.Controls.Add(this.Division);
            this.tabPage1.Controls.Add(this.Mult);
            this.tabPage1.Controls.Add(this.textY2);
            this.tabPage1.Controls.Add(this.Minus);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Plus);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(315, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Бинарные операции";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z2 = ";
            // 
            // textX2
            // 
            this.textX2.Location = new System.Drawing.Point(53, 57);
            this.textX2.Name = "textX2";
            this.textX2.Size = new System.Drawing.Size(100, 22);
            this.textX2.TabIndex = 6;
            // 
            // textY2
            // 
            this.textY2.Location = new System.Drawing.Point(197, 57);
            this.textY2.Name = "textY2";
            this.textY2.Size = new System.Drawing.Size(100, 22);
            this.textY2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "+ i *";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textN);
            this.tabPage2.Controls.Add(this.Rooting);
            this.tabPage2.Controls.Add(this.Expon);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.ConvToPolar);
            this.tabPage2.Controls.Add(this.textY);
            this.tabPage2.Controls.Add(this.Module);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textX);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(315, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Унарные операции";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(53, 46);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(100, 22);
            this.textN.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "n = ";
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(197, 13);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(100, 22);
            this.textY.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "+ i *";
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(53, 13);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(100, 22);
            this.textX.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Z = ";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 341);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Result);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textY1;
        private System.Windows.Forms.Button Rooting;
        private System.Windows.Forms.Button Expon;
        private System.Windows.Forms.Button ConvToPolar;
        private System.Windows.Forms.Button Module;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textX2;
        private System.Windows.Forms.TextBox textY2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.Label label8;
    }
}

