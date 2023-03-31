namespace ShapeFiller
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
            this.btnTaskOne = new System.Windows.Forms.Button();
            this.btnTaskTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaskOne
            // 
            this.btnTaskOne.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTaskOne.Location = new System.Drawing.Point(151, 137);
            this.btnTaskOne.Name = "btnTaskOne";
            this.btnTaskOne.Size = new System.Drawing.Size(138, 37);
            this.btnTaskOne.TabIndex = 0;
            this.btnTaskOne.Text = "Задание 1";
            this.btnTaskOne.UseVisualStyleBackColor = true;
            this.btnTaskOne.Click += new System.EventHandler(this.btnTaskOne_Click);
            // 
            // btnTaskTwo
            // 
            this.btnTaskTwo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTaskTwo.Location = new System.Drawing.Point(151, 211);
            this.btnTaskTwo.Name = "btnTaskTwo";
            this.btnTaskTwo.Size = new System.Drawing.Size(138, 37);
            this.btnTaskTwo.TabIndex = 1;
            this.btnTaskTwo.Text = "Задание 2";
            this.btnTaskTwo.UseVisualStyleBackColor = true;
            this.btnTaskTwo.Click += new System.EventHandler(this.btnTaskTwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.btnTaskTwo);
            this.Controls.Add(this.btnTaskOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaskOne;
        private System.Windows.Forms.Button btnTaskTwo;
    }
}

