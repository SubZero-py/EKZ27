using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condi
{
    public partial class HomeEmployees : Form
    {
        private int userID;
        public HomeEmployees(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            label1.Text = "Ваш ID: " + userID.ToString();
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ServiceRequests";

            using (SqlConnection connection = Databasehelper.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            panel_requ.Visible = true;
            panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Comments";

            using (SqlConnection connection = Databasehelper.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            panel_requ.Visible = false;
            panel3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Databasehelper.GetConnection();
            connection.Open();

            string searchQuery = "SELECT * FROM Comments WHERE commentID LIKE @searchText OR requestID LIKE @searchText OR masterID LIKE @searchText";
            SqlCommand command = new SqlCommand(searchQuery, connection);
            command.Parameters.AddWithValue("@searchText", "%" + textBox6.Text + "%");



            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


            connection.Close();
        }

        private void HomeEmployees_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ServiceRequests";

            using (SqlConnection connection = Databasehelper.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void button_search_requ_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Databasehelper.GetConnection();
            connection.Open();

            string searchQuery = "SELECT * FROM ServiceRequests WHERE clientID LIKE @searchText OR climateTechType LIKE @searchText OR startDate LIKE @searchText";
            SqlCommand command = new SqlCommand(searchQuery, connection);
            command.Parameters.AddWithValue("@searchText", "%" + textBox_requ.Text + "%");



            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


            connection.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Form1 AH = new Form1();
            this.Close();
            AH.Show();
        }
    }
}
