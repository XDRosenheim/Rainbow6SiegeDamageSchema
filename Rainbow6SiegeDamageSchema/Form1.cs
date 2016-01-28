using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rainbow6SiegeDamageSchema {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            MySqlConnection conn;
            var connectionString = "server=localhost:3307;uid=root;pwd=28998160";
            try {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                
                MySqlCommand sqlCommand = conn.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM r6siege.weapons;";
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                
                

            } catch(MySqlException msqlException) {
                Console.WriteLine(@"Server error.");
                Console.WriteLine(msqlException);
            }
        }
    }
}
