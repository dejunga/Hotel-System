using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System {
    internal class User {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private string connectionString = Baza.ConnectionString();


        public List<User> GetAllUsers() {
            List<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string query = "SELECT * FROM Users";
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            User user = new User {
                                Id = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                Email = reader.GetString(2),
                                Password = reader.GetString(3)
                            };
                            users.Add(user);
                        }
                    }
                }
            }

            return users;
        }





        public void ExportUsersToTxt(List<User> users, string filePath) {
            using (StreamWriter writer = new StreamWriter(filePath)) {
                foreach (User user in users) {
                    writer.WriteLine($"ID: {user.Id}");
                    writer.WriteLine($"Username: {user.Username}");
                    writer.WriteLine($"Email: {user.Email}");
                    writer.WriteLine(); // Add an empty line to separate users
                }
            }
        }





































    }
}
