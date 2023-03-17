namespace listBox
{
    partial class TaskOneForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.calcFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(42, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 268);
            this.listBox1.TabIndex = 0;
            // 
            // calcFunc
            // 
            this.calcFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcFunc.Location = new System.Drawing.Point(160, 44);
            this.calcFunc.Name = "calcFunc";
            this.calcFunc.Size = new System.Drawing.Size(115, 35);
            this.calcFunc.TabIndex = 1;
            this.calcFunc.Text = "ПУСК";
            this.calcFunc.UseVisualStyleBackColor = true;
            this.calcFunc.Click += new System.EventHandler(this.calcFunc_Click);
            // 
            // TaskOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.calcFunc);
            this.Controls.Add(this.listBox1);
            this.Name = "TaskOneForm";
            this.Text = "Таблица значений F(x)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button calcFunc;
    }
}