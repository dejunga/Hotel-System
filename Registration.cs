using System.Data.SqlClient;

namespace Hotel_System {
    internal class Registration {

        private string connectionString = Baza.ConnectionString();

        public async Task<RegistrationResult> InsertUserAsync(string username, string email, string password, string repeatedPassword) {
            RegistrationResult result = new RegistrationResult();

            // Check if the username is already taken
            if (await IsUsernameTakenAsync(username)) {
                result.Message = "Username is already taken.";
            }

            // Check if the email is valid
            else if (!IsValidEmail(email)) {
                result.Message = "Invalid email format.";
            }

            // Check if the password and repeatedPassword match
            else if (password != repeatedPassword) {
                result.Message = "Passwords do not match.";
            } else {
                // Proceed with user insertion asynchronously
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    await connection.OpenAsync();

                    string insertQuery = "INSERT INTO Users (Username, Email, Password) " +
                                         "VALUES (@Username, @Email, @Password)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection)) {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected > 0) {
                            result.Success = true;
                            result.Message = "User registered successfully.";
                        } else {
                            result.Message = "Failed to register user.";
                        }
                    }
                }
            }

            return result;
        }

        private Task<bool> IsUsernameTakenAsync(string username) {
            throw new NotImplementedException();
        }

        private bool IsUsernameTaken(string username) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@Username", username);

                    int userCount = (int)command.ExecuteScalar();

                    return userCount > 0;
                }
            }
            return false;
        }

        private bool IsValidEmail(string email) {
            try {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            } catch (FormatException) {
                return false;
            }
        }






















    }
}
