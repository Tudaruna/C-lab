namespace listBox
{
    partial class IndependentTaskTwoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputDeposit = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.inputPercent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calcTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите сумму вклада";
            // 
            // inputDeposit
            // 
            this.inputDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputDeposit.Location = new System.Drawing.Point(383, 41);
            this.inputDeposit.Name = "inputDeposit";
            this.inputDeposit.Size = new System.Drawing.Size(100, 29);
            this.inputDeposit.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 24;
            this.listBox.Location = new System.Drawing.Point(37, 153);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(446, 196);
            this.listBox.TabIndex = 2;
            // 
            // inputPercent
            // 
            this.inputPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPercent.Location = new System.Drawing.Point(383, 89);
            this.inputPercent.Name = "inputPercent";
            this.inputPercent.Size = new System.Drawing.Size(100, 29);
            this.inputPercent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите процентную ставку";
            // 
            // calcTotal
            // 
            this.calcTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcTotal.Location = new System.Drawing.Point(588, 153);
            this.calcTotal.Name = "calcTotal";
            this.calcTotal.Size = new System.Drawing.Size(142, 34);
            this.calcTotal.TabIndex = 5;
            this.calcTotal.Text = "Рассчитать";
            this.calcTotal.UseVisualStyleBackColor = true;
            this.calcTotal.Click += new System.EventHandler(this.calcTotal_Click);
            // 
            // IndependentTaskTwoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.calcTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPercent);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.inputDeposit);
            this.Controls.Add(this.label1);
            this.Name = "IndependentTaskTwoForm";
            this.Text = "IndependentTaskTwoForm";
            this.Load += new System.EventHandler(this.IndependentTaskTwoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputDeposit;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox inputPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcTotal;
    }
}