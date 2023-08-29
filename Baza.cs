using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System {
    internal class Baza {
        public static string ConnectionString() {
            return string.Format(
                "Data Source = {0}; Initial Catalog = {1}; User ID = {2}; Password = {3}",
                server, baza, korisnickoIme, lozinka
                );
        }

        private const string server = "sql.vub.zone,14330";
        private const string baza = "Notes";
        private const string korisnickoIme = "sa";
        private const string lozinka = "VUBserver2020";
    }
}
