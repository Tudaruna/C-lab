using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DBConnection = MySQL.Classes.DBConnection;

namespace MySQL.Forms.AdminMenu.FormsAdminMenu
{
    public partial class AddCustomer : Form
    {
        private CustomerManagement CustomerManagement;

        public AddCustomer()
        {
            this.CustomerManagement = new CustomerManagement();
            InitializeComponent();
        }

        public AddCustomer(CustomerManagement customerManagement)
        {
            InitializeComponent();
            this.CustomerManagement = customerManagement;
            FormBorderStyle = FormBorderStyle.None;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            CustomerManagement.Show();
            Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string phone = Regex.Replace(inputPhone.Text, @"[^\d]", ""); //даем строку phone, задаем регулярное выражение,если символ не число, то заменяем символ на пустоту

            if (inputUser.Text != "" && inputName.Text != "" && phone.Length == 11 && inputAddress.Text != "")
            {
                DBConnection.AddCustomer(inputUser.Text, inputName.Text, phone, inputAddress.Text, inputEmail.Text);
                MessageBox.Show("Создание заказчика");
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            inputEmail.Text = null;
        }
    }
}
