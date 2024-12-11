using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LabForms6
{

    public partial class AutorReg : Form
    {
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button AutButton;
        private ComboBox Rollers;
        private CheckBox checkPass;

        private string connectionString = "Server=DESKTOP-44TQDIG;Database=Laborat; Integrated Security=True;";

        public AutorReg()
        {
            InitializeComponent();

            txtLogin = textBox1;
            txtPassword = textBox2;
            AutButton = AutButton;
            Rollers = comboBox1;

            checkPass = new CheckBox
            {
                Text = "Показать пароль",
                Location = new System.Drawing.Point(txtPassword.Location.X, txtPassword.Location.Y + 25),
                AutoSize = true
            };

            this.Controls.Add(checkPass);

            checkPass.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            this.Load += AutorReg_Load;
            AutButton.Click += AutButton_Click;

            txtPassword.UseSystemPasswordChar = true; // Включаем системные символы пароля
        }

        private void AutorReg_Load(object sender, EventArgs e)
        {
            TestConnection();
          

            Rollers.Items.Add("Оператор");
            Rollers.Items.Add("Администратор");
            Rollers.Items.Add("Пользователь");
        }

        private void TestConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkPass.Checked;
            txtPassword.Refresh(); // Обновление интерфейса
        }

        private void AutButton_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            string hashedPassword = HashPassword(password);
            string selectedRole = Rollers.SelectedItem?.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT [Password], [Rol] FROM [dbo].[User] WHERE [Login] = @Login";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHashedPassword = reader.GetString(0); // Тип получаемого значения изменен на GetString() для совместимости
                                string role = reader.GetString(1); // Тип получаемого значения изменен на GetString() для совместимости

                                if (storedHashedPassword == hashedPassword && role == selectedRole)
                                {
                                    MessageBox.Show("Авторизация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Lk form2 = new Lk();
                                    form2.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Неверный логин, пароль или роль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password.Trim()));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
