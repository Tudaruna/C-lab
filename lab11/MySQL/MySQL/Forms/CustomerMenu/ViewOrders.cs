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

namespace MySQL.Forms.CustomerMenu
{
    public partial class ViewOrders : Form
    {

        private MySQL.CustomerMenu customerMenu;
        private string user = DBConnection.User;

        public ViewOrders()
        {
            InitializeComponent();
        }

        public ViewOrders(MySQL.CustomerMenu customerMenu)
        {
            InitializeComponent();
            this.customerMenu = customerMenu;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            customerMenu.Show();
            Close();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            DBConnection.GetOrders();
            dataGridOrders.DataSource = DBConnection.dtOrders;
        }
    }
}
