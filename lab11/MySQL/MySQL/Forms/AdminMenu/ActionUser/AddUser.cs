using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBConnection = MySQL.Classes.DBConnection;

namespace MySQL.Forms.AdminMenu.FormsAdminMenu.ActionUser
{
    public partial class AddUser : Form
    {
        private ListUsers ListUsers;
        private string role;

        public AddUser()
        {
            
            InitializeComponent();
        }

        public AddUser(ListUsers listUsers)
        {
            InitializeComponent();
            this.ListUsers = listUsers;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ListUsers.Show();
            Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputLogin.Text != "" && inputPassword.Text != "")
                {

                    switch (comboBoxRole.SelectedItem)
                    {
                        case "Администратор":
                            role = "Admin";
                            break;
                        case "Заказчик":
                            role = "Customer";
                            break;
                    }
                    DBConnection.AddUser(inputLogin.Text, inputPassword.Text, role);
                    MessageBox.Show("Пользователь создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inputLogin.Text = "";
                    inputPassword.Text = "";
                    if (role == "Customer")
                    {
                        if (MessageBox.Show("Перейти к заполнению информации заказчика?", "Уведомление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            AddCustomer addCustomer = new AddCustomer();
                            addCustomer.Show();
                            Close();
                        }
                    }
                }
                else
                {
                    throw new Exception("Поля не заполнены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            comboBoxRole.SelectedIndex = 0;
        }
    }
}
