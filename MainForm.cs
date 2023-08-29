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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e) {
            using (SqlConnection sqlConnection = new SqlConnection(Baza.ConnectionString())) {
                string query = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow redak in ds.Tables[0].Rows) {
                    //listUsers.Items.Add(redak);
                }
            }
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e) {
            Clients clients = new();
            clients.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e) {
            MainForm mainForm = new();
            mainForm.Show();
            this.Hide();
        }

        private void reservationsToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Reservations reservations = new();
            reservations.Show();
            this.Hide();
        }

        private void roomsToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Rooms rooms = new();
            rooms.Show();
            this.Hide();
        }
    }
}
