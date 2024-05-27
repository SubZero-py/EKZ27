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
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void add_doc_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Databasehelper.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO ServiceRequests (requestID ,startDate, climateTechType, climateTechModel, problemDescription, requestStatus, completionDate, repairParts, masterID, clientID) VALUES (@requestID, @startDate, @climateTechType, @climateTechModel, @problemDescription, @requestStatus, @completionDate, @repairParts, @masterID, @clientID)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@requestID", textBox1.Text);
                command.Parameters.AddWithValue("@startDate", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@climateTechType", textBox2.Text);
                command.Parameters.AddWithValue("@climateTechModel", textBox3.Text);
                command.Parameters.AddWithValue("@problemDescription", textBox4.Text);
                command.Parameters.AddWithValue("@requestStatus", comboBox1.SelectedItem.ToString());
                command.Parameters.AddWithValue("@completionDate", dateTimePicker2.Value);
                command.Parameters.AddWithValue("@repairParts", textBox5.Text);
                command.Parameters.AddWithValue("@masterID", textBox6.Text);
                command.Parameters.AddWithValue("@clientID", textBox7.Text);

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show(rowsAffected + " строка добавлена.");

            }
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            update_doc_btn.Enabled = false;
            delete_btn.Enabled = false;
            string query = "SELECT * FROM ServiceRequests";

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
            dateTimePicker1.Value = DateTime.Parse(selectedRow.Cells[1].Value.ToString());
            textBox2.Text = selectedRow.Cells[2].Value.ToString();
            textBox3.Text = selectedRow.Cells[3].Value.ToString();
            textBox4.Text = selectedRow.Cells[4].Value.ToString();
            comboBox1.Text = selectedRow.Cells[5].Value.ToString();
            dateTimePicker2.Value = DateTime.Parse(selectedRow.Cells[6].Value.ToString());
            textBox5.Text = selectedRow.Cells[7].Value.ToString();
            textBox6.Text = selectedRow.Cells[8].Value.ToString();
            textBox7.Text = selectedRow.Cells[9].Value.ToString();


        }

        private void update_doc_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Databasehelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE ServiceRequests SET startDate = @startDate, climateTechType = @climateTechType, climateTechModel = @climateTechModel, problemDescription = @problemDescription, requestStatus = @requestStatus, completionDate = @completionDate, repairParts = @repairParts, masterID = @masterID, clientID = @clientID WHERE requestID = @requestID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@requestID", textBox1.Text);
                command.Parameters.AddWithValue("@startDate", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@climateTechType", textBox2.Text);
                command.Parameters.AddWithValue("@climateTechModel", textBox3.Text);
                command.Parameters.AddWithValue("@problemDescription", textBox4.Text);
                command.Parameters.AddWithValue("@requestStatus", comboBox1.SelectedItem.ToString());
                command.Parameters.AddWithValue("@completionDate", dateTimePicker2.Value);
                command.Parameters.AddWithValue("@repairParts", textBox5.Text);
                command.Parameters.AddWithValue("@masterID", textBox6.Text);
                command.Parameters.AddWithValue("@clientID", textBox7.Text);

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show(rowsAffected + " строка обновлена.");
            }

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.SelectedItem = null;
            add_doc_btn.Enabled = true;
            update_doc_btn.Enabled = false;
            delete_btn.Enabled = false;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Databasehelper.GetConnection())
            {
                connection.Open();



                string deleteBooksQuery = "DELETE FROM ServiceRequests WHERE requestID = @requestID";
                using (SqlCommand command = new SqlCommand(deleteBooksQuery, connection))
                {
                    command.Parameters.AddWithValue("@requestID", textBox1.Text);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Строка удалена в таблице Заявки");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = Databasehelper.GetConnection();
            connection.Open();

            string searchQuery = "SELECT * FROM ServiceRequests WHERE clientID LIKE @searchText OR climateTechType LIKE @searchText OR startDate LIKE @searchText";
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
