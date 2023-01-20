using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NotesV2
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Author { get; set; }
        public string Timestamp { get; set; }

        public Note(string title, string description, User author)
        {
            Title = title;
            Description = description;
            Author = author;

            Timestamp = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
        }

        private Note()
        {
        }

        public async Task Save()
        {
            var db = new Database();

            await db.OpenConnection();
            db.Command =
                new MySqlCommand(
                    $"INSERT INTO notes (title, desc, user_id, created_at, updated_at) VALUES ('{Title}', '{Description}', {Author.Id}, '{Timestamp}', '{Timestamp}')",
                    db.Connection);

            MessageBox.Show(db.Command.CommandText);

            await db.Command.ExecuteNonQueryAsync();
            await db.CloseConnection();
        }

        public static async Task<List<Note>> FindAll(User user)
        {
            var db = new Database();
            await db.OpenConnection();

            db.Command = new MySqlCommand("SELECT * FROM notes WHERE user_id = @userId", db.Connection);
            db.Command.Parameters.AddWithValue("@user_id", user.Id);
            
            var reader = await db.Command.ExecuteReaderAsync();
            var notes = new List<Note>();

            while (await reader.ReadAsync())
            {
                var note = new Note
                {
                    Id = reader.GetInt32("id"),
                    Title = reader.GetString("title"),
                    Description = reader.GetString("description"),
                    Author = await User.Find(reader.GetInt32("user_id")),
                    Timestamp = reader.GetDateTime("created_at").ToString("yyy-MM-dd HH:mm:ss")
                };
                notes.Add(note);
            }
            await db.CloseConnection();
            return notes;
        }
    }
}
