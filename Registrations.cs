using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System {
    public partial class Registrations : Form {
        private readonly List<User> registeredUsers = new List<User>();

        public Registrations() {
            InitializeComponent();
        }

        private void Registrations_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private async void button1_Click(object sender, EventArgs e) {
            string username = usernameTb.Text;
            string email = emailTb.Text;
            string password = passwordTb.Text;
            string repeatPassword = repeatPasswordTb.Text;

            Registration registration = new Registration();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) {
                MessageBox.Show("Please fill in all the required fields.");
            } else if (!ArePasswordsMatching(password, repeatPassword)) {
                MessageBox.Show("Passwords do not match.");
            } else {
                try {
                    RegistrationResult registrationResult = await registration.InsertUserAsync(username, email, password, repeatPassword);
                    MessageBox.Show(registrationResult.Message);
                    if (registrationResult.Success) {
                        ClearInputFields();
                    }
                } catch (FormatException) {
                    MessageBox.Show("Invalid email format.");
                }
            }
        }

        private bool ArePasswordsMatching<T>(T password, T repeatPassword) {
            return EqualityComparer<T>.Default.Equals(password, repeatPassword);
        }

        private bool IsUsernameTaken(string username) {
            foreach (User user in registeredUsers) {
                if (user.Username == username) {
                    return true;
                }
            }
            return false;
        }

        private void ClearInputFields() {
            usernameTb.Clear();
            emailTb.Clear();
            passwordTb.Clear();
            repeatPasswordTb.Clear();
        }








    }
}
