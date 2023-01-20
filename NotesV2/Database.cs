using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace NotesV2
{
    internal class Database
    {
        private const string Server = "localhost";
        private const string Username = "root";
        private const string Password = "";
        private const string DatabaseName = "cs_notation";

        public MySqlConnection Connection;
        public MySqlCommand Command;

        public MySqlDataReader Reader;

        public Database()
        {
            Connection = new MySqlConnection($"Server={Server};Database={DatabaseName};Uid={Username};Pwd={Password}");
        }

        public async Task OpenConnection() 
        {
            await Connection.OpenAsync();
        }

        public async Task CloseConnection() => await Connection.CloseAsync();
    }
}
