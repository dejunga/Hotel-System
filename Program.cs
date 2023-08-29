namespace Hotel_System {
    internal static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and show the LoginForm
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK) {
                Application.Run(new MainForm());
            }
        }
    }
}