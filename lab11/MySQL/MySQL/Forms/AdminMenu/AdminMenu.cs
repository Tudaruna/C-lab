using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL
{
    public partial class AdminMenu : Form
    {

        private MainForm mainForm;
        private string role;
        private string login;


        public AdminMenu()
        {
            InitializeComponent();
        }

        public AdminMenu(MainForm mainForm, string role, string login)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.role = role;
            this.login = login;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            mainForm.Show();
            login = null;
            role = null;
            Hide();
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            ListUsers listUsers = new ListUsers(this);
            listUsers.Show();
            Hide();
        }

        private void btnMngCustomers_Click(object sender, EventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement(this);
            customerManagement.Show();
            Hide();
        }
    }
}
