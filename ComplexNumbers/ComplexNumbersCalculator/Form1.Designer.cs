
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textX2 = new System.Windows.Forms.TextBox();
            this.textY2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonDekart = new System.Windows.Forms.RadioButton();
            this.radioButtonPolar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roundButton1 = new ComplexNumbersCalculator.RoundButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Z1 =  ";
            // 
            // textX1
            // 
            this.textX1.Location = new System.Drawing.Point(40, 6);
            this.textX1.Margin = new System.Windows.Forms.Padding(2);
            this.textX1.Name = "textX1";
            this.textX1.Size = new System.Drawing.Size(76, 20);
            this.textX1.TabIndex = 1;
            this.textX1.TextChanged += new System.EventHandler(this.textX1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "  + i * ";
            // 
            // textY1
            // 
            this.textY1.Location = new System.Drawing.Point(147, 6);
            this.textY1.Margin = new System.Windows.Forms.Padding(2);
            this.textY1.Name = "textY1";
            this.textY1.Size = new System.Drawing.Size(76, 20);
            this.textY1.TabIndex = 4;
            this.textY1.TextChanged += new System.EventHandler(this.textY1_TextChanged);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.SystemColors.WindowText;
            this.Plus.FlatAppearance.BorderSize = 0;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Plus.Location = new System.Drawing.Point(7, 89);
            this.Plus.Margin = new System.Windows.Forms.Padding(0);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(104, 51);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.Black;
            this.Minus.FlatAppearance.BorderSize = 0;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Minus.Location = new System.Drawing.Point(119, 89);
            this.Minus.Margin = new System.Windows.Forms.Padding(0);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(104, 51);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Mult
            // 
            this.Mult.BackColor = System.Drawing.Color.Black;
            this.Mult.FlatAppearance.BorderSize = 0;
            this.Mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mult.Location = new System.Drawing.Point(7, 152);
            this.Mult.Margin = new System.Windows.Forms.Padding(0);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(104, 51);
            this.Mult.TabIndex = 2;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = false;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.Black;
            this.Division.FlatAppearance.BorderSize = 0;
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Division.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Division.Location = new System.Drawing.Point(119, 152);
            this.Division.Margin = new System.Windows.Forms.Padding(0);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(104, 51);
            this.Division.TabIndex = 3;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Module
            // 
            this.Module.BackColor = System.Drawing.Color.Black;
            this.Module.FlatAppearance.BorderSize = 0;
            this.Module.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Module.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Module.Location = new System.Drawing.Point(12, 149);
            this.Module.Margin = new System.Windows.Forms.Padding(2);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(104, 51);
            this.Module.TabIndex = 4;
            this.Module.Text = "|Z|";
            this.Module.UseVisualStyleBackColor = false;
            this.Module.Click += new System.EventHandler(this.Module_Click);
            // 
            // ConvToPolar
            // 
            this.ConvToPolar.BackColor = System.Drawing.Color.Black;
            this.ConvToPolar.FlatAppearance.BorderSize = 0;
            this.ConvToPolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvToPolar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConvToPolar.Location = new System.Drawing.Point(120, 149);
            this.ConvToPolar.Margin = new System.Windows.Forms.Padding(2);
            this.ConvToPolar.Name = "ConvToPolar";
            this.ConvToPolar.Size = new System.Drawing.Size(104, 51);
            this.ConvToPolar.TabIndex = 5;
            this.ConvToPolar.Text = "polar";
            this.ConvToPolar.UseVisualStyleBackColor = false;
            this.ConvToPolar.Click += new System.EventHandler(this.ConvToPolar_Click);
            // 
            // Expon
            // 
            this.Expon.BackColor = System.Drawing.Color.Black;
            this.Expon.FlatAppearance.BorderSize = 0;
            this.Expon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Expon.Location = new System.Drawing.Point(12, 89);
            this.Expon.Margin = new System.Windows.Forms.Padding(2);
            this.Expon.Name = "Expon";
            this.Expon.Size = new System.Drawing.Size(104, 51);
            this.Expon.TabIndex = 6;
            this.Expon.Text = "Z^n";
            this.Expon.UseVisualStyleBackColor = false;
            this.Expon.Click += new System.EventHandler(this.Expon_Click);
            // 
            // Rooting
            // 
            this.Rooting.BackColor = System.Drawing.Color.Black;
            this.Rooting.FlatAppearance.BorderSize = 0;
            this.Rooting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rooting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rooting.Location = new System.Drawing.Point(120, 89);
            this.Rooting.Margin = new System.Windows.Forms.Padding(2);
            this.Rooting.Name = "Rooting";
            this.Rooting.Size = new System.Drawing.Size(104, 51);
            this.Rooting.TabIndex = 7;
            this.Rooting.Text = "Z^(1/n)";
            this.Rooting.UseVisualStyleBackColor = false;
            this.Rooting.Click += new System.EventHandler(this.Rooting_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(269, 34);
            this.Result.Margin = new System.Windows.Forms.Padding(2);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Result.Size = new System.Drawing.Size(266, 280);
            this.Result.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(266, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 231);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(234, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Бинарные операции";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(18, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(18, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z2 =  ";
            // 
            // textX2
            // 
            this.textX2.Location = new System.Drawing.Point(40, 46);
            this.textX2.Margin = new System.Windows.Forms.Padding(2);
            this.textX2.Name = "textX2";
            this.textX2.Size = new System.Drawing.Size(76, 20);
            this.textX2.TabIndex = 6;
            this.textX2.TextChanged += new System.EventHandler(this.textX2_TextChanged);
            // 
            // textY2
            // 
            this.textY2.Location = new System.Drawing.Point(147, 46);
            this.textY2.Margin = new System.Windows.Forms.Padding(2);
            this.textY2.Name = "textY2";
            this.textY2.Size = new System.Drawing.Size(76, 20);
            this.textY2.TabIndex = 8;
            this.textY2.TextChanged += new System.EventHandler(this.textY2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "  + i * ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label11);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(234, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Унарные операции";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 11);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(15, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(220, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 10;
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(40, 48);
            this.textN.Margin = new System.Windows.Forms.Padding(2);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(76, 20);
            this.textN.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "n = ";
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(148, 11);
            this.textY.Margin = new System.Windows.Forms.Padding(2);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(76, 20);
            this.textY.TabIndex = 8;
            this.textY.TextChanged += new System.EventHandler(this.textY_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "+ i *";
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(40, 11);
            this.textX.Margin = new System.Windows.Forms.Padding(2);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(76, 20);
            this.textX.TabIndex = 6;
            this.textX.TextChanged += new System.EventHandler(this.textX_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Z =  ";
            // 
            // radioButtonDekart
            // 
            this.radioButtonDekart.AutoSize = true;
            this.radioButtonDekart.Checked = true;
            this.radioButtonDekart.Location = new System.Drawing.Point(4, 11);
            this.radioButtonDekart.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDekart.Name = "radioButtonDekart";
            this.radioButtonDekart.Size = new System.Drawing.Size(147, 17);
            this.radioButtonDekart.TabIndex = 7;
            this.radioButtonDekart.TabStop = true;
            this.radioButtonDekart.Text = "Декартовы координаты";
            this.radioButtonDekart.UseVisualStyleBackColor = true;
            this.radioButtonDekart.CheckedChanged += new System.EventHandler(this.radioButtonDekart_CheckedChanged);
            // 
            // radioButtonPolar
            // 
            this.radioButtonPolar.AutoSize = true;
            this.radioButtonPolar.Location = new System.Drawing.Point(4, 31);
            this.radioButtonPolar.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPolar.Name = "radioButtonPolar";
            this.radioButtonPolar.Size = new System.Drawing.Size(141, 17);
            this.radioButtonPolar.TabIndex = 8;
            this.radioButtonPolar.TabStop = true;
            this.radioButtonPolar.Text = "Полярные координаты";
            this.radioButtonPolar.UseVisualStyleBackColor = true;
            this.radioButtonPolar.CheckedChanged += new System.EventHandler(this.radioButtonPolar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDekart);
            this.groupBox1.Controls.Add(this.radioButtonPolar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(9, 253);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(178, 60);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.Location = new System.Drawing.Point(192, 253);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(59, 61);
            this.roundButton1.TabIndex = 10;
            this.roundButton1.Text = "Clear";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(548, 323);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Result);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButtonDekart;
        private System.Windows.Forms.RadioButton radioButtonPolar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private RoundButton roundButton1;
    }
}

