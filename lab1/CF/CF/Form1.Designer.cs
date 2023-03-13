namespace CF
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
            this.label_tempF = new System.Windows.Forms.Label();
            this.translateTemp = new System.Windows.Forms.Button();
            this.input_tempF = new System.Windows.Forms.TextBox();
            this.label_tempC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_tempF
            // 
            this.label_tempF.AutoSize = true;
            this.label_tempF.Location = new System.Drawing.Point(44, 113);
            this.label_tempF.Name = "label_tempF";
            this.label_tempF.Size = new System.Drawing.Size(199, 13);
            this.label_tempF.TabIndex = 0;
            this.label_tempF.Text = "Введите температуру по Фаренгейту:\r\n";
            // 
            // translateTemp
            // 
            this.translateTemp.Location = new System.Drawing.Point(149, 215);
            this.translateTemp.Name = "translateTemp";
            this.translateTemp.Size = new System.Drawing.Size(147, 23);
            this.translateTemp.TabIndex = 1;
            this.translateTemp.Text = "Перевод температуры";
            this.translateTemp.UseVisualStyleBackColor = true;
            this.translateTemp.Click += new System.EventHandler(this.translateTemp_Click);
            // 
            // input_tempF
            // 
            this.input_tempF.Location = new System.Drawing.Point(272, 110);
            this.input_tempF.Name = "input_tempF";
            this.input_tempF.Size = new System.Drawing.Size(100, 20);
            this.input_tempF.TabIndex = 2;
            // 
            // label_tempC
            // 
            this.label_tempC.AutoSize = true;
            this.label_tempC.Location = new System.Drawing.Point(44, 147);
            this.label_tempC.Name = "label_tempC";
            this.label_tempC.Size = new System.Drawing.Size(0, 13);
            this.label_tempC.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 301);
            this.Controls.Add(this.label_tempC);
            this.Controls.Add(this.input_tempF);
            this.Controls.Add(this.translateTemp);
            this.Controls.Add(this.label_tempF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tempF;
        private System.Windows.Forms.Button translateTemp;
        private System.Windows.Forms.TextBox input_tempF;
        private System.Windows.Forms.Label label_tempC;
    }
}

