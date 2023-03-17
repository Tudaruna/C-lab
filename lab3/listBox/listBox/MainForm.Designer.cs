namespace listBox
{
    partial class MainForm
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
            this.switchToTaskOne = new System.Windows.Forms.Button();
            this.switchToTaskTwo = new System.Windows.Forms.Button();
            this.switchToTaskThree = new System.Windows.Forms.Button();
            this.switchToIndependendTaskOne = new System.Windows.Forms.Button();
            this.switchToIndependentTaskTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // switchToTaskOne
            // 
            this.switchToTaskOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.switchToTaskOne.Location = new System.Drawing.Point(71, 54);
            this.switchToTaskOne.Name = "switchToTaskOne";
            this.switchToTaskOne.Size = new System.Drawing.Size(330, 30);
            this.switchToTaskOne.TabIndex = 0;
            this.switchToTaskOne.Text = "Задание 1";
            this.switchToTaskOne.UseVisualStyleBackColor = true;
            this.switchToTaskOne.Click += new System.EventHandler(this.switchToTaskOne_Click);
            // 
            // switchToTaskTwo
            // 
            this.switchToTaskTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.switchToTaskTwo.Location = new System.Drawing.Point(71, 135);
            this.switchToTaskTwo.Name = "switchToTaskTwo";
            this.switchToTaskTwo.Size = new System.Drawing.Size(330, 30);
            this.switchToTaskTwo.TabIndex = 1;
            this.switchToTaskTwo.Text = "Задание 2";
            this.switchToTaskTwo.UseVisualStyleBackColor = true;
            this.switchToTaskTwo.Click += new System.EventHandler(this.switchToTaskTwo_Click);
            // 
            // switchToTaskThree
            // 
            this.switchToTaskThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.switchToTaskThree.Location = new System.Drawing.Point(71, 213);
            this.switchToTaskThree.Name = "switchToTaskThree";
            this.switchToTaskThree.Size = new System.Drawing.Size(330, 30);
            this.switchToTaskThree.TabIndex = 2;
            this.switchToTaskThree.Text = "Задание 3";
            this.switchToTaskThree.UseVisualStyleBackColor = true;
            this.switchToTaskThree.Click += new System.EventHandler(this.switchToTaskThree_Click);
            // 
            // switchToIndependendTaskOne
            // 
            this.switchToIndependendTaskOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.switchToIndependendTaskOne.Location = new System.Drawing.Point(71, 296);
            this.switchToIndependendTaskOne.Name = "switchToIndependendTaskOne";
            this.switchToIndependendTaskOne.Size = new System.Drawing.Size(330, 30);
            this.switchToIndependendTaskOne.TabIndex = 3;
            this.switchToIndependendTaskOne.Text = "Самостоятельное задание 1.1";
            this.switchToIndependendTaskOne.UseVisualStyleBackColor = true;
            this.switchToIndependendTaskOne.Click += new System.EventHandler(this.switchToIndependendTaskOne_Click);
            // 
            // switchToIndependentTaskTwo
            // 
            this.switchToIndependentTaskTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.switchToIndependentTaskTwo.Location = new System.Drawing.Point(71, 362);
            this.switchToIndependentTaskTwo.Name = "switchToIndependentTaskTwo";
            this.switchToIndependentTaskTwo.Size = new System.Drawing.Size(330, 30);
            this.switchToIndependentTaskTwo.TabIndex = 4;
            this.switchToIndependentTaskTwo.Text = "Самостоятельное задание 1.2";
            this.switchToIndependentTaskTwo.UseVisualStyleBackColor = true;
            this.switchToIndependentTaskTwo.Click += new System.EventHandler(this.switchToIndependentTaskTwo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.switchToIndependentTaskTwo);
            this.Controls.Add(this.switchToIndependendTaskOne);
            this.Controls.Add(this.switchToTaskThree);
            this.Controls.Add(this.switchToTaskTwo);
            this.Controls.Add(this.switchToTaskOne);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button switchToTaskOne;
        private System.Windows.Forms.Button switchToTaskTwo;
        private System.Windows.Forms.Button switchToTaskThree;
        private System.Windows.Forms.Button switchToIndependendTaskOne;
        private System.Windows.Forms.Button switchToIndependentTaskTwo;
    }
}

