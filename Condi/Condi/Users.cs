using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Condi
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void add_doc_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Databasehelper.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Users (userID ,fio, phone, login, password, type) VALUES (@userID, @fio, @phone, @login, @password, @type)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@userID", textBox1.Text);
                command.Parameters.AddWithValue("@fio", textBox2.Text);
                command.Parameters.AddWithValue("@phone", textBox3.Text);
                command.Parameters.AddWithValue("@login", textBox4.Text);
                command.Parameters.AddWithValue("@password", textBox5.Text);
                command.Parameters.AddWithValue("@type", comboBox1.SelectedItem.ToString());

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show(rowsAffected + " строка добавлена.");

            }
        }

        private void update_doc_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Databasehelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE [Users] SET fio = @fio, phone = @phone, login = @login, password = @password, type = @type WHERE userID = @userID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@userID", textBox1.Text);
                command.Parameters.AddWithValue("@fio", textBox2.Text);
                command.Parameters.AddWithValue("@phone", textBox3.Text);
                command.Parameters.AddWithValue("@login", textBox4.Text);
                command.Parameters.AddWithValue("@password", textBox5.Text);
                command.Parameters.AddWithValue("@type", comboBox1.SelectedItem.ToString());

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show(rowsAffected + " строка обновлена.");
            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Databasehelper.GetConnection())
            {
                connection.Open();



                string deleteBooksQuery = "DELETE FROM Users WHERE userID = @userID";
                using (SqlCommand command = new SqlCommand(deleteBooksQuery, connection))
                {
                    command.Parameters.AddWithValue("@userID", textBox1.Text);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Строка удалена в таблице Пользователи");

            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedItem = null;
            add_doc_btn.Enabled = true;
            update_doc_btn.Enabled = false;
            delete_btn.Enabled = false;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            update_doc_btn.Enabled = false;
            delete_btn.Enabled = false;
            string query = "SELECT * FROM Users";

            using (SqlConnection connection = Databasehelper.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }
        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            update_doc_btn.Enabled = true;
            delete_btn.Enabled = true;

            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
            textBox3.Text = selectedRow.Cells[2].Value.ToString();
            textBox4.Text = selectedRow.Cells[3].Value.ToString();
            textBox5.Text = selectedRow.Cells[4].Value.ToString();
            comboBox1.Text = selectedRow.Cells[5].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            SqlConnection connection = Databasehelper.GetConnection();
            connection.Open();

            string searchQuery = "SELECT * FROM Users WHERE fio LIKE @searchText OR phone LIKE @searchText OR type LIKE @searchText";
            SqlCommand command = new SqlCommand(searchQuery, connection);
            command.Parameters.AddWithValue("@searchText", "%" + textBox6.Text + "%");


          
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        
            connection.Close();
        }
    }
}
