using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace NotesV2
{
    public partial class Dashboard : MaterialForm
    {
        private User _authUser;
        public Dashboard(User authUser)
        {
            _authUser = authUser;

            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            lblWelcome.Text = $"Welcome, {_authUser.Username}";

            /*List<MaterialCard> cardList = new List<MaterialCard>();
            List<Note> notes = FindAllNotes().Result;

            foreach (var note in notes)
            {
                MaterialCard card = new MaterialCard();
            }*/
        }

        private async Task<List<Note>> FindAllNotes() => await Note.FindAll(_authUser);
        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentTab = materialTabControl1.SelectedTab.Name;
            if (currentTab == "tabLogout")
            {
                _authUser = null;
                Hide();

                var loginForm = new Login();
                loginForm.Show();
            }
        }
        private async void btnSaveNote_Click(object sender, EventArgs e)
        {
            var title = txbTitle.Text;
            var desc = txbDescription.Text;

            var newNote = new Note(title, desc, _authUser);
            await newNote.Save();
        }
    }
}
