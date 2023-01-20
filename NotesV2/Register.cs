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
    public partial class Register : MaterialForm
    {
        public Register()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var email = txbEmail.Text;
            var username = txbUsername.Text;
            var password = txbPassword.Text;
            var passwordConfirm = txbPasswordConfirm.Text;

            if (Validator.IsValidEmail(email) && Validator.IsValidPassword(password) && Validator.PasswordMatch(password, passwordConfirm))
            {
                var newUser = new User(email, username, password);
                await newUser.Save(newUser);
            }
            else
            {
                MessageBox.Show("Wrong things");
            }
            
        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            var login = new Login();
            Hide(); 
            login.Show();
        }
    }
}
