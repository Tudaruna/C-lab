using MySQL.Classes;
using System;
using System.Windows.Forms;

namespace MySQL.Forms
{
    public partial class ViewAssortiment : Form
    {
        private MySQL.AdminMenu adminMenu;
        private MySQL.CustomerMenu customerMenu;
        private bool isAdmin = true;

        public ViewAssortiment(MySQL.AdminMenu adminMenu)
        {
            InitializeComponent();
            this.adminMenu = adminMenu;
            this.isAdmin = true;
            FormBorderStyle = FormBorderStyle.None;
        }

        public ViewAssortiment(MySQL.CustomerMenu customerMenu)
        {
            InitializeComponent();
            this.customerMenu = customerMenu;
            this.isAdmin = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        public ViewAssortiment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                adminMenu.Show();
                Close();
            }
            else
            {
                customerMenu.Show();
                Close();
            }
        }

        private void ViewAssortiment_Load(object sender, EventArgs e)
        {
            DBConnection.GetAssrotiment();
            dataGridAssortiment.DataSource = DBConnection.dtAssortiment;
        }
    }
}
