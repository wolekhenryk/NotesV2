namespace NotesV2
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabAllNotes = new System.Windows.Forms.TabPage();
            this.tabCreateNote = new System.Windows.Forms.TabPage();
            this.tabLogout = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabAllNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabAllNotes);
            this.materialTabControl1.Controls.Add(this.tabCreateNote);
            this.materialTabControl1.Controls.Add(this.tabLogout);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1200, 720);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabAllNotes
            // 
            this.tabAllNotes.Controls.Add(this.lblWelcome);
            this.tabAllNotes.ImageKey = "home (1).png";
            this.tabAllNotes.Location = new System.Drawing.Point(4, 39);
            this.tabAllNotes.Name = "tabAllNotes";
            this.tabAllNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllNotes.Size = new System.Drawing.Size(1192, 677);
            this.tabAllNotes.TabIndex = 0;
            this.tabAllNotes.Text = "All notes";
            this.tabAllNotes.UseVisualStyleBackColor = true;
            // 
            // tabCreateNote
            // 
            this.tabCreateNote.ImageKey = "plus.png";
            this.tabCreateNote.Location = new System.Drawing.Point(4, 39);
            this.tabCreateNote.Name = "tabCreateNote";
            this.tabCreateNote.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateNote.Size = new System.Drawing.Size(792, 407);
            this.tabCreateNote.TabIndex = 1;
            this.tabCreateNote.Text = "Create a new note";
            this.tabCreateNote.UseVisualStyleBackColor = true;
            // 
            // tabLogout
            // 
            this.tabLogout.ImageKey = "logout.png";
            this.tabLogout.Location = new System.Drawing.Point(4, 39);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.Size = new System.Drawing.Size(1192, 677);
            this.tabLogout.TabIndex = 2;
            this.tabLogout.Text = "Logout";
            this.tabLogout.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logout.png");
            this.imageList1.Images.SetKeyName(1, "plus.png");
            this.imageList1.Images.SetKeyName(2, "home (1).png");
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.Location = new System.Drawing.Point(15, 25);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(107, 19);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "materialLabel1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Dashboard";
            this.Text = "NotesV2 - Dashboard";
            this.materialTabControl1.ResumeLayout(false);
            this.tabAllNotes.ResumeLayout(false);
            this.tabAllNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabAllNotes;
        private System.Windows.Forms.TabPage tabCreateNote;
        private System.Windows.Forms.TabPage tabLogout;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel lblWelcome;
    }
}