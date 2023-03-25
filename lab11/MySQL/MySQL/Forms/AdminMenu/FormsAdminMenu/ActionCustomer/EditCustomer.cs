using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DBConnection = MySQL.Classes.DBConnection;

namespace MySQL.Forms.AdminMenu.FormsAdminMenu
{
    public partial class EditCustomer : Form
    {
        private CustomerManagement customerManagement;
        private string[] data;

        public EditCustomer()
        {
            InitializeComponent();
        }

        public EditCustomer(CustomerManagement customerManagement, string[] data)
        {
            InitializeComponent();
            this.customerManagement = customerManagement;
            this.data = data;
        }


        // Декомпозиция данных из БД
        private (string, string, string, string, string) DecomposeData(string[] data)
        {
            return (data[0], data[1], data[2], data[3], data[4]);
        }



        // Декомпозиция данных выбранных из dataGridView
        private void EditCustomer_Load(object sender, EventArgs e)
        {
            (inputUser.Text, inputName.Text, inputPhone.Text, inputEmail.Text, inputAddress.Text) = DecomposeData(data);
        }


        // Сохранение измененных данных в БД
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            string phone = Regex.Replace(inputPhone.Text, @"[^\d]", "");
            DBConnection.EditCustomer(inputUser.Text, inputName.Text, phone, inputAddress.Text, inputEmail.Text);
        }


        // Переход на форму управления заказчиками
        private void Exit_Click(object sender, EventArgs e)
        {
            customerManagement.Show();
            Hide();
        }
    }
}
