using MySql.Data.MySqlClient;
using System;
using System.Data;
using static MySQL.MainForm;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace MySQL.Classes
{
    internal class DBConnection
    {
        static string connectionString = @"Database = murmanryb; Data Source = localhost; UserID = root; Password = admin";
        static MySqlConnection msConnect;
        static MySqlCommand msCommand;
        static public MySqlDataAdapter msDataAdapter;
        static public string User;
        static public string Role;
        static public string PasswordHash;
        static public DataTable dtUsers = new DataTable();
        static public DataTable dtCustomers = new DataTable();
        static public DataTable dtWhProductsCount = new DataTable();
        static public DataTable dtDetailsProduct = new DataTable();
        static public MySqlDataReader msDataReader = null;


        // Подключение к БД
        static public bool Connect()
        {
            try
            {
                msConnect = new MySqlConnection(connectionString);
                msConnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = msConnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }
        }

        // Закрытие соединения
        static public void Close()
        {
            msConnect.Close();
        }


        // Авторизация аккаунта
        static public void Authorization(string login, string password)
        {
            try
            {
                string sql = $"SELECT Role, Password FROM users WHERE Login = '{login}'";

                msCommand = new MySqlCommand(sql, msConnect);

                using (MySqlDataReader msDataReader = msCommand.ExecuteReader())
                {
                    if (msDataReader.HasRows)
                    {
                        User = login;
                        while (msDataReader.Read())
                        {
                            Role = msDataReader["Role"].ToString();
                            PasswordHash = msDataReader["Password"].ToString();
                        }
                        if (!PasswordHasher.VerifyPassword(password, PasswordHash))
                            throw new Exception("Неверный пароль");
                    }
                    else
                    {
                        Role = null;
                        throw new Exception("Неверные данные");
                    }
                }
            }
            catch (Exception ex)
            {
                Role = User = null;
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }


        // Полуучение всех пользователей
        static public void GetUserList(string selectedRole = null)
        {
            if (selectedRole == null)
                msCommand.CommandText = "SELECT * FROM users";
            else
            {
                msCommand.CommandText = $"SELECT * FROM users WHERE users.Role = '{selectedRole}'";
            }
            dtUsers.Clear();
            msDataAdapter.SelectCommand = msCommand;
            msDataAdapter.Fill(dtUsers);
        }


        // Получение заказчиков
        static public void GetCustomerList()
        {
            msCommand.CommandText = $"SELECT * FROM customers";
            dtCustomers.Clear();
            msDataAdapter.SelectCommand = msCommand;
            msDataAdapter.Fill(dtCustomers);
        }


        // Добавление нового пользователя
        static public void AddUser(string login, string password, string role)
        {
            var passwordHash = PasswordHasher.HashPassword(password);
            msCommand.CommandText = $"INSERT INTO users " +
                                    $"VALUES('{login}', '{passwordHash}', '{role}')";

            msCommand.ExecuteNonQuery();
        }


        // Добавление заказчика
        static public void AddCustomer(string user, string name, string phone, string address, string email = null)
        {
            msCommand.CommandText = $"INSERT INTO customers " +
                                    $"VALUES ('{user}', '{name}', '{phone}', '{email}', '{address}')";

            msCommand.ExecuteNonQuery();
        }


        // Редактирование заказчика
        static public void EditCustomer(string user, string name, string phone, string address, string email = null)
        {
            msCommand.CommandText = $"UPDATE customers " +
                                    $"SET Name = '{name}', Phone = '{phone}', Email = '{email}', Address = '{address}'" +
                                    $"WHERE User = '{user}'";

            msCommand.ExecuteNonQuery();
        }


        // Удаление заказчика
        static public void DeleteCustomer(string user)
        {
            msCommand.CommandText = $"DELETE FROM customers WHERE User = '{user}'";
            msCommand.ExecuteNonQuery();
        }


        // Выбираем данные из БД по определенному столбцу и значению 
        static public void SelectCustomers(string nameColumn, string valueColumn)
        {
            msCommand.CommandText = $"SELECT * FROM customers WHERE {nameColumn} = '{valueColumn}'";
            dtCustomers.Clear();
            msDataAdapter.SelectCommand = msCommand;
            msDataAdapter.Fill(dtCustomers);
        }


        // Получение количества продуктов
        static public void GetCountProducts()
        {
            msCommand.CommandText = "SELECT assortiment.Product, assortiment.Name, SUM(store.Count) AS Count " +
                                    "FROM assortiment " +
                                    "INNER JOIN store USING(Product) " +
                                    "WHERE Count > 0 " +
                                    "GROUP BY Product;";
            dtWhProductsCount.Clear();
            msDataAdapter.SelectCommand = msCommand;
            msDataAdapter.Fill(dtWhProductsCount);
        }


        // Получить детальную информацию о продукте
        static public void GetDetailsProduct(string product)
        {
            msCommand.CommandText = $"SELECT store.Date, store.Count " +
                                    $"FROM assortiment " +
                                    $"INNER JOIN store USING (Product) " +
                                    $"WHERE Product = '{product}';";
            dtDetailsProduct.Clear();
            msDataAdapter.SelectCommand = msCommand;
            msDataAdapter.Fill(dtDetailsProduct);
        }


        // Получить продукты в ассортименте 
        static public List<string> GetProducts()
        {
            DataTable products = new DataTable();
            List<string> res = new List<string>();

            msCommand.CommandText = $"SELECT Name FROM assortiment";
            msDataAdapter.SelectCommand = msCommand;
            msDataAdapter.Fill(products);

            foreach (DataRow row in products.Rows)
                foreach (object cell in row.ItemArray)
                    res.Add(cell.ToString());
            return res;

        }


        // Получить продукты по категории
        static public void GetProductsByCategory(int indCategory)
        {
            msCommand.CommandText = $"SELECT assortiment.Product, assortiment.Name, SUM(store.Count) AS Count " +
                                    $"FROM assortiment " +
                                    $"INNER JOIN store USING(Product) " +
                                    $"WHERE Count > 0 AND assortiment.Category = {indCategory + 1} " +
                                    $"GROUP BY Product;";
            dtWhProductsCount.Clear();
            msDataAdapter.SelectCommand = msCommand;
            msDataAdapter.Fill(dtWhProductsCount);
        }


        // Добавить новую поставку
        static public void AddSupply(int indProduct, int count, string date)
        {
            msCommand.CommandText = $"INSERT INTO store (Product, Count, Date) " +
                $"VALUES('{indProduct+1}', '{count}', '{date}')";
            msCommand.ExecuteNonQuery();
        }


        // Получить категории
        static public List<string> GetCategories()
        {   
            DataTable categories = new DataTable();
            List<string> res = new List<string>();
            msCommand.CommandText = "SELECT Description FROM categories;";
            msDataAdapter.SelectCommand = msCommand;
            msDataAdapter.Fill(categories);

            foreach (DataRow row in  categories.Rows)
                foreach (object cell in row.ItemArray)
                    res.Add(cell.ToString());
            return res;
        }
    }
}
