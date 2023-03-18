using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB
{
    public partial class Main : Form
    {
        SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=Examen;Trusted_Connection=true");
        
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            connection.Open();
            load_data();
        }

        private void load_data()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT*FROM [User]", connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [User](Id, Name, Address, Phone) " +
                $"VALUES ('{id_txt.Text}', '{name_txt.Text}', '{ad_txt.Text}', '{tel_txt.Text}')", connection);
            command.ExecuteNonQuery();
            load_data();
            clear_fun();
            MessageBox.Show("saved");
        }

        private void clear_fun()
        {
            id_txt.Text = "";
            name_txt.Text = "";
            ad_txt.Text = "";
            tel_txt.Text = "";
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear_fun();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"UPDATE [User] SET Name='{name_txt.Text}', Address='{ad_txt.Text}', Phone='{tel_txt.Text}'" +
                $"WHERE Id='{id_txt.Text}'", connection);
            command.ExecuteNonQuery();
            load_data();
            clear_fun();
            MessageBox.Show("Updated");
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM [User] WHERE Id='{id_txt.Text}'", connection);
            command.ExecuteNonQuery();
            load_data();
            clear_fun();
            MessageBox.Show("Deleted");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Num = dataGridView1.CurrentCell.RowIndex;
            id_txt.Text = dataGridView1.Rows[Num].Cells[0].Value.ToString();
            name_txt.Text = dataGridView1.Rows[Num].Cells[1].Value.ToString();
            ad_txt.Text = dataGridView1.Rows[Num].Cells[2].Value.ToString();
            tel_txt.Text = dataGridView1.Rows[Num].Cells[3].Value.ToString();
        }
    }
}
