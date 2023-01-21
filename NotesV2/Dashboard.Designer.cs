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
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.tabCreateNote = new System.Windows.Forms.TabPage();
            this.btnSaveNote = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txbDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txbTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.tabContactAdmin = new System.Windows.Forms.TabPage();
            this.tabLogout = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.materialTabControl1.SuspendLayout();
            this.tabAllNotes.SuspendLayout();
            this.tabCreateNote.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabAllNotes);
            this.materialTabControl1.Controls.Add(this.tabCreateNote);
            this.materialTabControl1.Controls.Add(this.tabSearch);
            this.materialTabControl1.Controls.Add(this.tabAccount);
            this.materialTabControl1.Controls.Add(this.tabStats);
            this.materialTabControl1.Controls.Add(this.tabContactAdmin);
            this.materialTabControl1.Controls.Add(this.tabLogout);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1050, 720);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tabAllNotes
            // 
            this.tabAllNotes.Controls.Add(this.materialFloatingActionButton3);
            this.tabAllNotes.Controls.Add(this.materialCard3);
            this.tabAllNotes.Controls.Add(this.materialFloatingActionButton2);
            this.tabAllNotes.Controls.Add(this.materialCard2);
            this.tabAllNotes.Controls.Add(this.materialFloatingActionButton1);
            this.tabAllNotes.Controls.Add(this.materialCard1);
            this.tabAllNotes.Controls.Add(this.lblWelcome);
            this.tabAllNotes.ImageKey = "home (1).png";
            this.tabAllNotes.Location = new System.Drawing.Point(4, 39);
            this.tabAllNotes.Name = "tabAllNotes";
            this.tabAllNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllNotes.Size = new System.Drawing.Size(1042, 677);
            this.tabAllNotes.TabIndex = 0;
            this.tabAllNotes.Text = "All notes";
            this.tabAllNotes.UseVisualStyleBackColor = true;
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
            // tabCreateNote
            // 
            this.tabCreateNote.Controls.Add(this.btnSaveNote);
            this.tabCreateNote.Controls.Add(this.materialDivider1);
            this.tabCreateNote.Controls.Add(this.txbDescription);
            this.tabCreateNote.Controls.Add(this.materialLabel3);
            this.tabCreateNote.Controls.Add(this.materialLabel2);
            this.tabCreateNote.Controls.Add(this.txbTitle);
            this.tabCreateNote.Controls.Add(this.materialLabel1);
            this.tabCreateNote.ImageKey = "plus.png";
            this.tabCreateNote.Location = new System.Drawing.Point(4, 39);
            this.tabCreateNote.Name = "tabCreateNote";
            this.tabCreateNote.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateNote.Size = new System.Drawing.Size(1192, 677);
            this.tabCreateNote.TabIndex = 1;
            this.tabCreateNote.Text = "Create a new note";
            this.tabCreateNote.UseVisualStyleBackColor = true;
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.AutoSize = false;
            this.btnSaveNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveNote.Depth = 0;
            this.btnSaveNote.DrawShadows = true;
            this.btnSaveNote.HighEmphasis = true;
            this.btnSaveNote.Icon = null;
            this.btnSaveNote.Location = new System.Drawing.Point(15, 350);
            this.btnSaveNote.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(300, 50);
            this.btnSaveNote.TabIndex = 7;
            this.btnSaveNote.Text = "Save note";
            this.btnSaveNote.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveNote.UseAccentColor = false;
            this.btnSaveNote.UseVisualStyleBackColor = true;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(15, 317);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(300, 23);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txbDescription
            // 
            this.txbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDescription.Depth = 0;
            this.txbDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txbDescription.Hint = "";
            this.txbDescription.Location = new System.Drawing.Point(15, 215);
            this.txbDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(300, 96);
            this.txbDescription.TabIndex = 5;
            this.txbDescription.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(15, 193);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Description";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(15, 93);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(32, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Title";
            // 
            // txbTitle
            // 
            this.txbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTitle.Depth = 0;
            this.txbTitle.Font = new System.Drawing.Font("Roboto", 12F);
            this.txbTitle.Location = new System.Drawing.Point(15, 115);
            this.txbTitle.MaxLength = 50;
            this.txbTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTitle.Multiline = false;
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(300, 50);
            this.txbTitle.TabIndex = 1;
            this.txbTitle.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(15, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(183, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Add new Note in seconds!";
            // 
            // tabSearch
            // 
            this.tabSearch.ImageKey = "search.png";
            this.tabSearch.Location = new System.Drawing.Point(4, 39);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(1192, 677);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "Search notes";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // tabAccount
            // 
            this.tabAccount.ImageKey = "user.png";
            this.tabAccount.Location = new System.Drawing.Point(4, 39);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(1192, 677);
            this.tabAccount.TabIndex = 4;
            this.tabAccount.Text = "View your account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // tabStats
            // 
            this.tabStats.ImageKey = "trend.png";
            this.tabStats.Location = new System.Drawing.Point(4, 39);
            this.tabStats.Name = "tabStats";
            this.tabStats.Size = new System.Drawing.Size(1192, 677);
            this.tabStats.TabIndex = 5;
            this.tabStats.Text = "View your stats";
            this.tabStats.UseVisualStyleBackColor = true;
            // 
            // tabContactAdmin
            // 
            this.tabContactAdmin.ImageKey = "contact.png";
            this.tabContactAdmin.Location = new System.Drawing.Point(4, 39);
            this.tabContactAdmin.Name = "tabContactAdmin";
            this.tabContactAdmin.Size = new System.Drawing.Size(1192, 677);
            this.tabContactAdmin.TabIndex = 6;
            this.tabContactAdmin.Text = "Contact the administrator";
            this.tabContactAdmin.UseVisualStyleBackColor = true;
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
            this.imageList1.Images.SetKeyName(3, "search.png");
            this.imageList1.Images.SetKeyName(4, "trend.png");
            this.imageList1.Images.SetKeyName(5, "user.png");
            this.imageList1.Images.SetKeyName(6, "contact.png");
            this.imageList1.Images.SetKeyName(7, "icons8-borrow-book-32 (1).png");
            this.imageList1.Images.SetKeyName(8, "icons8-borrow-book-32 (1).png");
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.richTextBox1);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(19, 72);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(273, 126);
            this.materialCard1.TabIndex = 2;
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.AnimateShowHideButton = false;
            this.materialFloatingActionButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.DrawShadows = true;
            this.materialFloatingActionButton1.ForeColor = System.Drawing.SystemColors.Menu;
            this.materialFloatingActionButton1.Icon = global::NotesV2.Properties.Resources.icons8_borrow_book_32__2_;
            this.materialFloatingActionButton1.Image = global::NotesV2.Properties.Resources.icons8_borrow_book_32__2_;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(264, 109);
            this.materialFloatingActionButton1.Mini = false;
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 3;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Controls.Add(this.richTextBox2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(337, 72);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(273, 126);
            this.materialCard2.TabIndex = 4;
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.AnimateShowHideButton = false;
            this.materialFloatingActionButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.DrawShadows = true;
            this.materialFloatingActionButton2.ForeColor = System.Drawing.SystemColors.Menu;
            this.materialFloatingActionButton2.Icon = global::NotesV2.Properties.Resources.icons8_borrow_book_32__2_;
            this.materialFloatingActionButton2.Image = global::NotesV2.Properties.Resources.icons8_borrow_book_32__2_;
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(582, 109);
            this.materialFloatingActionButton2.Mini = false;
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton2.TabIndex = 5;
            this.materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.label3);
            this.materialCard3.Controls.Add(this.richTextBox3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(655, 72);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(273, 126);
            this.materialCard3.TabIndex = 6;
            // 
            // materialFloatingActionButton3
            // 
            this.materialFloatingActionButton3.AnimateShowHideButton = false;
            this.materialFloatingActionButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFloatingActionButton3.Depth = 0;
            this.materialFloatingActionButton3.DrawShadows = true;
            this.materialFloatingActionButton3.ForeColor = System.Drawing.SystemColors.Menu;
            this.materialFloatingActionButton3.Icon = global::NotesV2.Properties.Resources.icons8_borrow_book_32__2_;
            this.materialFloatingActionButton3.Image = global::NotesV2.Properties.Resources.icons8_borrow_book_32__2_;
            this.materialFloatingActionButton3.Location = new System.Drawing.Point(900, 109);
            this.materialFloatingActionButton3.Mini = false;
            this.materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton3.TabIndex = 7;
            this.materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(219, 84);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(20, 35);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(219, 84);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(17, 37);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(219, 84);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 720);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerWidth = 300;
            this.Name = "Dashboard";
            this.Text = "NotesV2 - Dashboard";
            this.materialTabControl1.ResumeLayout(false);
            this.tabAllNotes.ResumeLayout(false);
            this.tabAllNotes.PerformLayout();
            this.tabCreateNote.ResumeLayout(false);
            this.tabCreateNote.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabAllNotes;
        private System.Windows.Forms.TabPage tabCreateNote;
        private System.Windows.Forms.TabPage tabLogout;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel lblWelcome;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.TabPage tabContactAdmin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txbTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txbDescription;
        private MaterialSkin.Controls.MaterialButton btnSaveNote;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}