namespace lab_1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputNum1ForAvg = new System.Windows.Forms.TextBox();
            this.inputNum2ForAvg = new System.Windows.Forms.TextBox();
            this.inputNum3ForAvg = new System.Windows.Forms.TextBox();
            this.labelAvg = new System.Windows.Forms.Label();
            this.inputNum1ForMaxMin = new System.Windows.Forms.TextBox();
            this.inputNum2ForMaxMin = new System.Windows.Forms.TextBox();
            this.inputNumCheckIsInterval = new System.Windows.Forms.TextBox();
            this.inputStartInterval = new System.Windows.Forms.TextBox();
            this.inputEndInterval = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMaxNum = new System.Windows.Forms.Label();
            this.labelMinNum = new System.Windows.Forms.Label();
            this.labelNumIsInterval = new System.Windows.Forms.Label();
            this.btnCalcAvg = new System.Windows.Forms.Button();
            this.btnCalcMinMax = new System.Windows.Forms.Button();
            this.btnCheckInterval = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите 3 числа для подсчета сред.арифм:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите 2 числа:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите число:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введите интервал от:";
            // 
            // inputNum1ForAvg
            // 
            this.inputNum1ForAvg.Location = new System.Drawing.Point(307, 29);
            this.inputNum1ForAvg.Name = "inputNum1ForAvg";
            this.inputNum1ForAvg.Size = new System.Drawing.Size(55, 20);
            this.inputNum1ForAvg.TabIndex = 4;
            this.inputNum1ForAvg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // inputNum2ForAvg
            // 
            this.inputNum2ForAvg.Location = new System.Drawing.Point(380, 29);
            this.inputNum2ForAvg.Name = "inputNum2ForAvg";
            this.inputNum2ForAvg.Size = new System.Drawing.Size(55, 20);
            this.inputNum2ForAvg.TabIndex = 5;
            this.inputNum2ForAvg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // inputNum3ForAvg
            // 
            this.inputNum3ForAvg.Location = new System.Drawing.Point(454, 30);
            this.inputNum3ForAvg.Name = "inputNum3ForAvg";
            this.inputNum3ForAvg.Size = new System.Drawing.Size(55, 20);
            this.inputNum3ForAvg.TabIndex = 6;
            this.inputNum3ForAvg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Location = new System.Drawing.Point(97, 76);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(26, 13);
            this.labelAvg.TabIndex = 7;
            this.labelAvg.Text = "Avg";
            // 
            // inputNum1ForMaxMin
            // 
            this.inputNum1ForMaxMin.Location = new System.Drawing.Point(189, 214);
            this.inputNum1ForMaxMin.Name = "inputNum1ForMaxMin";
            this.inputNum1ForMaxMin.Size = new System.Drawing.Size(55, 20);
            this.inputNum1ForMaxMin.TabIndex = 8;
            this.inputNum1ForMaxMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // inputNum2ForMaxMin
            // 
            this.inputNum2ForMaxMin.Location = new System.Drawing.Point(268, 214);
            this.inputNum2ForMaxMin.Name = "inputNum2ForMaxMin";
            this.inputNum2ForMaxMin.Size = new System.Drawing.Size(55, 20);
            this.inputNum2ForMaxMin.TabIndex = 9;
            this.inputNum2ForMaxMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // inputNumCheckIsInterval
            // 
            this.inputNumCheckIsInterval.Location = new System.Drawing.Point(182, 410);
            this.inputNumCheckIsInterval.Name = "inputNumCheckIsInterval";
            this.inputNumCheckIsInterval.Size = new System.Drawing.Size(55, 20);
            this.inputNumCheckIsInterval.TabIndex = 10;
            this.inputNumCheckIsInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // inputStartInterval
            // 
            this.inputStartInterval.Location = new System.Drawing.Point(426, 409);
            this.inputStartInterval.Name = "inputStartInterval";
            this.inputStartInterval.Size = new System.Drawing.Size(55, 20);
            this.inputStartInterval.TabIndex = 11;
            this.inputStartInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // inputEndInterval
            // 
            this.inputEndInterval.Location = new System.Drawing.Point(516, 409);
            this.inputEndInterval.Name = "inputEndInterval";
            this.inputEndInterval.Size = new System.Drawing.Size(55, 20);
            this.inputEndInterval.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "до";
            // 
            // labelMaxNum
            // 
            this.labelMaxNum.AutoSize = true;
            this.labelMaxNum.Location = new System.Drawing.Point(71, 265);
            this.labelMaxNum.Name = "labelMaxNum";
            this.labelMaxNum.Size = new System.Drawing.Size(27, 13);
            this.labelMaxNum.TabIndex = 14;
            this.labelMaxNum.Text = "Max";
            // 
            // labelMinNum
            // 
            this.labelMinNum.AutoSize = true;
            this.labelMinNum.Location = new System.Drawing.Point(265, 265);
            this.labelMinNum.Name = "labelMinNum";
            this.labelMinNum.Size = new System.Drawing.Size(24, 13);
            this.labelMinNum.TabIndex = 15;
            this.labelMinNum.Text = "Min";
            // 
            // labelNumIsInterval
            // 
            this.labelNumIsInterval.AutoSize = true;
            this.labelNumIsInterval.Location = new System.Drawing.Point(64, 475);
            this.labelNumIsInterval.Name = "labelNumIsInterval";
            this.labelNumIsInterval.Size = new System.Drawing.Size(49, 13);
            this.labelNumIsInterval.TabIndex = 16;
            this.labelNumIsInterval.Text = "isInterval";
            // 
            // btnCalcAvg
            // 
            this.btnCalcAvg.Location = new System.Drawing.Point(74, 126);
            this.btnCalcAvg.Name = "btnCalcAvg";
            this.btnCalcAvg.Size = new System.Drawing.Size(165, 23);
            this.btnCalcAvg.TabIndex = 17;
            this.btnCalcAvg.Text = "Сред.арифметическое";
            this.btnCalcAvg.UseVisualStyleBackColor = true;
            this.btnCalcAvg.Click += new System.EventHandler(this.btnCalcAvg_Click);
            // 
            // btnCalcMinMax
            // 
            this.btnCalcMinMax.Location = new System.Drawing.Point(74, 328);
            this.btnCalcMinMax.Name = "btnCalcMinMax";
            this.btnCalcMinMax.Size = new System.Drawing.Size(165, 23);
            this.btnCalcMinMax.TabIndex = 18;
            this.btnCalcMinMax.Text = "Определение Min и Max числа";
            this.btnCalcMinMax.UseVisualStyleBackColor = true;
            this.btnCalcMinMax.Click += new System.EventHandler(this.btnCalcMinMax_Click);
            // 
            // btnCheckInterval
            // 
            this.btnCheckInterval.Location = new System.Drawing.Point(72, 526);
            this.btnCheckInterval.Name = "btnCheckInterval";
            this.btnCheckInterval.Size = new System.Drawing.Size(165, 52);
            this.btnCheckInterval.TabIndex = 19;
            this.btnCheckInterval.Text = "Проверка входит число в интервал или нет";
            this.btnCheckInterval.UseVisualStyleBackColor = true;
            this.btnCheckInterval.Click += new System.EventHandler(this.btnCheckInterval_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.btnCheckInterval);
            this.Controls.Add(this.btnCalcMinMax);
            this.Controls.Add(this.btnCalcAvg);
            this.Controls.Add(this.labelNumIsInterval);
            this.Controls.Add(this.labelMinNum);
            this.Controls.Add(this.labelMaxNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputEndInterval);
            this.Controls.Add(this.inputStartInterval);
            this.Controls.Add(this.inputNumCheckIsInterval);
            this.Controls.Add(this.inputNum2ForMaxMin);
            this.Controls.Add(this.inputNum1ForMaxMin);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.inputNum3ForAvg);
            this.Controls.Add(this.inputNum2ForAvg);
            this.Controls.Add(this.inputNum1ForAvg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputNum1ForAvg;
        private System.Windows.Forms.TextBox inputNum2ForAvg;
        private System.Windows.Forms.TextBox inputNum3ForAvg;
        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.TextBox inputNum1ForMaxMin;
        private System.Windows.Forms.TextBox inputNum2ForMaxMin;
        private System.Windows.Forms.TextBox inputNumCheckIsInterval;
        private System.Windows.Forms.TextBox inputStartInterval;
        private System.Windows.Forms.TextBox inputEndInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMaxNum;
        private System.Windows.Forms.Label labelMinNum;
        private System.Windows.Forms.Label labelNumIsInterval;
        private System.Windows.Forms.Button btnCalcAvg;
        private System.Windows.Forms.Button btnCalcMinMax;
        private System.Windows.Forms.Button btnCheckInterval;
    }
}

