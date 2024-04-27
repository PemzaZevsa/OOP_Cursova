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
            previevPictureBox = new PictureBox();
            settingsLabel = new Label();
            pictureButton = new Button();
            label5 = new Label();
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            saveUserButton = new Button();
            label3 = new Label();
            label2 = new Label();
            passwordLabel = new Label();
            pictureFileDialog = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previevPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(previevPictureBox);
            panel1.Controls.Add(settingsLabel);
            panel1.Controls.Add(pictureButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(surnameTextBox);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(saveUserButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(passwordLabel);
            panel1.Location = new Point(24, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 564);
            panel1.TabIndex = 0;
            // 
            // previevPictureBox
            // 
            previevPictureBox.BorderStyle = BorderStyle.FixedSingle;
            previevPictureBox.Location = new Point(370, 226);
            previevPictureBox.Name = "previevPictureBox";
            previevPictureBox.Size = new Size(150, 150);
            previevPictureBox.TabIndex = 12;
            previevPictureBox.TabStop = false;
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            settingsLabel.Location = new Point(145, 10);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(265, 46);
            settingsLabel.TabIndex = 11;
            settingsLabel.Text = "Налаштування";
            // 
            // pictureButton
            // 
            pictureButton.Location = new Point(320, 382);
            pictureButton.Name = "pictureButton";
            pictureButton.Size = new Size(200, 54);
            pictureButton.TabIndex = 3;
            pictureButton.Text = "Вибрати файл";
            pictureButton.UseVisualStyleBackColor = true;
            pictureButton.Click += pictureButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 416);
            label5.Name = "label5";
            label5.Size = new Size(221, 20);
            label5.TabIndex = 10;
            label5.Text = "Змінити зображення профілю";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(320, 193);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(200, 27);
            surnameTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(320, 143);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 27);
            nameTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(320, 93);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 27);
            passwordTextBox.TabIndex = 6;
            // 
            // saveUserButton
            // 
            saveUserButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            saveUserButton.ForeColor = Color.FromArgb(0, 192, 0);
            saveUserButton.Location = new Point(120, 480);
            saveUserButton.Name = "saveUserButton";
            saveUserButton.Size = new Size(300, 60);
            saveUserButton.TabIndex = 4;
            saveUserButton.Text = "Зберегти зміни";
            saveUserButton.UseVisualStyleBackColor = true;
            saveUserButton.Click += saveUserButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 200);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Прізвище";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 150);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Ім'я";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(20, 100);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(62, 20);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Пароль";
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
            Size = new Size(660, 606);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previevPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private TextBox passwordTextBox;
        private Button saveUserButton;
        private Button pictureButton;
        private Label label3;
        private Label label2;
        private Label passwordLabel;
        private Label label5;
        private Label settingsLabel;
        private OpenFileDialog pictureFileDialog;
        private PictureBox previevPictureBox;
    }
}
