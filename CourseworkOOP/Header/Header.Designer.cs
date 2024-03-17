namespace HeaderSpace
{
    partial class Header
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header));
            languageButton = new Button();
            userProfileButton = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            notificationButton = new Button();
            SearchBar = new TextBox();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // languageButton
            // 
            languageButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            languageButton.Image = (Image)resources.GetObject("languageButton.Image");
            languageButton.Location = new Point(753, 5);
            languageButton.Name = "languageButton";
            languageButton.Size = new Size(90, 90);
            languageButton.TabIndex = 1;
            languageButton.UseVisualStyleBackColor = true;
            languageButton.Click += ChangeLanguage;
            // 
            // userProfileButton
            // 
            userProfileButton.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            userProfileButton.ForeColor = SystemColors.Control;
            userProfileButton.Image = (Image)resources.GetObject("userProfileButton.Image");
            userProfileButton.Location = new Point(55, 5);
            userProfileButton.Name = "userProfileButton";
            userProfileButton.Size = new Size(90, 90);
            userProfileButton.TabIndex = 3;
            userProfileButton.UseVisualStyleBackColor = true;
            userProfileButton.Click += ToUserProfileScreen;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ToMainScreen;
            // 
            // panel1
            // 
            panel1.Controls.Add(userProfileButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(983, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 5;
            // 
            // notificationButton
            // 
            notificationButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            notificationButton.Image = (Image)resources.GetObject("notificationButton.Image");
            notificationButton.Location = new Point(873, 5);
            notificationButton.Name = "notificationButton";
            notificationButton.Size = new Size(90, 90);
            notificationButton.TabIndex = 6;
            notificationButton.UseVisualStyleBackColor = true;
            notificationButton.Click += Notifications;
            // 
            // SearchBar
            // 
            SearchBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SearchBar.BorderStyle = BorderStyle.None;
            SearchBar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            SearchBar.Location = new Point(135, 25);
            SearchBar.Multiline = true;
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(485, 50);
            SearchBar.TabIndex = 7;
            SearchBar.Text = "Шукайте що завгодно";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(619, 24);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(50, 50);
            searchButton.TabIndex = 8;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += ToSearch;
            // 
            // Header
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchButton);
            Controls.Add(SearchBar);
            Controls.Add(notificationButton);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(languageButton);
            Name = "Header";
            Size = new Size(1183, 100);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button languageButton;
        private Button userProfileButton;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button notificationButton;
        private TextBox SearchBar;
        private Button searchButton;
    }
}
