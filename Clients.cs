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
    public partial class Clients : Form {
        public Clients() {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e) {
            MainForm mainForm = new();
            mainForm.Show();
            this.Hide();
        }

        private void clientsToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Clients clients = new();
            clients.Show();
            this.Hide();
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e) {
            Reservations reservations = new();
            reservations.Show();
            this.Hide();
        }

        private void roomsToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Rooms rooms = new();
            rooms.Show();
            this.Hide();
        }


        private Client client = new Client(); // Declare this at the form level
        private void addBtn_Click(object sender, EventArgs e) {
            string name = nameTb.Text;
            string surname = surnameTb.Text;
            string email = emailTb.Text;

            if (int.TryParse(oibTb.Text, out int oib)) {
                bool insertResult = client.InsertClient(name, surname, email, oib);

                if (insertResult) {
                    MessageBox.Show("Client added successfully.");
                    // Refresh the DataGridView after successful insertion
                    RefreshDataGridView();
                    // Optionally, clear the input fields or perform other actions.
                } else {
                    MessageBox.Show("Failed to add client.");
                }
            } else {
                MessageBox.Show("Invalid OIB. Please enter a valid integer.");
            }
        }

        private void RefreshDataGridView() {
            dataGridView1.DataSource = client.GetClients(); // Refresh the grid data
        }



        private void Clients_Load(object sender, EventArgs e) {
            Client client = new Client();
            dataGridView1.DataSource = client.GetClients();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            nameTb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            surnameTb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            emailTb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            oibTb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void editBtn_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                int clientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                string name = nameTb.Text;
                string surname = surnameTb.Text;
                string email = emailTb.Text;

                if (int.TryParse(oibTb.Text, out int oib)) {
                    bool editResult = client.EditClient(clientId, name, surname, email, oib);

                    if (editResult) {
                        MessageBox.Show("Client information updated successfully.");
                        RefreshDataGridView();
                    } else {
                        MessageBox.Show("Failed to update client information.");
                    }
                } else {
                    MessageBox.Show("Invalid OIB. Please enter a valid integer.");
                }
            } else {
                MessageBox.Show("Select a client to edit.");
            }
        }


        private void removeBtn_Click(object sender, EventArgs e) {
            try {
                if (dataGridView1.SelectedRows.Count > 0) {
                    int clientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to remove this client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) {
                        bool removeResult = client.RemoveClient(clientId);

                        if (removeResult) {
                            MessageBox.Show("Client removed successfully.");
                            RefreshDataGridView(); // Refresh the DataGridView after successful removal
                        } else {
                            MessageBox.Show("Failed to remove client.");
                        }
                    }
                } else {
                    MessageBox.Show("Select a client to remove.");
                }
            } catch (Exception ex) {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


    }
}
