using System.Data;
using System.Data.SqlClient;

namespace LabForms6
{
    public partial class Lk : Form
    {
        string connectionString = "Server=DESKTOP-44TQDIG;Database=Laborat;Integrated Security=True;";

        public Lk()
        {
            InitializeComponent();
            LoadComboBoxData();
            LoadData();
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
                    MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string query = @"INSERT INTO Uslugi ([Логин абонента], [Лицевой счет], Услуга, Статус, [Тип проблемы], [Описание проблемы])
                     VALUES (@login, @schet, @usluga, @status, @tipProblemy, @opisanie)";

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
    }
}