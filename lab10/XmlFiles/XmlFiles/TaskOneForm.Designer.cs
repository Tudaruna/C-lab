namespace XmlFiles
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
            this.listOfPlayers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.btnOutWhere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumStart = new System.Windows.Forms.TextBox();
            this.tbNumEnd = new System.Windows.Forms.TextBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfPlayers
            // 
            this.listOfPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listOfPlayers.HideSelection = false;
            this.listOfPlayers.Location = new System.Drawing.Point(24, 50);
            this.listOfPlayers.Name = "listOfPlayers";
            this.listOfPlayers.Size = new System.Drawing.Size(423, 201);
            this.listOfPlayers.TabIndex = 0;
            this.listOfPlayers.UseCompatibleStateImageBehavior = false;
            this.listOfPlayers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Количество очков";
            this.columnHeader3.Width = 130;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(10, 123);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(125, 20);
            this.txtScore.TabIndex = 1;
            this.txtScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScore_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtScore);
            this.groupBox1.Location = new System.Drawing.Point(493, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 201);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(7, 97);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(98, 13);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Количество очков";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Имя";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(21, 25);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(88, 13);
            this.lblList.TabIndex = 4;
            this.lblList.Text = "Список игроков";
            // 
            // btnOutWhere
            // 
            this.btnOutWhere.Location = new System.Drawing.Point(24, 271);
            this.btnOutWhere.Name = "btnOutWhere";
            this.btnOutWhere.Size = new System.Drawing.Size(125, 40);
            this.btnOutWhere.TabIndex = 5;
            this.btnOutWhere.Text = "Вывод записей по количеству очков";
            this.btnOutWhere.UseVisualStyleBackColor = true;
            this.btnOutWhere.Click += new System.EventHandler(this.btnOutWhere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "До";
            // 
            // tbNumStart
            // 
            this.tbNumStart.Location = new System.Drawing.Point(188, 281);
            this.tbNumStart.Name = "tbNumStart";
            this.tbNumStart.Size = new System.Drawing.Size(58, 20);
            this.tbNumStart.TabIndex = 8;
            // 
            // tbNumEnd
            // 
            this.tbNumEnd.Location = new System.Drawing.Point(296, 281);
            this.tbNumEnd.Name = "tbNumEnd";
            this.tbNumEnd.Size = new System.Drawing.Size(58, 20);
            this.tbNumEnd.TabIndex = 9;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Время выполнения";
            this.columnHeader4.Width = 115;
            // 
            // viewList
            // 
            this.viewList.Location = new System.Drawing.Point(503, 271);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(125, 23);
            this.viewList.TabIndex = 10;
            this.viewList.Text = "Просмотр списка";
            this.viewList.UseVisualStyleBackColor = true;
            this.viewList.Click += new System.EventHandler(this.viewList_Click);
            // 
            // TaskOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 337);
            this.Controls.Add(this.viewList);
            this.Controls.Add(this.tbNumEnd);
            this.Controls.Add(this.tbNumStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOutWhere);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listOfPlayers);
            this.Name = "TaskOneForm";
            this.Text = "TaskOneForm";
            this.Load += new System.EventHandler(this.TaskOneForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listOfPlayers;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnOutWhere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumStart;
        private System.Windows.Forms.TextBox tbNumEnd;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button viewList;
    }
}