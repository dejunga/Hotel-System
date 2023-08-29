namespace Hotel_System {
    partial class Reservations {
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
            removeBtn = new Button();
            addBtn = new Button();
            emailLbl = new Label();
            surnameLbl = new Label();
            dataGridView2 = new DataGridView();
            homeToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            reservationsToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            clientIDComboBox = new ComboBox();
            roomIDComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(225, 166);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(75, 23);
            removeBtn.TabIndex = 35;
            removeBtn.Text = "remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(144, 166);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 33;
            addBtn.Text = "add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Location = new Point(92, 71);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(53, 15);
            emailLbl.TabIndex = 28;
            emailLbl.Text = "Room ID";
            // 
            // surnameLbl
            // 
            surnameLbl.AutoSize = true;
            surnameLbl.Location = new Point(92, 37);
            surnameLbl.Name = "surnameLbl";
            surnameLbl.Size = new Size(52, 15);
            surnameLbl.TabIndex = 27;
            surnameLbl.Text = "Client ID";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(355, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(460, 345);
            dataGridView2.TabIndex = 26;
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
            reservationsToolStripMenuItem.Click += reservationsToolStripMenuItem_Click_1;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new Size(78, 19);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, clientsToolStripMenuItem, reservationsToolStripMenuItem, roomsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(91, 450);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 105);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 36;
            label1.Text = "Date IN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 134);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 37;
            label2.Text = "Date OUT";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(149, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 38;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(149, 126);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 39;
            // 
            // clientIDComboBox
            // 
            clientIDComboBox.FormattingEnabled = true;
            clientIDComboBox.Location = new Point(150, 34);
            clientIDComboBox.Name = "clientIDComboBox";
            clientIDComboBox.Size = new Size(199, 23);
            clientIDComboBox.TabIndex = 40;
            // 
            // roomIDComboBox
            // 
            roomIDComboBox.FormattingEnabled = true;
            roomIDComboBox.Location = new Point(150, 68);
            roomIDComboBox.Name = "roomIDComboBox";
            roomIDComboBox.Size = new Size(199, 23);
            roomIDComboBox.TabIndex = 41;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(roomIDComboBox);
            Controls.Add(clientIDComboBox);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(removeBtn);
            Controls.Add(addBtn);
            Controls.Add(emailLbl);
            Controls.Add(surnameLbl);
            Controls.Add(dataGridView2);
            Controls.Add(menuStrip1);
            Name = "Reservations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservations";
            Load += Reservations_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button removeBtn;
        private Button addBtn;
        private Label emailLbl;
        private Label surnameLbl;
        private DataGridView dataGridView2;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem reservationsToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox clientIDComboBox;
        private ComboBox roomIDComboBox;
    }
}