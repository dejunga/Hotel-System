using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Hotel_System {
    public partial class LoginForm : Form {

        Registrations registrations = new Registrations();

        private string connectionString = Baza.ConnectionString();

        public LoginForm() {
            InitializeComponent();
            labelDate.Text = DateTime.Now.ToString("HH:mm dd-MM-yyyy");
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
                        Logger.Log($"User '{usernameTextbox.Text}' logged in successfully.");
                    } else {
                        MessageBox.Show("Invalid username or password.");
                        Logger.Log($"Failed login attempt for user '{usernameTextbox.Text}'.");
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            registrations.Show();
            this.Hide();
            Logger.Log("User navigated to the registrations form.");
        }

        private void button2_Click(object sender, EventArgs e) {
            User user = new User();

            List<User> users = user.GetAllUsers();

            if (users.Count > 0) {
                string folderPath = "C:/Users/j/Desktop/test/";
                string fileName = "users.txt";

                string filePath = Path.Combine(folderPath, fileName);

                try {
                    user.ExportUsersToTxt(users, filePath);
                    MessageBox.Show("Users exported successfully.");
                    Logger.Log("Users list exported successfully.");
                } catch (Exception ex) {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    Logger.Log($"Error exporting users: {ex.Message}");
                }
            } else {
                MessageBox.Show("No users found in the database.");
                Logger.Log("Attempt to export users failed - No users found in the database.");
            }
        }

        private async void button3_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    string filePath = openFileDialog.FileName;

                    try {
                        string[] lines = File.ReadAllLines(filePath);

                        Registration registration = new Registration();

                        foreach (var line in lines) {
                            string[] parts = line.Split(',');
                            if (parts.Length != 3) {
                                MessageBox.Show("Invalid format in file.");
                                return;
                            }

                            string username = parts[0].Trim();
                            string email = parts[1].Trim();
                            string password = parts[2].Trim();

                            RegistrationResult registrationResult = await registration.InsertUserAsync(username, email, password, password);
                            if (!registrationResult.Success) {
                                MessageBox.Show($"Failed to register user {username}: {registrationResult.Message}");
                            }
                        }

                        MessageBox.Show("Users imported successfully.");

                    } catch (Exception ex) {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

    }
}


