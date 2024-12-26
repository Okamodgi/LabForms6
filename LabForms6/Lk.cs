using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

namespace LabForms6
{
    public partial class Lk : Form
    {
        string connectionString = "Server=DESKTOP-44TQDIG;Database=Laborat;Integrated Security=True;";
        private Timer timer;

        public Lk()
        {
            InitializeComponent();
            LoadComboBoxData();
            LoadData();
            LoadArchiveData();
            MoveExpiredToArchive();
            LoadDataForDataGridView1();


            timer = new Timer();
            timer.Interval = 600000;
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            MoveExpiredToArchive();
        }
        private void MoveExpiredToArchive()
        {
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Archive (ID, [Логин абонента], [Лицевой счет], Услуга, Статус, [Тип проблемы], [Описание проблемы], [Время закрытия])
                    SELECT ID, [Логин абонента], [Лицевой счет], Услуга, Статус, [Тип проблемы], [Описание проблемы], [Время закрытия]
                    FROM Uslugi
                    WHERE [Время закрытия] <= GETDATE();

                    DELETE FROM Uslugi
                    WHERE [Время закрытия] <= GETDATE();
                ";

                try
                {
                    myConnection.Open();
                    using (SqlCommand command = new SqlCommand(query, myConnection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Данные перенесены в архив.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); 
                            LoadArchiveData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при переносе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadComboBoxData()
        {
            comboBoxUsluga.Items.Clear();
            comboBoxUsluga.Items.Add("Консультация");
            comboBoxUsluga.Items.Add("Ремонт");

            comboBoxState.Items.Clear();
            comboBoxState.Items.Add("Активно");
            comboBoxState.Items.Add("Не активно");

            comboBoxTipPr.Items.Clear();
            comboBoxTipPr.Items.Add("Покупка");
            comboBoxTipPr.Items.Add("Использование");
            comboBoxTipPr.Items.Add("Открытие");
        }

        private void LoadData()
        {
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Uslugi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, myConnection);
                DataTable dataTable = new DataTable();
                try
                {
                    myConnection.Open();
                    dataAdapter.Fill(dataTable);
                    dataGridView3.DataSource = dataTable;

                    if (!dataGridView3.Columns.Contains("Archive"))
                    {
                        DataGridViewButtonColumn archiveButton = new DataGridViewButtonColumn();
                        archiveButton.Name = "Archive";
                        archiveButton.Text = "В архив";
                        archiveButton.UseColumnTextForButtonValue = true;
                        dataGridView3.Columns.Add(archiveButton);
                    }

                    dataGridView3.CellClick += DataGridView3_CellClick;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadArchiveData()
        {
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Archive";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, myConnection);
                DataTable dataTable = new DataTable();
                try
                {
                    myConnection.Open();
                    dataAdapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных из архива: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView3.Columns["Archive"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["ID"].Value);
                MoveToArchive(id);
            }
        }


        private void MoveToArchive(int id)
        {
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                string query = @"
            SET IDENTITY_INSERT Archive ON;

            INSERT INTO Archive (ID, [Логин абонента], [Лицевой счет], Услуга, Статус, [Тип проблемы], [Описание проблемы], [Время закрытия])
            SELECT ID, [Логин абонента], [Лицевой счет], Услуга, Статус, [Тип проблемы], [Описание проблемы], [Время закрытия]
            FROM Uslugi WHERE ID = @id;

            SET IDENTITY_INSERT Archive OFF;

            DELETE FROM Uslugi WHERE ID = @id;
        ";

                try
                {
                    myConnection.Open();
                    using (SqlCommand command = new SqlCommand(query, myConnection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Данные перенесены в архив.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            LoadArchiveData();
                        }
                        else
                        {
                          
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при переносе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadDataForDataGridView1()
        {
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Data";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, myConnection);
                DataTable dataTable = new DataTable();
                try
                {
                    myConnection.Open();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных для dataGridView1: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string schetStr = textBoxChet.Text;
            string usluga = comboBoxUsluga.Text;
            string status = comboBoxState.Text;
            string tipProblemy = comboBoxTipPr.Text;
            string opisanie = textBoxProblem.Text;

            if (string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(schetStr) ||
                string.IsNullOrWhiteSpace(usluga) ||
                string.IsNullOrWhiteSpace(status) ||
                string.IsNullOrWhiteSpace(tipProblemy) ||
                string.IsNullOrWhiteSpace(opisanie))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(schetStr, out int schet))
            {
                MessageBox.Show("Некорректный формат лицевого счёта. Введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime currentTimePlusOneMinute = DateTime.Now.AddMinutes(20);

            string query = @"INSERT INTO Uslugi ([Логин абонента], [Лицевой счет], Услуга, Статус, [Тип проблемы], [Описание проблемы], [Время закрытия])
                     VALUES (@login, @schet, @usluga, @status, @tipProblemy, @opisanie, @timeClose)";

            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try
                {
                    myConnection.Open();
                    using (SqlCommand command = new SqlCommand(query, myConnection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@schet", schet);
                        command.Parameters.AddWithValue("@usluga", usluga);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@tipProblemy", tipProblemy);
                        command.Parameters.AddWithValue("@opisanie", opisanie);
                        command.Parameters.AddWithValue("@timeClose", currentTimePlusOneMinute);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Данные успешно добавлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось добавить данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
