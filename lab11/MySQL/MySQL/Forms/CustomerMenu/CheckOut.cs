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
    public partial class CheckOut : Form
    {
        private ViewOrders viewOrders;

        public CheckOut()
        {
            InitializeComponent();
        }

        public CheckOut(ViewOrders viewOrders)
        {
            InitializeComponent();
            this.viewOrders = viewOrders;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            DBConnection.GetProductsFromStore();
            foreach (DataRow dataRow in DBConnection.dtProductsFromStore.Rows)
                foreach(object cell in dataRow.ItemArray)
                    comBoxProducts.Items.Add(cell);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            viewOrders.Show();
            Close();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string res = DBConnection.GetPositionIDFromStoreByProduct(comBoxProducts.SelectedItem.ToString());
            DBConnection.CheckOut(Int32.Parse(res), Int32.Parse(inputCountProduct.Text));
        }
    }
}
