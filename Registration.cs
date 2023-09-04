using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;

namespace Hotel_System {
    internal class Registration {

        private string connectionString = Baza.ConnectionString();

        public async Task<RegistrationResult> InsertUserAsync(string username, string email, string password, string repeatedPassword) {
            RegistrationResult result = new RegistrationResult();

            if (await IsUsernameTakenAsync(username)) {
                result.Message = "Username is already taken.";
            }

            else if (!IsValidEmail(email)) {
                result.Message = "Invalid email format.";
            }

            else if (password != repeatedPassword) {
                result.Message = "Passwords do not match.";
            } else {
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

        private async Task<bool> IsUsernameTakenAsync(string username) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                await connection.OpenAsync();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@Username", username);

                    int userCount = (int)await command.ExecuteScalarAsync();

                    return userCount > 0;
                }
            }
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
