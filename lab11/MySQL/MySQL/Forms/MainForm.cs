using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DBConnection = MySQL.Classes.DBConnection;

namespace MySQL
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        // Соединение с БД
        private void MainForm_Load(object sender, EventArgs e)
        {
            if(!DBConnection.Connect())
            {
                this.Close();
            }
        }

        // Разрыв соедения с БД при закрытии формы
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConnection.Close();
        }

        //Отображение меню в зависимости от роли пользователя
        private void btnAuth_Click(object sender, EventArgs e)
        {
            DBConnection.Authorization(inputLogin.Text, inputPass.Text);

            try
            {
                switch(DBConnection.Role)
                {
                    case "Customer":
                        Hide();
                        CustomerMenu customerMenu = new CustomerMenu();
                        customerMenu.Show();
                        break;
                    case "Admin":
                        Hide();
                        AdminMenu adminMenu = new AdminMenu(this, DBConnection.Role, DBConnection.User);
                        adminMenu.Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка авторизации");
            }
        }
    }
}
