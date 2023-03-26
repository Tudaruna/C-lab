namespace MySQL
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.inputPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAuth = new System.Windows.Forms.Label();
            this.btnAuth = new System.Windows.Forms.Button();
            this.picVisiblePass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVisiblePass)).BeginInit();
            this.SuspendLayout();
            // 
            // inputLogin
            // 
            this.inputLogin.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLogin.Location = new System.Drawing.Point(137, 124);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(198, 23);
            this.inputLogin.TabIndex = 0;
            // 
            // inputPass
            // 
            this.inputPass.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPass.Location = new System.Drawing.Point(137, 207);
            this.inputPass.Name = "inputPass";
            this.inputPass.PasswordChar = '*';
            this.inputPass.Size = new System.Drawing.Size(198, 23);
            this.inputPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(134, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(134, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("Montserrat ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuth.Location = new System.Drawing.Point(130, 22);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(213, 37);
            this.lblAuth.TabIndex = 4;
            this.lblAuth.Text = "Авторизация";
            // 
            // btnAuth
            // 
            this.btnAuth.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuth.Location = new System.Drawing.Point(137, 272);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(198, 27);
            this.btnAuth.TabIndex = 5;
            this.btnAuth.Text = "Войти";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // picVisiblePass
            // 
            this.picVisiblePass.BackColor = System.Drawing.Color.White;
            this.picVisiblePass.Image = ((System.Drawing.Image)(resources.GetObject("picVisiblePass.Image")));
            this.picVisiblePass.Location = new System.Drawing.Point(306, 208);
            this.picVisiblePass.Name = "picVisiblePass";
            this.picVisiblePass.Size = new System.Drawing.Size(21, 21);
            this.picVisiblePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVisiblePass.TabIndex = 6;
            this.picVisiblePass.TabStop = false;
            this.picVisiblePass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picVisiblePass_MouseDown);
            this.picVisiblePass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picVisiblePass_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 384);
            this.Controls.Add(this.picVisiblePass);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputPass);
            this.Controls.Add(this.inputLogin);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVisiblePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.TextBox inputPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.PictureBox picVisiblePass;
    }
}

