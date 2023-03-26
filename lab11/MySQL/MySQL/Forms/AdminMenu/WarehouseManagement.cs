using MySQL.Forms.AdminMenu.ActionSupplyes;
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

namespace MySQL.Forms.AdminMenu.FormsAdminMenu
{
    public partial class WarehouseManagement : Form
    {
        private MySQL.AdminMenu adminMenu;

        public WarehouseManagement()
        {
            InitializeComponent();
        }

        public WarehouseManagement(MySQL.AdminMenu adminMenu)
        {
            InitializeComponent();
            this.adminMenu = adminMenu;
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {
            DBConnection.GetCountProducts();
            dataGridCountProducts.DataSource = DBConnection.dtWhProductsCount;
            List<string> categories = DBConnection.GetCategories();
            foreach (string category in categories)
                comboBoxSortProducts.Items.Add(category);
            comboBoxSortProducts.Items.Add("Все категории");
            
        }

        private void dataGridCountProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DBConnection.GetDetailsProduct(dataGridCountProducts.CurrentRow.Cells[0].Value.ToString());
            dataGridDetailsProduct.DataSource = DBConnection.dtDetailsProduct;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            adminMenu.Show();
            Close();
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            AddSupply addSupply = new AddSupply(this);
            addSupply.Show();
            Hide();
        }

        private void comboBoxSortProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection.GetProductsByCategory(comboBoxSortProducts.SelectedIndex);
        }

        private void btnResetSort_Click(object sender, EventArgs e)
        {
            comboBoxSortProducts.SelectedIndex = comboBoxSortProducts.Items.Count - 1;
            DBConnection.GetCountProducts();
            dataGridCountProducts.DataSource = DBConnection.dtWhProductsCount;
        }
    }
}
