﻿namespace MySQL.Forms.AdminMenu.FormsAdminMenu
{
    partial class EditCustomer
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
            this.inputPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.inputUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputPhone
            // 
            this.inputPhone.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPhone.Location = new System.Drawing.Point(66, 268);
            this.inputPhone.Mask = "+7(999)-999-99-99";
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.Size = new System.Drawing.Size(181, 23);
            this.inputPhone.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(322, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(322, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Email";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(322, 103);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(181, 20);
            this.inputEmail.TabIndex = 30;
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(322, 187);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(181, 20);
            this.inputAddress.TabIndex = 29;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditCustomer.Location = new System.Drawing.Point(191, 329);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(181, 52);
            this.btnEditCustomer.TabIndex = 28;
            this.btnEditCustomer.Text = "Изменить данные заказчика";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // inputUser
            // 
            this.inputUser.Enabled = false;
            this.inputUser.Location = new System.Drawing.Point(66, 103);
            this.inputUser.Name = "inputUser";
            this.inputUser.Size = new System.Drawing.Size(181, 20);
            this.inputUser.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(66, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(66, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Пользователь";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(191, 410);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(181, 27);
            this.Exit.TabIndex = 22;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(67, 187);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(180, 20);
            this.inputName.TabIndex = 27;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 513);
            this.Controls.Add(this.inputPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.inputAddress);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.inputUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.inputName);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox inputPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.TextBox inputAddress;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.TextBox inputUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox inputName;
    }
}