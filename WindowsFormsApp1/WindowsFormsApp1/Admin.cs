using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        string connectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=Warehouse;Integrated Security=True;Encrypt=False";
        public Admin()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Склад";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        // Открываем подключение и создаем адаптер данных
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Заполняем таблицу данными из базы данных
                        adapter.Fill(dataTable);

                        // Привязываем таблицу к элементу управления DataGridView
                        dataGridViewEmployees.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                    }
                }
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=Warehouse;Integrated Security=True;Encrypt=False";

            // Получаем данные из текстовых полей.
            string nameItem = NameItem.Text;
            if (!int.TryParse(KolvoItem.Text, out int kolvoItem))
            {
                MessageBox.Show("Введите правильное количество.");
                return;
            }

            // SQL-запрос для вставки нового элемента в таблицу "Склад".
            string query = "INSERT INTO Склад VALUES (@NameItem, @KolvoItem)";

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
                        // Добавляем параметры для команды.
                        command.Parameters.AddWithValue("@NameItem", nameItem);
                        command.Parameters.AddWithValue("@KolvoItem", kolvoItem);

                        // Выполняем команду.
                        command.ExecuteNonQuery();

                        // Сообщаем пользователю об успешном выполнении операции.
                        MessageBox.Show("Элемент успешно добавлен.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Обрабатываем исключения и выводим сообщение об ошибке.
                MessageBox.Show("Произошла ошибка при добавлении элемента: " + ex.Message);
            }
        }
        private void CheckReports_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Сообщение";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        // Открываем подключение и создаем адаптер данных
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Заполняем таблицу данными из базы данных
                        adapter.Fill(dataTable);

                        // Привязываем таблицу к элементу управления DataGridView
                        dataGridViewReport.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                    }
                }
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=Warehouse;Integrated Security=True;Encrypt=False";

            // Получаем ID сообщения из текстового поля.
            if (!int.TryParse(IdReport.Text, out int reportId))
            {
                MessageBox.Show("Введите правильный ID сообщения.");
                return;
            }

            // SQL-запрос для удаления сообщения из таблицы "Сообщение" по ID.
            string query = "DELETE FROM Сообщение WHERE ID = @ReportId";

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
                        command.Parameters.AddWithValue("@ReportId", reportId);

                        // Выполняем команду.
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Сообщение успешно удалено.");
                        }
                        else
                        {
                            MessageBox.Show("Сообщение с таким ID не найдено.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обрабатываем исключения и выводим сообщение об ошибке.
                MessageBox.Show("Произошла ошибка при удалении сообщения: " + ex.Message);
            }
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=Warehouse;Integrated Security=True;Encrypt=False";

            // Получаем данные из текстовых полей.
            string nameItem = NameItem.Text;
            if (!int.TryParse(KolvoItem.Text, out int kolvoItem))
            {
                MessageBox.Show("Введите правильное количество.");
                return;
            }

            // SQL-запрос для обновления количества в таблице "Склад".
            string query = "UPDATE Склад SET Количество = @KolvoItem WHERE Наименование = @NameItem";

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
                        // Добавляем параметры для команды.
                        command.Parameters.AddWithValue("@NameItem", nameItem);
                        command.Parameters.AddWithValue("@KolvoItem", kolvoItem);

                        // Выполняем команду.
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Элемент успешно обновлен.");
                        }
                        else
                        {
                            MessageBox.Show("Элемент с таким названием не найден.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обрабатываем исключения и выводим сообщение об ошибке.
                MessageBox.Show("Произошла ошибка при обновлении элемента: " + ex.Message);
            }
        }

        private void CreateData_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=Warehouse;Integrated Security=True;Encrypt=False";

            // SQL-запрос для выборки всех записей из таблицы "Склад".
            string query = "SELECT * FROM Склад";

            // Создаем DataTable для хранения данных.
            DataTable dataTable = new DataTable();

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
                        // Выполняем команду и заполняем DataTable.
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }

                // Создаем PDF-документ.
                Document pdfDoc = new Document(PageSize.A4);
                PdfWriter.GetInstance(pdfDoc, new FileStream("otchet.pdf", FileMode.Create));
                pdfDoc.Open();

                // Добавляем заголовок.
                pdfDoc.Add(new Paragraph("Отчет по складу"));
                pdfDoc.Add(new Paragraph(" "));

                // Создаем таблицу для данных.
                PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);

                // Добавляем заголовки столбцов.
                foreach (DataColumn column in dataTable.Columns)
                {
                    pdfTable.AddCell(new Phrase(column.ColumnName));
                }

                // Добавляем данные строк.
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var cell in row.ItemArray)
                    {
                        pdfTable.AddCell(new Phrase(cell.ToString()));
                    }
                }

                // Добавляем таблицу в документ.
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();

                // Сообщаем пользователю об успешном выполнении операции.
                MessageBox.Show("PDF файл 'otchet.pdf' успешно создан.");
            }
            catch (Exception ex)
            {
                // Обрабатываем исключения и выводим сообщение об ошибке.
                MessageBox.Show("Произошла ошибка при создании PDF файла: " + ex.Message);
            }
        }
    }
    }
