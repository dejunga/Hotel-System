using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System {
    public partial class Rooms : Form {

        private string connectionString = Baza.ConnectionString();
        public Rooms() {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e) {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void clientsToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Clients clients = new Clients();
            clients.Show();
            this.Hide();
        }

        private void reservationsToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Reservations reservations = new Reservations();
            reservations.Show();
            this.Hide();
        }

        private void roomsToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Rooms rooms = new Rooms();
            rooms.Show();
            this.Hide();
        }
        Room room = new Room();
        private void Rooms_Load(object sender, EventArgs e) {

            dataGridView2.DataSource = room.GetRooms();
        }







        private bool InsertRoom(int capacity, int price, int isFree) {
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

        private void RefreshDataGridView() {
            dataGridView2.DataSource = GetRooms(); // Refresh the grid data
        }

        private DataTable GetRooms() {
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










        private void addBtn_Click_1(object sender, EventArgs e) {
            try {
                int capacity = Convert.ToInt32(capacityTb.Text);
                int price = Convert.ToInt32(priceTb.Text);
                int isFree = Convert.ToInt32(isFreeTb.Text);

                bool insertResult = InsertRoom(capacity, price, isFree);

                if (insertResult) {
                    MessageBox.Show("Room added successfully.");
                    RefreshDataGridView();
                } else {
                    MessageBox.Show("Failed to add room.");
                }
            } catch (Exception ex) {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //if (dataGridView2.SelectedRows.Count > 0) {
            //    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
            capacityTb.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            priceTb.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            isFreeTb.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            //}
        }


        private void editBtn_Click(object sender, EventArgs e) {
            if (dataGridView2.SelectedRows.Count > 0) {
                int roomId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Id"].Value);
                int capacity = Convert.ToInt32(capacityTb.Text);
                int price = Convert.ToInt32(priceTb.Text);
                int isFree = Convert.ToInt32(isFreeTb.Text);

                bool editResult = room.EditRoom(roomId, capacity, price, isFree);

                if (editResult) {
                    MessageBox.Show("Room information updated successfully.");
                    RefreshDataGridView();
                } else {
                    MessageBox.Show("Failed to update room information.");
                }
            } else {
                MessageBox.Show("Select a room to edit.");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e) {
            try {
                if (dataGridView2.SelectedRows.Count > 0) {
                    int roomId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Id"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to remove this room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) {
                        bool removeResult = room.RemoveRoom(roomId);

                        if (removeResult) {
                            MessageBox.Show("Room removed successfully.");
                            RefreshDataGridView();
                        } else {
                            MessageBox.Show("Failed to remove room.");
                        }
                    }
                } else {
                    MessageBox.Show("Select a room to remove.");
                }
            } catch (Exception ex) {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
