using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Privateads
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Вызов функции для сохранения данных в базу данных
                RegisterUser(username, password);
        }
        private void RegisterUser(string username, string password)
        {
            // Подключение к базе данных (используйте свои параметры подключения)
            string connectionString = "Data Source=MAKISOLERA\\SQLEXPRESS; Initial Catalog=ADS; Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL-запрос для вставки данных в таблицу пользователей
                string query = $"INSERT INTO RegisterUser (login, password) VALUES ('{username}', '{password}')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Выполнение SQL-запроса
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Регистрация успешна
                        MessageBox.Show("Регистрация успешна!");
                    }
                    else
                    {
                        // Ошибка при регистрации
                        MessageBox.Show("Ошибка при регистрации. Пожалуйста, повторите попытку.");
                    }
                }
            }
        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Window1 = new MainWindow();
            Window1.Show();
            this.Close();
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }
    }
}
