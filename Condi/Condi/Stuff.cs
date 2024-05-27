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

namespace Condi
{
    public partial class Stuff : Form
    {
        public Stuff()
        {
            InitializeComponent();
        }

        private void back_to_home_lable_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 home = new Form1();
            home.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = email_input.Text;
            string password = password_input.Text;


            if (IsValidUser(username, password))
            {
                MessageBox.Show("Успешно авторизовались!");
                this.Hide();
                HomeStuff frm1 = new HomeStuff();
                frm1.Show();


            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private bool IsValidUser(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM [Users] WHERE login = @login AND password = @password AND (type = 'Специалист' OR type = 'Оператор' OR type = 'Менеджер')";



            using (SqlConnection connection = Databasehelper.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", username);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return (count == 1);


            }

        }
    }
}
