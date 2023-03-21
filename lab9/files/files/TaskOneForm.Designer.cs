namespace files
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbEdit = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tbInput.Location = new System.Drawing.Point(22, 26);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(209, 20);
            this.tbInput.TabIndex = 0;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetInfo.Location = new System.Drawing.Point(260, 17);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(194, 37);
            this.btnGetInfo.TabIndex = 1;
            this.btnGetInfo.Text = "Загрузить информацию";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(22, 100);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(432, 153);
            this.tbInfo.TabIndex = 2;
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(22, 289);
            this.tbEdit.Multiline = true;
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.ReadOnly = true;
            this.tbEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbEdit.Size = new System.Drawing.Size(432, 153);
            this.tbEdit.TabIndex = 3;
            this.tbEdit.WordWrap = false;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(24, 267);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(110, 13);
            this.lblEdit.TabIndex = 4;
            this.lblEdit.Text = "Содержимое файла:";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(24, 79);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(120, 13);
            this.lblFilename.TabIndex = 5;
            this.lblFilename.Text = "Информация о файле:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(260, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TaskOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 517);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.tbEdit);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.tbInput);
            this.Name = "TaskOneForm";
            this.Text = "TaskOneForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.TextBox tbEdit;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnSave;
    }
}