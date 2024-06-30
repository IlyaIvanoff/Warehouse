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

namespace WindowsFormsApp1
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void Search_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=Warehouse;Integrated Security=True;Encrypt=False";

            // SQL-запрос для выборки всех записей из таблицы "Склад".
            string query = "SELECT * FROM Склад";

            try
            {
                // Создаем соединение с базой данных.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Открываем соединение.
                    connection.Open();

                    // Создаем команду.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Выполняем команду и получаем данные.
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Отображаем данные в DataGridView.
                            dataGridViewWarehouse.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обрабатываем исключения и выводим сообщение об ошибке.
                MessageBox.Show("Произошла ошибка при выполнении запроса: " + ex.Message);
            }
        }

        private void CheckLess_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=Warehouse;Integrated Security=True;Encrypt=False";

            // SQL-запрос для выборки записей, у которых количество меньше 50.
            string query = "SELECT * FROM Склад WHERE Количество < 50";

            try
            {
                // Создаем соединение с базой данных.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Открываем соединение.
                    connection.Open();

                    // Создаем команду.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Выполняем команду и получаем данные.
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Создаем DataTable для хранения данных.
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            // Отображаем данные в DataGridView.
                            dataGridViewWarehouse.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обрабатываем исключения и выводим сообщение об ошибке.
                MessageBox.Show("Произошла ошибка при выполнении запроса: " + ex.Message);
            }
        }

        private void Report_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=Warehouse;Integrated Security=True;Encrypt=False";

            // Получаем текст сообщения из текстового поля.
            string message = ReportContent.Text;

            // SQL-запрос для вставки нового сообщения в таблицу "Сообщение".
            string query = "INSERT INTO Сообщение VALUES (@Message)";

            try
            {
                // Создаем соединение с базой данных.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Открываем соединение.
                    connection.Open();

                    // Создаем команду.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Добавляем параметр для команды.
                        command.Parameters.AddWithValue("@Message", message);

                        // Выполняем команду.
                        command.ExecuteNonQuery();
                    }
                }

                // Сообщаем пользователю об успешном выполнении операции.
                MessageBox.Show("Сообщение успешно добавлено.");
            }
            catch (Exception ex)
            {
                // Обрабатываем исключения и выводим сообщение об ошибке.
                MessageBox.Show("Произошла ошибка при добавлении сообщения: " + ex.Message);
            }
        }
    }
}

    

