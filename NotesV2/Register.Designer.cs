namespace NotesV2
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txbUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.txbPasswordConfirm = new MaterialSkin.Controls.MaterialTextBox();
            this.txbPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnGoToLogin = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txbEmail
            // 
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmail.Depth = 0;
            this.txbEmail.Font = new System.Drawing.Font("Roboto", 12F);
            this.txbEmail.Location = new System.Drawing.Point(50, 150);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txbEmail.Multiline = false;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(300, 50);
            this.txbEmail.TabIndex = 0;
            this.txbEmail.Text = "";
            // 
            // txbUsername
            // 
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Depth = 0;
            this.txbUsername.Font = new System.Drawing.Font("Roboto", 12F);
            this.txbUsername.Location = new System.Drawing.Point(50, 250);
            this.txbUsername.MaxLength = 50;
            this.txbUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txbUsername.Multiline = false;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(300, 50);
            this.txbUsername.TabIndex = 1;
            this.txbUsername.Text = "";
            // 
            // txbPasswordConfirm
            // 
            this.txbPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPasswordConfirm.Depth = 0;
            this.txbPasswordConfirm.Font = new System.Drawing.Font("Roboto", 12F);
            this.txbPasswordConfirm.Location = new System.Drawing.Point(50, 450);
            this.txbPasswordConfirm.MaxLength = 50;
            this.txbPasswordConfirm.MouseState = MaterialSkin.MouseState.OUT;
            this.txbPasswordConfirm.Multiline = false;
            this.txbPasswordConfirm.Name = "txbPasswordConfirm";
            this.txbPasswordConfirm.Password = true;
            this.txbPasswordConfirm.Size = new System.Drawing.Size(300, 50);
            this.txbPasswordConfirm.TabIndex = 2;
            this.txbPasswordConfirm.Text = "";
            // 
            // txbPassword
            // 
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Depth = 0;
            this.txbPassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.txbPassword.Location = new System.Drawing.Point(50, 350);
            this.txbPassword.MaxLength = 50;
            this.txbPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txbPassword.Multiline = false;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Password = true;
            this.txbPassword.Size = new System.Drawing.Size(300, 50);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.Text = "";
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = false;
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Depth = 0;
            this.btnRegister.DrawShadows = true;
            this.btnRegister.HighEmphasis = true;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(50, 523);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(300, 50);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(50, 582);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(300, 23);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnGoToLogin
            // 
            this.btnGoToLogin.AutoSize = false;
            this.btnGoToLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoToLogin.Depth = 0;
            this.btnGoToLogin.DrawShadows = true;
            this.btnGoToLogin.HighEmphasis = true;
            this.btnGoToLogin.Icon = null;
            this.btnGoToLogin.Location = new System.Drawing.Point(50, 614);
            this.btnGoToLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGoToLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGoToLogin.Name = "btnGoToLogin";
            this.btnGoToLogin.Size = new System.Drawing.Size(300, 50);
            this.btnGoToLogin.TabIndex = 6;
            this.btnGoToLogin.Text = "Already have an account? Login";
            this.btnGoToLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGoToLogin.UseAccentColor = false;
            this.btnGoToLogin.UseVisualStyleBackColor = true;
            this.btnGoToLogin.Click += new System.EventHandler(this.btnGoToLogin_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(50, 127);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Email address";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(50, 227);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Username";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(50, 327);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Password";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(50, 427);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(131, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Confirm password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnGoToLogin);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbPasswordConfirm);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.txbEmail);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txbEmail;
        private MaterialSkin.Controls.MaterialTextBox txbUsername;
        private MaterialSkin.Controls.MaterialTextBox txbPasswordConfirm;
        private MaterialSkin.Controls.MaterialTextBox txbPassword;
        private MaterialSkin.Controls.MaterialButton btnRegister;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton btnGoToLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}