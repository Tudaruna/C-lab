namespace workWithNum
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
            this.calcNum = new System.Windows.Forms.Button();
            this.inputNum = new System.Windows.Forms.TextBox();
            this.resultNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNum2 = new System.Windows.Forms.TextBox();
            this.resultCheck = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите целое число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(132, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Результат";
            // 
            // calcNum
            // 
            this.calcNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcNum.Location = new System.Drawing.Point(163, 133);
            this.calcNum.Name = "calcNum";
            this.calcNum.Size = new System.Drawing.Size(149, 35);
            this.calcNum.TabIndex = 2;
            this.calcNum.Text = "Вычислить";
            this.calcNum.UseVisualStyleBackColor = true;
            this.calcNum.Click += new System.EventHandler(this.calcNum_Click);
            // 
            // inputNum
            // 
            this.inputNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNum.Location = new System.Drawing.Point(302, 53);
            this.inputNum.Name = "inputNum";
            this.inputNum.Size = new System.Drawing.Size(100, 29);
            this.inputNum.TabIndex = 3;
            this.inputNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNum_KeyPress);
            // 
            // resultNum
            // 
            this.resultNum.Enabled = false;
            this.resultNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultNum.Location = new System.Drawing.Point(261, 215);
            this.resultNum.Name = "resultNum";
            this.resultNum.Size = new System.Drawing.Size(100, 29);
            this.resultNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Самостоятельное задание № 5 Вар 1";
            // 
            // inputNum2
            // 
            this.inputNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNum2.Location = new System.Drawing.Point(331, 404);
            this.inputNum2.Name = "inputNum2";
            this.inputNum2.Size = new System.Drawing.Size(100, 29);
            this.inputNum2.TabIndex = 7;
            // 
            // resultCheck
            // 
            this.resultCheck.AutoSize = true;
            this.resultCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultCheck.Location = new System.Drawing.Point(40, 470);
            this.resultCheck.Name = "resultCheck";
            this.resultCheck.Size = new System.Drawing.Size(0, 24);
            this.resultCheck.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите двузначное число";
            // 
            // CheckNum
            // 
            this.CheckNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckNum.Location = new System.Drawing.Point(131, 546);
            this.CheckNum.Name = "CheckNum";
            this.CheckNum.Size = new System.Drawing.Size(230, 35);
            this.CheckNum.TabIndex = 10;
            this.CheckNum.Text = "Проверить число";
            this.CheckNum.UseVisualStyleBackColor = true;
            this.CheckNum.Click += new System.EventHandler(this.CheckNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 729);
            this.Controls.Add(this.CheckNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultCheck);
            this.Controls.Add(this.inputNum2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultNum);
            this.Controls.Add(this.inputNum);
            this.Controls.Add(this.calcNum);
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
        private System.Windows.Forms.Button calcNum;
        private System.Windows.Forms.TextBox inputNum;
        private System.Windows.Forms.TextBox resultNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNum2;
        private System.Windows.Forms.Label resultCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CheckNum;
    }
}

