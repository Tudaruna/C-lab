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

        private void UpdateDataGridView()
        {
            dataGridView.DataSource = new object(); // очищаем dataGridView от данных
            DBConnection.GetCustomerList();
            dataGridView.DataSource = DBConnection.dtCustomers;
        }


        // Получение полей с dataGridView
        private string[] pullData()
        {
            string[] data = new string[dataGridView.Columns.Count];
            for (int i = 0; i < dataGridView.Columns.Count; i++)
                data[i] = dataGridView.CurrentRow.Cells[i].Value.ToString();
            return data;
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
            Close();
        }


        // Обновляем dataGridView
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }


        // Открыть форму добавить нового пользователя
        private void btnOpenFormAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(this);
            addCustomer.Show();
            Hide();
        }


        // Открыть форму редактирования заказчика
        private void btnOpenFormEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count != 1)
                    throw new Exception("Выберите 1 строку для редактирования заказчика");
                string[] data = pullData();
                EditCustomer editCustomer = new EditCustomer(this, data);
                editCustomer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


        // Удалить выбранного заказчика
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count != 1)
                    throw new Exception("Выберите 1 строку для удаления заказчика");
                string[] data = pullData();
                DBConnection.DeleteCustomer(data[0]);
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExecQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputValue == null || inputValue.Text == "")
                    throw new Exception("Введите в поле значение которое будет использовано для запроса");

                switch (comboBox.SelectedItem)
                {
                    case null:
                        throw new Exception("Не выбран параметр в выпадающем списке");
                        break;
                    case "Пользователь":
                        DBConnection.SelectCustomers("User",inputValue.Text);
                        break;
                    case "Имя":
                        DBConnection.SelectCustomers("Name", inputValue.Text);
                        break;
                    case "Телефон":
                        DBConnection.SelectCustomers("Phone", inputValue.Text);
                        break;
                    case "Почта":
                        DBConnection.SelectCustomers("Email", inputValue.Text);
                        break;
                    case "Адрес":
                        DBConnection.SelectCustomers("Address", inputValue.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
