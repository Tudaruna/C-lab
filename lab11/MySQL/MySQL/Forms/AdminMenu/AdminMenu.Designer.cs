﻿namespace MySQL
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
            this.btnMngWareHouse = new System.Windows.Forms.Button();
            this.btnViewAssortiment = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.lblAuth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(361, 393);
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
            this.btnListUsers.Location = new System.Drawing.Point(34, 85);
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
            this.btnMngCustomers.Location = new System.Drawing.Point(34, 142);
            this.btnMngCustomers.Name = "btnMngCustomers";
            this.btnMngCustomers.Size = new System.Drawing.Size(213, 29);
            this.btnMngCustomers.TabIndex = 3;
            this.btnMngCustomers.Text = "Управление заказчиками";
            this.btnMngCustomers.UseVisualStyleBackColor = true;
            this.btnMngCustomers.Click += new System.EventHandler(this.btnMngCustomers_Click);
            // 
            // btnMngWareHouse
            // 
            this.btnMngWareHouse.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMngWareHouse.Location = new System.Drawing.Point(34, 203);
            this.btnMngWareHouse.Name = "btnMngWareHouse";
            this.btnMngWareHouse.Size = new System.Drawing.Size(213, 29);
            this.btnMngWareHouse.TabIndex = 4;
            this.btnMngWareHouse.Text = "Управление складом";
            this.btnMngWareHouse.UseVisualStyleBackColor = true;
            this.btnMngWareHouse.Click += new System.EventHandler(this.btnMngWareHouse_Click);
            // 
            // btnViewAssortiment
            // 
            this.btnViewAssortiment.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewAssortiment.Location = new System.Drawing.Point(34, 263);
            this.btnViewAssortiment.Name = "btnViewAssortiment";
            this.btnViewAssortiment.Size = new System.Drawing.Size(213, 29);
            this.btnViewAssortiment.TabIndex = 5;
            this.btnViewAssortiment.Text = "Просмотр ассортимента";
            this.btnViewAssortiment.UseVisualStyleBackColor = true;
            this.btnViewAssortiment.Click += new System.EventHandler(this.btnViewAssortiment_Click);
            // 
            // btnSales
            // 
            this.btnSales.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSales.Location = new System.Drawing.Point(34, 317);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(213, 29);
            this.btnSales.TabIndex = 6;
            this.btnSales.Text = "Просмотр продаж";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("Montserrat ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuth.Location = new System.Drawing.Point(67, 22);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(364, 37);
            this.lblAuth.TabIndex = 7;
            this.lblAuth.Text = "Меню администратора";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnViewAssortiment);
            this.Controls.Add(this.btnMngWareHouse);
            this.Controls.Add(this.btnMngCustomers);
            this.Controls.Add(this.btnListUsers);
            this.Controls.Add(this.btnExit);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnMngCustomers;
        private System.Windows.Forms.Button btnMngWareHouse;
        private System.Windows.Forms.Button btnViewAssortiment;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Label lblAuth;
    }
}