namespace listBox
{
    partial class IndependentTaskOneForm
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
            this.input = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.addGnom = new System.Windows.Forms.Button();
            this.delGnom = new System.Windows.Forms.Button();
            this.clearListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите рост гнома (см)";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(305, 46);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 29);
            this.input.TabIndex = 1;
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 24;
            this.listBox.Location = new System.Drawing.Point(40, 120);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(333, 244);
            this.listBox.TabIndex = 2;
            // 
            // addGnom
            // 
            this.addGnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGnom.Location = new System.Drawing.Point(397, 159);
            this.addGnom.Name = "addGnom";
            this.addGnom.Size = new System.Drawing.Size(128, 31);
            this.addGnom.TabIndex = 3;
            this.addGnom.Text = "Добавить";
            this.addGnom.UseVisualStyleBackColor = true;
            this.addGnom.Click += new System.EventHandler(this.addGnom_Click);
            // 
            // delGnom
            // 
            this.delGnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delGnom.Location = new System.Drawing.Point(397, 217);
            this.delGnom.Name = "delGnom";
            this.delGnom.Size = new System.Drawing.Size(128, 31);
            this.delGnom.TabIndex = 4;
            this.delGnom.Text = "Удалить";
            this.delGnom.UseVisualStyleBackColor = true;
            this.delGnom.Click += new System.EventHandler(this.delGnom_Click);
            // 
            // clearListBox
            // 
            this.clearListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearListBox.Location = new System.Drawing.Point(397, 273);
            this.clearListBox.Name = "clearListBox";
            this.clearListBox.Size = new System.Drawing.Size(128, 31);
            this.clearListBox.TabIndex = 5;
            this.clearListBox.Text = "Стереть";
            this.clearListBox.UseVisualStyleBackColor = true;
            this.clearListBox.Click += new System.EventHandler(this.clearListBox_Click);
            // 
            // IndependentTaskOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.clearListBox);
            this.Controls.Add(this.delGnom);
            this.Controls.Add(this.addGnom);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Name = "IndependentTaskOneForm";
            this.Text = "IndependentTaskOneForm";
            this.Load += new System.EventHandler(this.IndependentTaskOneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addGnom;
        private System.Windows.Forms.Button delGnom;
        private System.Windows.Forms.Button clearListBox;
    }
}