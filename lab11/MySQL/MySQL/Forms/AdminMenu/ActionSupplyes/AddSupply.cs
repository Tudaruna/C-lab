using MySQL.Classes;
using MySQL.Forms.AdminMenu.FormsAdminMenu;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MySQL.Forms.AdminMenu.ActionSupplyes
{
    public partial class AddSupply : Form
    {

        private WarehouseManagement warehouseManagement;


        public AddSupply()
        {
            InitializeComponent();
        }

        public AddSupply(WarehouseManagement warehouseManagement)
        {
            InitializeComponent();
            this.warehouseManagement = warehouseManagement;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            warehouseManagement.Show();
            Close();
        }

        private void AddSupply_Load(object sender, EventArgs e)
        {
            List<string> res = DBConnection.GetProducts();
            foreach (string product in res)
                comBoxProduct.Items.Add(product);

            inputDate.CustomFormat = "yyyy-MM-dd hh:mm:00";
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            try
            {
               
                MessageBox.Show(inputDate.Text);
                DBConnection.AddSupply(comBoxProduct.SelectedIndex, Int32.Parse(inputCountProduct.Text), inputDate.Text);
                MessageBox.Show("Поставка добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                inputCountProduct.Text = "";
                inputDate.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
