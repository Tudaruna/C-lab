namespace XmlFiles
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
            this.cmbBorderStyle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbMinimized = new System.Windows.Forms.CheckBox();
            this.chbMaximized = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnFontChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стиль рамки";
            // 
            // cmbBorderStyle
            // 
            this.cmbBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorderStyle.FormattingEnabled = true;
            this.cmbBorderStyle.Items.AddRange(new object[] {
            "Рамка отсутствует",
            "Фиксированная однострочная граница",
            "Фиксированная трехмерная граница",
            "В стиле диалоговых окон",
            "Изменяемая граница",
            "Не изменяемая граница окна настроек",
            "Изменяемая граница окна настроек"});
            this.cmbBorderStyle.Location = new System.Drawing.Point(166, 34);
            this.cmbBorderStyle.Name = "cmbBorderStyle";
            this.cmbBorderStyle.Size = new System.Drawing.Size(219, 21);
            this.cmbBorderStyle.TabIndex = 1;
            this.cmbBorderStyle.SelectedIndexChanged += new System.EventHandler(this.cmbBorderStyle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кнопки строки заголовка";
            // 
            // chbMinimized
            // 
            this.chbMinimized.AutoSize = true;
            this.chbMinimized.Location = new System.Drawing.Point(166, 84);
            this.chbMinimized.Name = "chbMinimized";
            this.chbMinimized.Size = new System.Drawing.Size(73, 17);
            this.chbMinimized.TabIndex = 3;
            this.chbMinimized.Text = "Свернуть";
            this.chbMinimized.UseVisualStyleBackColor = true;
            this.chbMinimized.CheckedChanged += new System.EventHandler(this.chbMinimized_CheckedChanged);
            // 
            // chbMaximized
            // 
            this.chbMaximized.AutoSize = true;
            this.chbMaximized.Location = new System.Drawing.Point(166, 121);
            this.chbMaximized.Name = "chbMaximized";
            this.chbMaximized.Size = new System.Drawing.Size(97, 17);
            this.chbMaximized.TabIndex = 4;
            this.chbMaximized.Text = "Восстановить";
            this.chbMaximized.UseVisualStyleBackColor = true;
            this.chbMaximized.CheckedChanged += new System.EventHandler(this.chbMaximized_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цвет фона";
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(163, 157);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(66, 13);
            this.lblBackColor.TabIndex = 6;
            this.lblBackColor.Text = "lblBackColor";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeColor.Location = new System.Drawing.Point(240, 277);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(118, 29);
            this.btnChangeColor.TabIndex = 7;
            this.btnChangeColor.Text = "Изменить";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(240, 335);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 29);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFontChange
            // 
            this.btnFontChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFontChange.Location = new System.Drawing.Point(240, 198);
            this.btnFontChange.Name = "btnFontChange";
            this.btnFontChange.Size = new System.Drawing.Size(118, 57);
            this.btnFontChange.TabIndex = 9;
            this.btnFontChange.Text = "Изменить шрифт";
            this.btnFontChange.UseVisualStyleBackColor = true;
            this.btnFontChange.Click += new System.EventHandler(this.btnFontChange_Click);
            // 
            // TaskTwoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::XmlFiles.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(397, 405);
            this.Controls.Add(this.btnFontChange);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lblBackColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbMaximized);
            this.Controls.Add(this.chbMinimized);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBorderStyle);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("FormBorderStyle", global::XmlFiles.Properties.Settings.Default, "BorderStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::XmlFiles.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("MaximizeBox", global::XmlFiles.Properties.Settings.Default, "Maximized", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("MinimizeBox", global::XmlFiles.Properties.Settings.Default, "Minimized", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = global::XmlFiles.Properties.Settings.Default.BorderStyle;
            this.MaximizeBox = global::XmlFiles.Properties.Settings.Default.Maximized;
            this.MinimizeBox = global::XmlFiles.Properties.Settings.Default.Minimized;
            this.Name = "TaskTwoForm";
            this.Text = "TaskTwoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskTwoForm_FormClosing);
            this.Load += new System.EventHandler(this.TaskTwoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBorderStyle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbMinimized;
        private System.Windows.Forms.CheckBox chbMaximized;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnFontChange;
    }
}