using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesV2
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            lblPassword.Hide();
            lblEmail.Hide();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var userEmail = txbEmail.Text;
            var userPassword = txbPassword.Text;

            User user = await User.Find(userEmail);
            if (user == null || !User.Authenticate(userPassword, user))
            {
                lblPassword.Text = "Wrong email or password";
                lblEmail.Text = "Wrong email or password";

                lblPassword.Show();
                lblEmail.Show();
            }
            else {
                var dashboard = new Dashboard(user);
                Hide();
                dashboard.Show();
            }
        }

        private void txbGoToRegister_Click(object sender, EventArgs e)
        {
            var register = new Register();
            Hide();
            register.Show();
        }
    }
}
