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

namespace Privateads
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private SqlConnection connection = new SqlConnection("Data Source=MAKISOLERA\\SQLEXPRESS; Initial Catalog=ADS; Integrated Security=True;");

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aDSDataSet.ADSPR". При необходимости она может быть перемещена или удалена.
            this.aDSPRTableAdapter.Fill(this.aDSDataSet.ADSPR);
        }
        private void load_data()
        {
            // Предполагается, что у вас есть аналогичный метод для загрузки данных, используя подключение.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                adsDataSet1.Tables["Название"]?.Clear();

                string sql = "SELECT * FROM ADSPR WHERE название_объявления LIKE @name";
                string name = $"%{textBox1.Text}%";

                using (var dataAdapter = new SqlDataAdapter(sql, connection))
                {
                    dataAdapter.SelectCommand.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
                    dataAdapter.Fill(adsDataSet1, "Пловцы");
                }

                dataGridView1.DataSource = adsDataSet1.Tables["Пловцы"];
            }
            else
            {
                load_data();
            }
        }
    }
}
