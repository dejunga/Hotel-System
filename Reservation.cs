using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel_System {
    internal class Reservation {


        private string connectionString = Baza.ConnectionString();

        //Reservation reservation = new Reservation();




        public DataTable GetReservations() {
            DataTable reservationsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string selectQuery = "SELECT * FROM Reservations";

                using (SqlCommand command = new SqlCommand(selectQuery, connection)) {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
                        adapter.Fill(reservationsTable);
                    }
                }
            }

            return reservationsTable;
        }




        public bool InsertReservation(string? clientID, string roomID, DateTime dateIN, DateTime dateOUT) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string insertQuery = "INSERT INTO Reservations (ClientID, RoomID, DateIN, DateOUT) " +
                                     "VALUES (@ClientID, @RoomID, @DateIN, @DateOUT)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection)) {
                    command.Parameters.AddWithValue("@ClientID", clientID);
                    command.Parameters.AddWithValue("@RoomID", roomID);
                    command.Parameters.AddWithValue("@DateIN", dateIN);
                    command.Parameters.AddWithValue("@DateOUT", dateOUT);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }



        public bool RemoveReservation(int id) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                string removeQuery = "DELETE FROM Reservations WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(removeQuery, connection)) {
                    command.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        internal bool InsertReservation(string? clientID, int roomID, DateTime dateIN, DateTime dateOUT) {
            throw new NotImplementedException();
        }
    }
}
