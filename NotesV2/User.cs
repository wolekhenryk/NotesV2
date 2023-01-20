using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySqlConnector;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesV2
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Timestamp { get; set; }

        public User(string email, string username, string plainPassword) 
        {
            Email = email;
            Username = username;
            Password = Hash.Make(plainPassword);

            Timestamp = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
        }

        public User(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                Id = reader.GetInt32("id");
                Email = reader.GetString("email");
                Username = reader.GetString("username");
                Password = reader.GetString("password");
                Timestamp = reader.GetDateTime("created_at").ToString("yyy-MM-dd HH:mm:ss");
            }
        }

        public static bool Authenticate(string password, User user) => Hash.Verify(password, user.Password);

        public async Task Save()
        {
            var db = new Database();

            await db.OpenConnection();
            db.Command =
                new MySqlCommand(
                    "INSERT INTO users (email, username, password, created_at, updated_at) VALUES (@email, @username, @password, @created_at, @updated_at)",
                    db.Connection);
            db.Command.Parameters.AddWithValue("@email", Email);
            db.Command.Parameters.AddWithValue("@username", Username);
            db.Command.Parameters.AddWithValue("@password", Password);
            db.Command.Parameters.AddWithValue("@created_at", Timestamp);
            db.Command.Parameters.AddWithValue("@updated_at", Timestamp);

            await db.Command.ExecuteNonQueryAsync();
            await db.CloseConnection();
        }

        public static async Task<User> Find(string email)
        {
            var db = new Database();
            await db.OpenConnection();

            db.Command = new MySqlCommand("SELECT * FROM users WHERE email = @email", db.Connection);
            db.Command.Parameters.AddWithValue("@email", email);

            db.Reader = await db.Command.ExecuteReaderAsync();

            if (db.Reader.HasRows)
            {
                return new User(db.Reader);
            }
            await db.CloseConnection();
            return null;
        }

        public static async Task<User> Find(int userId)
        {
            var db = new Database();
            await db.OpenConnection();

            db.Command = new MySqlCommand("SELECT * FROM users WHERE id = @user_id", db.Connection);
            db.Command.Parameters.AddWithValue("@user_id", userId);

            db.Reader = await db.Command.ExecuteReaderAsync();

            if (db.Reader.HasRows)
            {
                return new User(db.Reader);
            }
            await db.CloseConnection();
            return null;
        }
    }
}
