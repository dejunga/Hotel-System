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
    public partial class Reservations : Form {

        Reservation reservation = new Reservation();
        Client client = new Client();
        Room room = new Room();


        public Reservations() {
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



        private void Reservations_Load(object sender, EventArgs e) {
            // Populate the client dropdown
            DataTable clientsTable = client.GetClients();
            clientsTable.Columns.Add("FullName", typeof(string), "Name + ' ' + Surname + ' - ' + Id");

            clientIDComboBox.DataSource = clientsTable;
            clientIDComboBox.DisplayMember = "FullName"; // Replace with actual column name
            clientIDComboBox.ValueMember = "Id"; // Replace with actual column name



            // Create the calculated column before setting the data source
            DataTable roomsTable = room.GetRoomsFree();
            roomsTable.Columns.Add("RoomInfo", typeof(string), "Capacity + ' Capacity - Price: ' + Price");

            // Set the data source for the ComboBox
            roomIDComboBox.DataSource = roomsTable;
            roomIDComboBox.DisplayMember = "RoomInfo"; // Use "RoomInfo" as the column name
            roomIDComboBox.ValueMember = "Id"; // Replace with actual column name for the value


            // Load reservations data into the DataGridView
            dataGridView2.DataSource = reservation.GetReservations();
        }

        private void addBtn_Click(object sender, EventArgs e) {
            try {
                string clientID = clientIDComboBox.SelectedValue.ToString();
                string roomIDString = roomIDComboBox.SelectedValue.ToString(); // The value is the calculated "RoomInfo"
                DateTime dateIN = dateTimePicker1.Value;
                DateTime dateOUT = dateTimePicker2.Value;

                if (dateIN < DateTime.Now) {
                    MessageBox.Show("The check-in date must be greater than or equal to today's date.");
                } else if (dateOUT < dateIN) {
                    MessageBox.Show("The check-out date must be greater than the check-in date.");
                } else {
                    // Split the "RoomInfo" string to get the room ID
                    string[] roomInfoParts = roomIDString.Split('-');
                    if (roomInfoParts.Length >= 2 && int.TryParse(roomInfoParts[1].Trim(), out int roomID)) {
                        bool insertResult = reservation.InsertReservation(clientID, roomID, dateIN, dateOUT);

                        if (insertResult) {
                            bool setIsFreeResult = room.SetIsFreeToNo(roomID); // Pass the parsed roomID here
                            if (setIsFreeResult) {
                                MessageBox.Show("Reservation added successfully.");
                                dataGridView2.DataSource = reservation.GetReservations();
                            } else {
                                MessageBox.Show("Failed to set IsFree to No for the room.");
                            }
                        } else {
                            MessageBox.Show("Failed to add reservation.");
                        }
                    } else {
                        MessageBox.Show("Invalid room ID.");
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void removeBtn_Click(object sender, EventArgs e) {
            try {
                if (dataGridView2.SelectedRows.Count > 0) {
                    int reservationId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Id"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to remove this reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) {
                        bool removeResult = reservation.RemoveReservation(reservationId);

                        if (removeResult) {
                            MessageBox.Show("Reservation removed successfully.");
                            dataGridView2.DataSource = reservation.GetReservations(); // Refresh the DataGridView after successful removal
                        } else {
                            MessageBox.Show("Failed to remove reservation.");
                        }
                    }
                } else {
                    MessageBox.Show("Select a reservation to remove.");
                }
            } catch (Exception ex) {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
