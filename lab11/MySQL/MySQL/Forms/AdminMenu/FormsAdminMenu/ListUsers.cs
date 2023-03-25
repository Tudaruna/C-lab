using MySQL.Forms.AdminMenu.FormsAdminMenu.ActionUser;
using System;
using System.Windows.Forms;
using DBConnection = MySQL.Classes.DBConnection;

namespace MySQL
{
    public partial class ListUsers : Form
    {
        private AdminMenu adminMenu;

        public ListUsers()
        {
            InitializeComponent();
        }

        public ListUsers(AdminMenu adminMenu)
        {
            InitializeComponent();
            this.adminMenu = adminMenu;
        }

        private void btnExitListUsers_Click(object sender, EventArgs e)
        {
            adminMenu.Show();
            Hide();
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            DBConnection.GetUserList(null);
            dataGridView.DataSource = DBConnection.dtUsers;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DBConnection.GetUserList(null);
            dataGridView.DataSource = DBConnection.dtUsers;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DBConnection.GetUserList("Customer");
            dataGridView.DataSource = DBConnection.dtUsers;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DBConnection.GetUserList("Admin");
            dataGridView.DataSource = DBConnection.dtUsers;
        }

        private void btnOpenAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(this);
            addUser.Show();
            Hide();
        }
    }
}
