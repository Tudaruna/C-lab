namespace MySQL
{
    partial class CustomerManagement
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.btnOpenFormAddCustomer = new System.Windows.Forms.Button();
            this.btnOpenFormEditCustomer = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExecQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(634, 515);
            this.dataGridView.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(709, 494);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(190, 28);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnOpenFormAddCustomer
            // 
            this.btnOpenFormAddCustomer.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenFormAddCustomer.Location = new System.Drawing.Point(709, 24);
            this.btnOpenFormAddCustomer.Name = "btnOpenFormAddCustomer";
            this.btnOpenFormAddCustomer.Size = new System.Drawing.Size(190, 48);
            this.btnOpenFormAddCustomer.TabIndex = 3;
            this.btnOpenFormAddCustomer.Text = "Добавить нового заказчика";
            this.btnOpenFormAddCustomer.UseVisualStyleBackColor = true;
            this.btnOpenFormAddCustomer.Click += new System.EventHandler(this.btnOpenFormAddCustomer_Click);
            // 
            // btnOpenFormEditCustomer
            // 
            this.btnOpenFormEditCustomer.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenFormEditCustomer.Location = new System.Drawing.Point(709, 103);
            this.btnOpenFormEditCustomer.Name = "btnOpenFormEditCustomer";
            this.btnOpenFormEditCustomer.Size = new System.Drawing.Size(190, 48);
            this.btnOpenFormEditCustomer.TabIndex = 4;
            this.btnOpenFormEditCustomer.Text = "Редактирование выбранного заказчика";
            this.btnOpenFormEditCustomer.UseVisualStyleBackColor = true;
            this.btnOpenFormEditCustomer.Click += new System.EventHandler(this.btnOpenFormEditCustomer_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(709, 438);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Обновить все данные";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(709, 184);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(190, 48);
            this.btnDeleteCustomer.TabIndex = 6;
            this.btnDeleteCustomer.Text = "Удалить выбранного заказчика";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Пользователь",
            "Имя",
            "Телефон",
            "Почта",
            "Адрес"});
            this.comboBox.Location = new System.Drawing.Point(709, 278);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(190, 26);
            this.comboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(710, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите поле для отбора";
            // 
            // inputValue
            // 
            this.inputValue.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputValue.Location = new System.Drawing.Point(709, 341);
            this.inputValue.Name = "inputValue";
            this.inputValue.Size = new System.Drawing.Size(190, 23);
            this.inputValue.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(710, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите значение поля";
            // 
            // btnExecQuery
            // 
            this.btnExecQuery.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExecQuery.Location = new System.Drawing.Point(709, 385);
            this.btnExecQuery.Name = "btnExecQuery";
            this.btnExecQuery.Size = new System.Drawing.Size(190, 30);
            this.btnExecQuery.TabIndex = 11;
            this.btnExecQuery.Text = "Выполнить запрос";
            this.btnExecQuery.UseVisualStyleBackColor = true;
            this.btnExecQuery.Click += new System.EventHandler(this.btnExecQuery_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 572);
            this.Controls.Add(this.btnExecQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnOpenFormEditCustomer);
            this.Controls.Add(this.btnOpenFormAddCustomer);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridView);
            this.Name = "CustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnOpenFormAddCustomer;
        private System.Windows.Forms.Button btnOpenFormEditCustomer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExecQuery;
    }
}