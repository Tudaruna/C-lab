using MySql.Data.MySqlClient;
using System;
using System.Data;
using static MySQL.MainForm;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Security.Cryptography;

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
        static public DataTable dtWriteOff = new DataTable();
        static public DataTable dtAssortiment = new DataTable();
        static public DataTable dtSalesForAdmin = new DataTable();
        static public DataTable dtOrders = new DataTable();
        static public DataTable dtProductsFromStore = new DataTable();
        static public DataTable dtPositionIDFromStore = new DataTable();
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


        // Списание просроченных товаров
        static public int WriteOff()
        {
            msCommand.CommandText = $"SELECT store.PositionID, store.Product, store.Count, store.Date, assortiment.Shelflife " +
                                    $"FROM store " +
                                    $"INNER JOIN assortiment USING(Product) " +
                                    $"WHERE To_DAYS(CURDATE())-TO_DAYS(store.Date) >= assortiment.Shelflife;";

            dtWriteOff.Clear();
            msDataAdapter.SelectCommand = msCommand;
            msDataAdapter.Fill(dtWriteOff);

            foreach(DataRow row in dtWriteOff.Rows)
            {
                DateTime date = new DateTime();
                date = (DateTime)row[3];

                msCommand.CommandText = $"INSERT INTO write_off (Product, Count, Date, DateOff)" +
                                        $"VALUES ('{row[1]}', '{row[2]}', '{date.ToString("yyyy-MM-dd")}', '{DateTime.Today.ToString("yyyy-MM-dd")}');";
                msCommand.ExecuteNonQuery();
                MessageBox.Show("ntcn");
                msCommand.CommandText = $"DELETE FROM store WHERE PositionID = {row[0]};";
                msCommand.ExecuteNonQuery();
            }
            return dtWriteOff.Rows.Count;
        }


        // Получить ассортимент
        static public void GetAssrotiment()
        {
            msCommand.CommandText = $"SELECT * FROM assortiment;";

            msDataAdapter.SelectCommand = msCommand;
            dtAssortiment.Clear();
            msDataAdapter.Fill(dtAssortiment);
        }


        // Получить все продажи
        static public void GetSalesForAdmin()
        {
            msCommand.CommandText = $"SELECT sales.Customer, sales.Date, assortiment.Name, positionsinsale.Count " +
                                    $"FROM sales " +
                                    $"INNER JOIN positionsinsale ON positionsinsale.Sale = sales.SaleID " +
                                    $"INNER JOIN store ON positionsinsale.Product = store.PositionID " +
                                    $"INNER JOIN assortiment ON store.Product = assortiment.Product;";
            msDataAdapter.SelectCommand = msCommand;
            dtSalesForAdmin.Clear();
            msDataAdapter.Fill(dtSalesForAdmin);
        }


        // Получение заказов определенного пользователя
        static public void GetOrders()
        {
            msCommand.CommandText = $"SELECT sales.Date, assortiment.Name, positionsinsale.Count " +
                                    $"FROM sales " +
                                    $"INNER JOIN positionsinsale ON positionsinsale.Sale = sales.SaleID " +
                                    $"INNER JOIN store ON positionsinsale.Product = store.PositionID " +
                                    $"INNER JOIN assortiment ON store.Product = assortiment.Product " +
                                    $"WHERE sales.Customer = '{User}';";
            msDataAdapter.SelectCommand = msCommand;
            dtOrders.Clear();
            msDataAdapter.Fill(dtOrders);
        }

        
        // Оформить заказ
        static public void CheckOut(int productID, int count)
        {
            msCommand.CommandText = $"INSERT INTO sales (Customer, Date) " +
                                    $"VALUES ('{User}', '{DateTime.Now.ToString("yyyy-MM-dd")}')";
            msCommand.ExecuteNonQuery();

            msCommand.CommandText = $"SELECT MAX(SaleID) FROM sales";
            object res = msCommand.ExecuteScalar();
            int indSale = Int32.Parse(res.ToString());

            msCommand.CommandText = $"INSERT INTO positionsinsale " +
                                    $"VALUES ({indSale}, {productID}, {count});";
            msCommand.ExecuteNonQuery();

            msCommand.CommandText = $"UPDATE store " +
                                    $"SET Count = Count - {count} " +
                                    $"WHERE PositionID = {productID};";
            msCommand.ExecuteNonQuery();
        }

        // Добавить функцию которая выбирает продукты для comboBox в форме CheckOut из таблицы store в БД

        static public void GetProductsFromStore()
        {
            msCommand.CommandText = $"SELECT DISTINCT assortiment.Name FROM store " +
                                    $"INNER JOIN assortiment USING(Product);";
            msDataAdapter.SelectCommand = msCommand;
            dtProductsFromStore.Clear();
            msDataAdapter.Fill(dtProductsFromStore);
        }


        //
        static public string GetPositionIDFromStoreByProduct(string nameProduct)
        {
            msCommand.CommandText = $"SELECT PositionID " +
                                    $"FROM store " +
                                    $"WHERE Product = " +
                                        $"(SELECT Product " +
                                        $"FROM assortiment " +
                                        $"WHERE Name = '{nameProduct}');";
            object res = msCommand.ExecuteScalar();
            return res.ToString();


        }
    }
}
