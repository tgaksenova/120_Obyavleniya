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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Privateads
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new Window1();
            mainWindow.Show();
            this.Close();
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Проверка учетных данных в базе данных
            if (AvtorUser(username, password))
            {
                // Успешная аутентификация
                MessageBox.Show("Успешная аутентификация!");
                var form1 = new Form1();
                form1.Show();
            }
            else
            {
                // Неверные учетные данные
                MessageBox.Show("Неверные учетные данные!");
            }
        }
        private bool AvtorUser(string username, string password)
        {
            // Подключение к базе данных (используйте свои параметры подключения)
            string connectionString = "Data Source=MAKISOLERA\\SQLEXPRESS; Initial Catalog=ADS; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL-запрос для проверки учетных данных в базе данных
                string query = $"SELECT COUNT(*) FROM RegisterUser WHERE login = '{username}' AND password = '{password}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int userCount = (int)command.ExecuteScalar();

                    // Если найден пользователь с указанным логином и паролем
                    return userCount > 0;
                }
            }
        }
    }
}
