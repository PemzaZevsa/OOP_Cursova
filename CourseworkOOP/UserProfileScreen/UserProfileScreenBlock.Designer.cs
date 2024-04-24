namespace UserProfileScreen
{
    partial class UserProfileScreenBlock
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
            buttonPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            iTeachebleButton = new Button();
            settingsButton = new Button();
            logOutButton = new Button();
            istudyableButton = new Button();
            iControlableButton = new Button();
            userProfilePictureBox = new PictureBox();
            infoPanel = new Panel();
            userSettings1 = new UserSettings();
            buttonPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userProfilePictureBox).BeginInit();
            infoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = SystemColors.ActiveBorder;
            buttonPanel.Controls.Add(tableLayoutPanel1);
            buttonPanel.Controls.Add(userProfilePictureBox);
            buttonPanel.Dock = DockStyle.Left;
            buttonPanel.Location = new Point(0, 0);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(300, 598);
            buttonPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(iTeachebleButton, 0, 2);
            tableLayoutPanel1.Controls.Add(settingsButton, 0, 0);
            tableLayoutPanel1.Controls.Add(logOutButton, 0, 4);
            tableLayoutPanel1.Controls.Add(istudyableButton, 0, 1);
            tableLayoutPanel1.Controls.Add(iControlableButton, 0, 3);
            tableLayoutPanel1.Location = new Point(25, 306);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(250, 301);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // iTeachebleButton
            // 
            iTeachebleButton.Location = new Point(3, 123);
            iTeachebleButton.Name = "iTeachebleButton";
            iTeachebleButton.Size = new Size(244, 54);
            iTeachebleButton.TabIndex = 3;
            iTeachebleButton.Text = "Створені курси";
            iTeachebleButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(3, 3);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(244, 54);
            settingsButton.TabIndex = 0;
            settingsButton.Text = "Налаштування";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += button1_Click;
            // 
            // logOutButton
            // 
            logOutButton.ForeColor = Color.Red;
            logOutButton.Location = new Point(3, 243);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(244, 55);
            logOutButton.TabIndex = 2;
            logOutButton.Text = "Вийти з облікового запису";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // istudyableButton
            // 
            istudyableButton.Location = new Point(3, 63);
            istudyableButton.Name = "istudyableButton";
            istudyableButton.Size = new Size(244, 54);
            istudyableButton.TabIndex = 1;
            istudyableButton.Text = "Моє навчання";
            istudyableButton.UseVisualStyleBackColor = true;
            // 
            // iControlableButton
            // 
            iControlableButton.Location = new Point(3, 183);
            iControlableButton.Name = "iControlableButton";
            iControlableButton.Size = new Size(244, 54);
            iControlableButton.TabIndex = 4;
            iControlableButton.Text = "Користувачі";
            iControlableButton.UseVisualStyleBackColor = true;
            // 
            // userProfilePictureBox
            // 
            userProfilePictureBox.Location = new Point(25, 50);
            userProfilePictureBox.Name = "userProfilePictureBox";
            userProfilePictureBox.Size = new Size(250, 250);
            userProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userProfilePictureBox.TabIndex = 3;
            userProfilePictureBox.TabStop = false;
            // 
            // infoPanel
            // 
            infoPanel.BackColor = SystemColors.ControlLightLight;
            infoPanel.Controls.Add(userSettings1);
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.Location = new Point(300, 0);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(702, 598);
            infoPanel.TabIndex = 1;
            // 
            // userSettings1
            // 
            userSettings1.Dock = DockStyle.Fill;
            userSettings1.Location = new Point(0, 0);
            userSettings1.Name = "userSettings1";
            userSettings1.Size = new Size(702, 598);
            userSettings1.TabIndex = 0;
            // 
            // UserProfileScreenBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(infoPanel);
            Controls.Add(buttonPanel);
            Name = "UserProfileScreenBlock";
            Size = new Size(1002, 598);
            buttonPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userProfilePictureBox).EndInit();
            infoPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel buttonPanel;
        private Button logOutButton;
        private Button istudyableButton;
        private Button settingsButton;
        private Panel infoPanel;
        private PictureBox userProfilePictureBox;
        private TableLayoutPanel tableLayoutPanel1;
        private UserSettings userSettings1;
        private Button iTeachebleButton;
        private Button iControlableButton;
    }
}
