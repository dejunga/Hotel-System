using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System {
    internal class Client {

        private string connectionString = Baza.ConnectionString();

        public bool InsertClient(string name, string surname, string email, int oib) {
            // Validate the email address using MailAddress class
            try {
                var mailAddress = new MailAddress(email);
            } catch (FormatException) {
                // Invalid email format
                return false;
            }

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string insertQuery = "INSERT INTO Clients (Name, Surname, Email, OIB) " +
                                     "VALUES (@Name, @Surname, @Email, @OIB)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection)) {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@OIB", oib);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }


        public bool EditClient(int id, string name, string surname, string email, int oib) {
            // Validate the email address using MailAddress class
            try {
                var mailAddress = new MailAddress(email);
            } catch (FormatException) {
                // Invalid email format
                return false;
            }

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string editQuery = "UPDATE Clients SET Name = @Name, Surname = @Surname, Email = @Email, OIB = @OIB WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(editQuery, connection)) {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@OIB", oib);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }







        public DataTable GetClients() {
                DataTable clientsTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Clients";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection)) {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
                            adapter.Fill(clientsTable);
                        }
                    }
                }

                return clientsTable;
        }

        //internal bool RemoveClient(int clientId) {
        //    throw new NotImplementedException();
        //}



        public bool RemoveClient(int id) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string removeQuery = "DELETE FROM Clients WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(removeQuery, connection)) {
                    command.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }





    }



}