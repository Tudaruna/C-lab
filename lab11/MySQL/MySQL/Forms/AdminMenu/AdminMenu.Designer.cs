namespace MySQL
{
    partial class AdminMenu
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnMngCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(360, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnListUsers
            // 
            this.btnListUsers.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnListUsers.Location = new System.Drawing.Point(34, 58);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(213, 29);
            this.btnListUsers.TabIndex = 2;
            this.btnListUsers.Text = "Список пользователей";
            this.btnListUsers.UseVisualStyleBackColor = true;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnMngCustomers
            // 
            this.btnMngCustomers.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMngCustomers.Location = new System.Drawing.Point(34, 115);
            this.btnMngCustomers.Name = "btnMngCustomers";
            this.btnMngCustomers.Size = new System.Drawing.Size(213, 29);
            this.btnMngCustomers.TabIndex = 3;
            this.btnMngCustomers.Text = "Управление заказчиками";
            this.btnMngCustomers.UseVisualStyleBackColor = true;
            this.btnMngCustomers.Click += new System.EventHandler(this.btnMngCustomers_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnMngCustomers);
            this.Controls.Add(this.btnListUsers);
            this.Controls.Add(this.btnExit);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnMngCustomers;
    }
}