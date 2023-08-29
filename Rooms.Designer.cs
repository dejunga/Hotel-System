namespace Hotel_System {
    partial class Rooms {
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
            dataGridView2 = new DataGridView();
            removeBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            isFreeTb = new TextBox();
            priceTb = new TextBox();
            capacityTb = new TextBox();
            oibLbl = new Label();
            emailLbl = new Label();
            surnameLbl = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
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
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(344, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(500, 345);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(260, 166);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(75, 23);
            removeBtn.TabIndex = 25;
            removeBtn.Text = "remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(178, 166);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 24;
            editBtn.Text = "edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(100, 166);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 23;
            addBtn.Text = "add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click_1;
            // 
            // isFreeTb
            // 
            isFreeTb.Location = new Point(178, 106);
            isFreeTb.Name = "isFreeTb";
            isFreeTb.Size = new Size(100, 23);
            isFreeTb.TabIndex = 22;
            // 
            // priceTb
            // 
            priceTb.Location = new Point(178, 68);
            priceTb.Name = "priceTb";
            priceTb.Size = new Size(100, 23);
            priceTb.TabIndex = 21;
            // 
            // capacityTb
            // 
            capacityTb.Location = new Point(178, 34);
            capacityTb.Name = "capacityTb";
            capacityTb.Size = new Size(100, 23);
            capacityTb.TabIndex = 20;
            // 
            // oibLbl
            // 
            oibLbl.AutoSize = true;
            oibLbl.Location = new Point(121, 109);
            oibLbl.Name = "oibLbl";
            oibLbl.Size = new Size(37, 15);
            oibLbl.TabIndex = 18;
            oibLbl.Text = "IsFree";
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Location = new Point(121, 71);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(33, 15);
            emailLbl.TabIndex = 17;
            emailLbl.Text = "Price";
            // 
            // surnameLbl
            // 
            surnameLbl.AutoSize = true;
            surnameLbl.Location = new Point(121, 37);
            surnameLbl.Name = "surnameLbl";
            surnameLbl.Size = new Size(53, 15);
            surnameLbl.TabIndex = 16;
            surnameLbl.Text = "Capacity";
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 450);
            Controls.Add(removeBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(isFreeTb);
            Controls.Add(priceTb);
            Controls.Add(capacityTb);
            Controls.Add(oibLbl);
            Controls.Add(emailLbl);
            Controls.Add(surnameLbl);
            Controls.Add(dataGridView2);
            Controls.Add(menuStrip1);
            Name = "Rooms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooms";
            Load += Rooms_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem reservationsToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private DataGridView dataGridView2;
        private Button removeBtn;
        private Button editBtn;
        private Button addBtn;
        private TextBox isFreeTb;
        private TextBox priceTb;
        private TextBox capacityTb;
        private Label oibLbl;
        private Label emailLbl;
        private Label surnameLbl;
        private Button button1;
    }
}