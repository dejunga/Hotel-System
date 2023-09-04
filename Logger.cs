using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System {
    internal class Logger {
        private static string logFilePath = "C:/Users/j/Desktop/test/logs.txt";

        public static void Log(string message) {
            try {
                using (StreamWriter writer = new StreamWriter(logFilePath, true)) {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            } catch (Exception ex) {
                Console.WriteLine($"Failed to log message. Error: {ex.Message}");
            }
        }
    }
}