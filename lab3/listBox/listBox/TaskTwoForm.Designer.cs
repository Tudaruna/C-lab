namespace listBox
{
    partial class TaskTwoForm
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
            this.result = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.input = new System.Windows.Forms.TextBox();
            this.searchNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите кол-во целых чисел";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(51, 435);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 24);
            this.result.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 24;
            this.listBox.Location = new System.Drawing.Point(55, 115);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(383, 220);
            this.listBox.TabIndex = 2;
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(338, 44);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 29);
            this.input.TabIndex = 3;
            // 
            // searchNum
            // 
            this.searchNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchNum.Location = new System.Drawing.Point(191, 358);
            this.searchNum.Name = "searchNum";
            this.searchNum.Size = new System.Drawing.Size(100, 34);
            this.searchNum.TabIndex = 4;
            this.searchNum.Text = "Найти";
            this.searchNum.UseVisualStyleBackColor = true;
            this.searchNum.Click += new System.EventHandler(this.searchNum_Click);
            // 
            // TaskTwoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 582);
            this.Controls.Add(this.searchNum);
            this.Controls.Add(this.input);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Name = "TaskTwoForm";
            this.Text = "TaskTwoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button searchNum;
    }
}