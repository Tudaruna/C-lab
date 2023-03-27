using MySQL.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL.Forms.AdminMenu
{
    public partial class ViewSales : Form
    {
        private MySQL.AdminMenu adminMenu;

        public ViewSales()
        {
            InitializeComponent();
        }

        public ViewSales(MySQL.AdminMenu adminMenu)
        {
            InitializeComponent();
            this.adminMenu = adminMenu;
        }

        

        private void ViewSales_Load(object sender, EventArgs e)
        {
            DBConnection.GetSalesForAdmin();
            dataGridSales.DataSource = DBConnection.dtSalesForAdmin;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            adminMenu.Show();
            Close();
        }
    }
}
