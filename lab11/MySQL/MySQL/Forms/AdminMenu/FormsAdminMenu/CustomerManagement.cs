using MySQL.Forms.AdminMenu.FormsAdminMenu;
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

namespace MySQL
{
    public partial class CustomerManagement : Form
    {
        private AdminMenu adminMenu;

        public CustomerManagement()
        {
            InitializeComponent();
        }
        public CustomerManagement(AdminMenu adminMenu)
        {
            InitializeComponent();
            this.adminMenu = adminMenu;
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            DBConnection.GetCustomerList();
            dataGridView.DataSource = DBConnection.dtCustomers;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            adminMenu.Show();
            Hide();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(this);
            addCustomer.Show();
            Hide();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            EditCustomer editCustomer = new EditCustomer(this);
            editCustomer.Show();
        }
    }
}
