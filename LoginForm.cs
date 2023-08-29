using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_System {
    public partial class LoginForm : Form {

        Registrations registrations = new Registrations();

        // Database connection string
        private string connectionString = Baza.ConnectionString();

        public LoginForm() {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@Username", usernameTextbox.Text);
                    command.Parameters.AddWithValue("@Password", passwordTextbox.Text);

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0) {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    } else {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e) {
            registrations.Show();
            this.Hide();
        }

    }
}


