using MySQL.Forms.AdminMenu.FormsAdminMenu;
using System;
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

        
        // Подгрузка данных из БД при загрузке формы
        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            DBConnection.GetCustomerList();
            dataGridView.DataSource = DBConnection.dtCustomers;
        }


        // Переход на меню администратора
        private void Exit_Click(object sender, EventArgs e)
        {
            adminMenu.Show();
            Hide();
        }


        // Открыть форму добавить нового пользователя
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(this);
            addCustomer.Show();
            Hide();
        }


        // Открыть форму редактирования заказчика
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count != 1)
                {
                    throw new Exception("Выберите 1 строку для редактирования заказчика");
                }
                string[] data = new string[dataGridView.Columns.Count];
                for (int  i = 0; i < dataGridView.Columns.Count; i++)
                {
                    data[i] = dataGridView.CurrentRow.Cells[i].Value.ToString();
                }
                EditCustomer editCustomer = new EditCustomer(this, data);
                editCustomer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
;            }
        }


        // Обновляем dataGridView
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = new object(); // очищаем dataGridView от данных
            DBConnection.GetCustomerList();
            dataGridView.DataSource = DBConnection.dtCustomers;
        }
    }
}
