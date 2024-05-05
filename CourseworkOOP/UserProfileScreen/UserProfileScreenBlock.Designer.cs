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
            userTypeLabel = new Label();
            surnameLabel = new Label();
            settingsButton = new Button();
            nameLabel = new Label();
            buttonsTableLayoutPanel = new TableLayoutPanel();
            statisticButton = new Button();
            iControlableButton = new Button();
            iTeachebleButton = new Button();
            istudyableButton = new Button();
            logOutButton = new Button();
            infoPanel = new Panel();
            buttonPanel.SuspendLayout();
            buttonsTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = SystemColors.AppWorkspace;
            buttonPanel.Controls.Add(userTypeLabel);
            buttonPanel.Controls.Add(surnameLabel);
            buttonPanel.Controls.Add(settingsButton);
            buttonPanel.Controls.Add(nameLabel);
            buttonPanel.Controls.Add(buttonsTableLayoutPanel);
            buttonPanel.Controls.Add(logOutButton);
            buttonPanel.Dock = DockStyle.Left;
            buttonPanel.Location = new Point(0, 0);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(300, 683);
            buttonPanel.TabIndex = 0;
            // 
            // userTypeLabel
            // 
            userTypeLabel.AutoSize = true;
            userTypeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userTypeLabel.ForeColor = SystemColors.ControlLightLight;
            userTypeLabel.Location = new Point(25, 200);
            userTypeLabel.Name = "userTypeLabel";
            userTypeLabel.Size = new Size(142, 20);
            userTypeLabel.TabIndex = 5;
            userTypeLabel.Text = "Тип користувача : ";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.ForeColor = SystemColors.ControlLightLight;
            surnameLabel.Location = new Point(25, 150);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(113, 25);
            surnameLabel.TabIndex = 4;
            surnameLabel.Text = "Прізвище : ";
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(28, 272);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(244, 54);
            settingsButton.TabIndex = 0;
            settingsButton.Text = "Налаштування";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.ForeColor = SystemColors.ControlLightLight;
            nameLabel.Location = new Point(25, 100);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 25);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Ім'я : ";
            // 
            // buttonsTableLayoutPanel
            // 
            buttonsTableLayoutPanel.ColumnCount = 1;
            buttonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonsTableLayoutPanel.Controls.Add(statisticButton, 0, 3);
            buttonsTableLayoutPanel.Controls.Add(iControlableButton, 0, 2);
            buttonsTableLayoutPanel.Controls.Add(iTeachebleButton, 0, 1);
            buttonsTableLayoutPanel.Controls.Add(istudyableButton, 0, 0);
            buttonsTableLayoutPanel.Location = new Point(25, 329);
            buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            buttonsTableLayoutPanel.RowCount = 4;
            buttonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buttonsTableLayoutPanel.Size = new Size(250, 251);
            buttonsTableLayoutPanel.TabIndex = 0;
            // 
            // statisticButton
            // 
            statisticButton.Location = new Point(3, 189);
            statisticButton.Name = "statisticButton";
            statisticButton.Size = new Size(244, 54);
            statisticButton.TabIndex = 4;
            statisticButton.Text = "Статистика";
            statisticButton.UseVisualStyleBackColor = true;
            statisticButton.Click += statisticButton_Click;
            // 
            // iControlableButton
            // 
            iControlableButton.Location = new Point(3, 127);
            iControlableButton.Name = "iControlableButton";
            iControlableButton.Size = new Size(244, 54);
            iControlableButton.TabIndex = 4;
            iControlableButton.Text = "Користувачі";
            iControlableButton.UseVisualStyleBackColor = true;
            iControlableButton.Click += iControlableButton_Click;
            // 
            // iTeachebleButton
            // 
            iTeachebleButton.Location = new Point(3, 65);
            iTeachebleButton.Name = "iTeachebleButton";
            iTeachebleButton.Size = new Size(244, 54);
            iTeachebleButton.TabIndex = 3;
            iTeachebleButton.Text = "Створені курси";
            iTeachebleButton.UseVisualStyleBackColor = true;
            iTeachebleButton.Click += iTeachebleButton_Click;
            // 
            // istudyableButton
            // 
            istudyableButton.Location = new Point(3, 3);
            istudyableButton.Name = "istudyableButton";
            istudyableButton.Size = new Size(244, 54);
            istudyableButton.TabIndex = 1;
            istudyableButton.Text = "Моє навчання";
            istudyableButton.UseVisualStyleBackColor = true;
            istudyableButton.Click += istudyableButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.ForeColor = Color.Red;
            logOutButton.Location = new Point(31, 613);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(244, 55);
            logOutButton.TabIndex = 2;
            logOutButton.Text = "Вийти з облікового запису";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // infoPanel
            // 
            infoPanel.BackColor = SystemColors.ControlLightLight;
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.Location = new Point(300, 0);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(702, 683);
            infoPanel.TabIndex = 1;
            // 
            // UserProfileScreenBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(infoPanel);
            Controls.Add(buttonPanel);
            Name = "UserProfileScreenBlock";
            Size = new Size(1002, 683);
            buttonPanel.ResumeLayout(false);
            buttonPanel.PerformLayout();
            buttonsTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel buttonPanel;
        private Button logOutButton;
        private Button istudyableButton;
        private Button settingsButton;
        private Panel infoPanel;
        private TableLayoutPanel buttonsTableLayoutPanel;
        private Button iTeachebleButton;
        private Button iControlableButton;
        private Button statisticButton;
        private Label userTypeLabel;
        private Label surnameLabel;
        private Label nameLabel;
    }
}
