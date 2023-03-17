namespace listBox
{
    partial class TaskThreeForm
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
            this.addRow = new System.Windows.Forms.Button();
            this.checkAndChange = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число для добавления";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(372, 53);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 29);
            this.input.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 24;
            this.listBox.Location = new System.Drawing.Point(37, 122);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(277, 292);
            this.listBox.TabIndex = 2;
            // 
            // addRow
            // 
            this.addRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRow.Location = new System.Drawing.Point(351, 121);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(131, 42);
            this.addRow.TabIndex = 3;
            this.addRow.Text = "Добавить";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // checkAndChange
            // 
            this.checkAndChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAndChange.Location = new System.Drawing.Point(351, 183);
            this.checkAndChange.Name = "checkAndChange";
            this.checkAndChange.Size = new System.Drawing.Size(131, 61);
            this.checkAndChange.TabIndex = 4;
            this.checkAndChange.Text = "Проверить и заменить";
            this.checkAndChange.UseVisualStyleBackColor = true;
            this.checkAndChange.Click += new System.EventHandler(this.checkAndChange_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(351, 259);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(131, 42);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.Location = new System.Drawing.Point(351, 312);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(131, 42);
            this.Change.TabIndex = 6;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(351, 368);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(131, 42);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // TaskThreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.checkAndChange);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Name = "TaskThreeForm";
            this.Text = "TaskThreeForm";
            this.Load += new System.EventHandler(this.TaskThreeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addRow;
        private System.Windows.Forms.Button checkAndChange;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
    }
}