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
    public partial class Empolees : Form
    {
        public Empolees()
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

                // Получаем ID пользователя из базы данных
                int userID = GetUserID(username, password);

                // Передаем ID пользователя на форму HomeEmployees и отображаем его в label
                HomeEmployees frm1 = new HomeEmployees(userID);
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        private int GetUserID(string username, string password)
        {
            int userID = 0; // Предположим, что ID пользователя представлен целым числом

            using (SqlConnection connection = Databasehelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT userID FROM Users WHERE login = @login AND password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", username);
                command.Parameters.AddWithValue("@password", password);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    userID = Convert.ToInt32(result);
                }
            }

            return userID;
        }


        private bool IsValidUser(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM [Users] WHERE login = @login AND password = @password AND type = 'Заказчик'";


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
