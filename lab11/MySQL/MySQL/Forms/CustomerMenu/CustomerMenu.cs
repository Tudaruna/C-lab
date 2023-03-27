using MySQL.Classes;
using MySQL.Forms;
using MySQL.Forms.CustomerMenu;
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
    public partial class CustomerMenu : Form
    {

        private MainForm mainForm;

        public CustomerMenu()
        {
            InitializeComponent();
        }

        public CustomerMenu(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }

        private void btnViewAssortiment_Click(object sender, EventArgs e)
        {
            ViewAssortiment viewAssortiment = new ViewAssortiment(this);
            viewAssortiment.Show();
            Hide();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders(this);
            viewOrders.Show();
            Hide();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
        }
    }
}
