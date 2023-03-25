using MySql.Data.MySqlClient;
using System;
using System.Data;
using static MySQL.MainForm;
using System.Windows.Forms;

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
        static public MySqlDataReader msDataReader = null;


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
                        {
                            throw new Exception("Неверный пароль");
                        }
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

        //
        static public void AddCustomer(string user, string name, string phone, string address, string email = null)
        {
            msCommand.CommandText = $"INSERT INTO customers " +
                                    $"VALUES ('{user}', '{name}', '{phone}', '{email}', '{address}')";

            msCommand.ExecuteNonQuery();
        }

        static public void EditCustomer(string user, string name, string phone, string address, string email = null)
        {
            msCommand.CommandText = $"UPDATE customers " +
                                    $"SET Name = '{name}', Phone = '{phone}', Email = '{email}', Address = '{address}'" +
                                    $"WHERE User = '{user}'";

            msCommand.ExecuteNonQuery();
        }
    }
}
