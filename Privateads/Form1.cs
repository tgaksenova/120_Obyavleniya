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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Privateads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oplata = checkedListBox1.Text;
            string nameads = textBox4.Text;
            string sost = бу.Text;
            string kateg = Электроника.Text;
            string price = textBox3.Text;
            string dostavka = checkedListBox2.Text;
            string ads = textBox1.Text;

            // Получение id_категории из таблицы "Категории"
            int categoryId = GetCategoryId(kateg);

            // Если id_категории не найден, можно выполнить соответствующее действие (вызвать сообщение об ошибке, например)
            if (categoryId == -1)
            {
                MessageBox.Show("Категория не найдена");
                return;
            }

            // Вызов функции для сохранения данных в базе данных
            Privateads(oplata, nameads, sost, categoryId, price, dostavka, ads);
        }

        private int GetCategoryId(string categoryName)
        {
            string connectionString = "Data Source=MAKISOLERA\\SQLEXPRESS; Initial Catalog=ADS; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL-запрос для получения id_категории по названию категории
                string query = $"SELECT id FROM Категории WHERE категория = '{categoryName}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Выполнение SQL-запроса
                    object result = command.ExecuteScalar();

                    // Проверка на null и преобразование в int
                    if (result != null && int.TryParse(result.ToString(), out int categoryId))
                    {
                        return categoryId;
                    }
                }
            }

            // Если не удалось найти id_категории
            return -1;
        }

        private bool Privateads(string oplata, string nameads, string sost, int categoryId, string price, string dostavka, string ads)
        {
            string connectionString = "Data Source=MAKISOLERA\\SQLEXPRESS; Initial Catalog=ADS; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL-запрос для вставки данных в таблицу ADSPR с использованием id_категории
                string query = $"INSERT INTO ADSPR (id_категории, название_объявления, стоимость_товара, состояние_товара, описание, способ_оплаты, способ_доставки) VALUES ('{categoryId}', '{nameads}', '{price}', '{sost}', '{ads}', '{oplata}', '{dostavka}')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Выполнение SQL-запроса
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Регистрация успешна
                        MessageBox.Show("Объявление выставлено!");
                    }
                    else
                    {
                        // Ошибка при регистрации
                        MessageBox.Show("Ошибка при выставлении объявления");
                    }
                }
            }

            return true;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            Form2.Show();
            this.Close();
        }
    }
}
