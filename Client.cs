using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
//using Dapper;

namespace Hotel_System {
    internal class Client {

        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string OIB { get; set; }



        private string connectionString = Baza.ConnectionString();

        public bool InsertClient(string name, string surname, string email, int oib) {
            try {
                var mailAddress = new MailAddress(email);
            } catch (FormatException) {
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
            try {
                var mailAddress = new MailAddress(email);
            } catch (FormatException) {
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



        //public async Task<List<Client>> GetAllClientsAsync() {
        //    using (SqlConnection connection = new SqlConnection(connectionString)) {
        //        return (await connection.QueryAsync<Client>("SELECT * FROM Clients")).ToList();
        //    }
        //}






























    }



}