using System;
using System.Windows.Forms;

namespace Hotel_System {
    internal static class Program {
        [STAThread]
        static void Main() {            
            Application.Run(new LoginForm());
        }
    }
}
