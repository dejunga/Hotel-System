namespace Hotel_System {
    partial class Registrations {
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usernameTb = new TextBox();
            emailTb = new TextBox();
            passwordTb = new TextBox();
            repeatPasswordTb = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 51);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 113);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 174);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // usernameTb
            // 
            usernameTb.Location = new Point(210, 48);
            usernameTb.Name = "usernameTb";
            usernameTb.Size = new Size(100, 23);
            usernameTb.TabIndex = 3;
            // 
            // emailTb
            // 
            emailTb.Location = new Point(210, 105);
            emailTb.Name = "emailTb";
            emailTb.Size = new Size(100, 23);
            emailTb.TabIndex = 4;
            // 
            // passwordTb
            // 
            passwordTb.Location = new Point(210, 166);
            passwordTb.Name = "passwordTb";
            passwordTb.Size = new Size(100, 23);
            passwordTb.TabIndex = 5;
            // 
            // repeatPasswordTb
            // 
            repeatPasswordTb.Location = new Point(210, 231);
            repeatPasswordTb.Name = "repeatPasswordTb";
            repeatPasswordTb.Size = new Size(100, 23);
            repeatPasswordTb.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 234);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 6;
            label4.Text = "repeat password";
            // 
            // button1
            // 
            button1.Location = new Point(197, 301);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 8;
            button1.Text = "create a user";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Registrations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(repeatPasswordTb);
            Controls.Add(label4);
            Controls.Add(passwordTb);
            Controls.Add(emailTb);
            Controls.Add(usernameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registrations";
            Text = "Registrations";
            Load += Registrations_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernameTb;
        private TextBox emailTb;
        private TextBox passwordTb;
        private TextBox repeatPasswordTb;
        private Label label4;
        private Button button1;
    }
}