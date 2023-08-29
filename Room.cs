using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System {
    internal class Room {


        private string connectionString = Baza.ConnectionString();



        public DataTable GetRooms() {
            DataTable roomsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string selectQuery = "SELECT * FROM Rooms";

                using (SqlCommand command = new SqlCommand(selectQuery, connection)) {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
                        adapter.Fill(roomsTable);
                    }
                }
            }

            return roomsTable;
        }




        public bool InsertRoom(int capacity, int price, int isFree) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string insertQuery = "INSERT INTO Rooms (Capacity, Price, IsFree) " +
                                     "VALUES (@Capacity, @Price, @IsFree)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection)) {
                    command.Parameters.AddWithValue("@Capacity", capacity);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@IsFree", isFree);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool EditRoom(int roomId, int capacity, int price, int isFree) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string editQuery = "UPDATE Rooms SET Capacity = @Capacity, Price = @Price, IsFree = @IsFree WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(editQuery, connection)) {
                    command.Parameters.AddWithValue("@Id", roomId);
                    command.Parameters.AddWithValue("@Capacity", capacity);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@IsFree", isFree);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool RemoveRoom(int id) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string removeQuery = "DELETE FROM Rooms WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(removeQuery, connection)) {
                    command.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }


        public DataTable GetRoomsFree() {
            DataTable roomsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string selectQuery = "SELECT * FROM Rooms WHERE IsFree = 1";

                using (SqlCommand command = new SqlCommand(selectQuery, connection)) {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
                        adapter.Fill(roomsTable);
                    }
                }
            }

            return roomsTable;
        }


        public bool SetIsFreeToNo(int roomID) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string updateQuery = "UPDATE Rooms SET IsFree = 0 WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(updateQuery, connection)) {
                    command.Parameters.AddWithValue("@Id", roomID);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }



















    }
}
