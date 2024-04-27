namespace HeaderSpace
{
    partial class HeaderBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderBlock));
            pictureBox1 = new PictureBox();
            searchBar = new TextBox();
            searchButton = new Button();
            panel1 = new Panel();
            unAuthorised = new Header.UnAuthorised();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ToMainScreen;
            // 
            // searchBar
            // 
            searchBar.BorderStyle = BorderStyle.None;
            searchBar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchBar.Location = new Point(186, 30);
            searchBar.Multiline = true;
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Шукайте що завгодно";
            searchBar.Size = new Size(639, 50);
            searchBar.TabIndex = 7;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(831, 30);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(50, 50);
            searchButton.TabIndex = 8;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += ToSearch;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(unAuthorised);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(981, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 118);
            panel1.TabIndex = 5;
            // 
            // unAuthorised
            // 
            unAuthorised.Dock = DockStyle.Fill;
            unAuthorised.Location = new Point(0, 0);
            unAuthorised.Name = "unAuthorised";
            unAuthorised.Size = new Size(200, 118);
            unAuthorised.TabIndex = 0;
            // 
            // HeaderBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(searchButton);
            Controls.Add(searchBar);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "HeaderBlock";
            Size = new Size(1181, 118);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button searchButton;
        private Panel panel1;
        private Header.UnAuthorised unAuthorised;
        public TextBox searchBar;
    }
}
