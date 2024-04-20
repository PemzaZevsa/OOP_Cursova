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
            userProfileButton = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            SearchBar = new TextBox();
            searchButton = new Button();
            nameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(userProfileButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(983, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 5;
            // 
            // SearchBar
            // 
            SearchBar.BorderStyle = BorderStyle.None;
            SearchBar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SearchBar.Location = new Point(186, 25);
            SearchBar.Multiline = true;
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderText = "Шукайте що завгодно";
            SearchBar.Size = new Size(639, 50);
            SearchBar.TabIndex = 7;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(824, 25);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(50, 50);
            searchButton.TabIndex = 8;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += ToSearch;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 44);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 20);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "label1";
            // 
            // Header
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchButton);
            Controls.Add(SearchBar);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Header";
            Size = new Size(1183, 100);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button userProfileButton;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox SearchBar;
        private Button searchButton;
        private Label nameLabel;
    }
}
