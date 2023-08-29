namespace Hotel_System {
    partial class Clients {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            reservationsToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            nameLbl = new Label();
            surnameLbl = new Label();
            emailLbl = new Label();
            oibLbl = new Label();
            nameTb = new TextBox();
            surnameTb = new TextBox();
            emailTb = new TextBox();
            oibTb = new TextBox();
            dataGridView1 = new DataGridView();
            addBtn = new Button();
            editBtn = new Button();
            removeBtn = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, clientsToolStripMenuItem, reservationsToolStripMenuItem, roomsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(91, 450);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(78, 19);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click_1;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(78, 19);
            clientsToolStripMenuItem.Text = "Clients";
            clientsToolStripMenuItem.Click += clientsToolStripMenuItem_Click_1;
            // 
            // reservationsToolStripMenuItem
            // 
            reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            reservationsToolStripMenuItem.Size = new Size(78, 19);
            reservationsToolStripMenuItem.Text = "Reservations";
            reservationsToolStripMenuItem.Click += reservationsToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new Size(78, 19);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click_1;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(166, 22);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(39, 15);
            nameLbl.TabIndex = 3;
            nameLbl.Text = "Name";
            // 
            // surnameLbl
            // 
            surnameLbl.AutoSize = true;
            surnameLbl.Location = new Point(166, 59);
            surnameLbl.Name = "surnameLbl";
            surnameLbl.Size = new Size(54, 15);
            surnameLbl.TabIndex = 4;
            surnameLbl.Text = "Surname";
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Location = new Point(166, 93);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(36, 15);
            emailLbl.TabIndex = 5;
            emailLbl.Text = "email";
            // 
            // oibLbl
            // 
            oibLbl.AutoSize = true;
            oibLbl.Location = new Point(166, 131);
            oibLbl.Name = "oibLbl";
            oibLbl.Size = new Size(26, 15);
            oibLbl.TabIndex = 6;
            oibLbl.Text = "OIB";
            // 
            // nameTb
            // 
            nameTb.Location = new Point(223, 19);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(100, 23);
            nameTb.TabIndex = 7;
            // 
            // surnameTb
            // 
            surnameTb.Location = new Point(223, 56);
            surnameTb.Name = "surnameTb";
            surnameTb.Size = new Size(100, 23);
            surnameTb.TabIndex = 8;
            // 
            // emailTb
            // 
            emailTb.Location = new Point(223, 90);
            emailTb.Name = "emailTb";
            emailTb.Size = new Size(100, 23);
            emailTb.TabIndex = 9;
            // 
            // oibTb
            // 
            oibTb.Location = new Point(223, 128);
            oibTb.Name = "oibTb";
            oibTb.Size = new Size(100, 23);
            oibTb.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(386, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(606, 237);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(145, 188);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 12;
            addBtn.Text = "add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(223, 188);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 13;
            editBtn.Text = "edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(305, 188);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(75, 23);
            removeBtn.TabIndex = 14;
            removeBtn.Text = "remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 450);
            Controls.Add(removeBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(dataGridView1);
            Controls.Add(oibTb);
            Controls.Add(emailTb);
            Controls.Add(surnameTb);
            Controls.Add(nameTb);
            Controls.Add(oibLbl);
            Controls.Add(emailLbl);
            Controls.Add(surnameLbl);
            Controls.Add(nameLbl);
            Controls.Add(menuStrip1);
            Name = "Clients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clients";
            Load += Clients_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem reservationsToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private Label nameLbl;
        private Label surnameLbl;
        private Label emailLbl;
        private Label oibLbl;
        private TextBox nameTb;
        private TextBox surnameTb;
        private TextBox emailTb;
        private TextBox oibTb;
        private DataGridView dataGridView1;
        private Button addBtn;
        private Button editBtn;
        private Button removeBtn;
    }
}