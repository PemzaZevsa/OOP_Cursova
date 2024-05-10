namespace UserProfileScreen
{
    partial class UserSettings
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            stuffPanel = new Panel();
            panel5 = new Panel();
            passwordTextBox = new TextBox();
            nameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            panel4 = new Panel();
            passwordLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            saveUserButton = new Button();
            settingsLabel = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureFileDialog = new OpenFileDialog();
            panel1.SuspendLayout();
            stuffPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(stuffPanel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 606);
            panel1.TabIndex = 0;
            // 
            // stuffPanel
            // 
            stuffPanel.AutoSize = true;
            stuffPanel.Controls.Add(panel5);
            stuffPanel.Controls.Add(panel4);
            stuffPanel.Controls.Add(saveUserButton);
            stuffPanel.Controls.Add(settingsLabel);
            stuffPanel.Dock = DockStyle.Fill;
            stuffPanel.Location = new Point(150, 0);
            stuffPanel.Name = "stuffPanel";
            stuffPanel.Size = new Size(619, 606);
            stuffPanel.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(passwordTextBox);
            panel5.Controls.Add(nameTextBox);
            panel5.Controls.Add(surnameTextBox);
            panel5.Location = new Point(374, 93);
            panel5.Name = "panel5";
            panel5.Size = new Size(226, 139);
            panel5.TabIndex = 13;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(15, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 27);
            passwordTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(15, 53);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 27);
            nameTextBox.TabIndex = 7;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(15, 103);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(200, 27);
            surnameTextBox.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(passwordLabel);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(25, 93);
            panel4.Name = "panel4";
            panel4.Size = new Size(124, 139);
            panel4.TabIndex = 12;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(3, 3);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(62, 20);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 103);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Прізвище";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Ім'я";
            // 
            // saveUserButton
            // 
            saveUserButton.Anchor = AnchorStyles.None;
            saveUserButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            saveUserButton.ForeColor = Color.FromArgb(0, 192, 0);
            saveUserButton.Location = new Point(150, 450);
            saveUserButton.Name = "saveUserButton";
            saveUserButton.Size = new Size(313, 65);
            saveUserButton.TabIndex = 4;
            saveUserButton.Text = "Зберегти зміни";
            saveUserButton.UseVisualStyleBackColor = true;
            saveUserButton.Click += saveUserButton_Click;
            // 
            // settingsLabel
            // 
            settingsLabel.Anchor = AnchorStyles.None;
            settingsLabel.AutoSize = true;
            settingsLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            settingsLabel.Location = new Point(174, 10);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(265, 46);
            settingsLabel.TabIndex = 11;
            settingsLabel.Text = "Налаштування";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(769, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 606);
            panel3.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 606);
            panel2.TabIndex = 14;
            // 
            // pictureFileDialog
            // 
            pictureFileDialog.FileName = "openFileDialog1";
            pictureFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp";
            // 
            // UserSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserSettings";
            Size = new Size(919, 606);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            stuffPanel.ResumeLayout(false);
            stuffPanel.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private OpenFileDialog pictureFileDialog;
        private Panel stuffPanel;
        private Button saveUserButton;
        private Label settingsLabel;
        private Label passwordLabel;
        private Label label2;
        private TextBox surnameTextBox;
        private Label label3;
        private TextBox nameTextBox;
        private TextBox passwordTextBox;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
    }
}
