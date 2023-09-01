namespace Hotel_System {
    partial class LoginForm {
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            loginBtn = new Button();
            passwordTextbox = new TextBox();
            usernameTextbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user2;
            pictureBox1.Location = new Point(41, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(loginBtn);
            groupBox1.Controls.Add(passwordTextbox);
            groupBox1.Controls.Add(usernameTextbox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 211);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(178, 148);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(29, 148);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(128, 94);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(160, 23);
            passwordTextbox.TabIndex = 3;
            passwordTextbox.UseSystemPasswordChar = true;
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(128, 40);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(160, 23);
            usernameTextbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 94);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // button2
            // 
            button2.Location = new Point(139, 37);
            button2.Name = "button2";
            button2.Size = new Size(141, 23);
            button2.TabIndex = 2;
            button2.Text = "ispisi sve usere";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 329);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button loginBtn;
        private TextBox passwordTextbox;
        private TextBox usernameTextbox;
        private Button button1;
        private Button button2;
    }
}