using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;
using System.Text;
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


        User user = new User();



        private async void button2_Click(object sender, EventArgs e) {
            User user = new User(); // Create an instance of the User class

            List<User> users = user.GetAllUsers();

            if (users.Count > 0) {
                string folderPath = "C:/Users/j/Desktop/test/"; // Specify the desired folder path
                string fileName = "users.txt"; // Specify the desired file name

                string filePath = Path.Combine(folderPath, fileName);

                try {
                    user.ExportUsersToTxt(users, filePath); // Call the instance method on the user instance
                    MessageBox.Show("Users exported successfully.");
                } catch (Exception ex) {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            } else {
                MessageBox.Show("No users found in the database.");
            }
        }



    }
}


