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
            settingsLabel = new Label();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            saveUserButton = new Button();
            label3 = new Label();
            label2 = new Label();
            passwordLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(settingsLabel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(saveUserButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(passwordLabel);
            panel1.Location = new Point(24, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 512);
            panel1.TabIndex = 0;
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            settingsLabel.Location = new Point(135, 20);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(265, 46);
            settingsLabel.TabIndex = 11;
            settingsLabel.Text = "Налаштування";
            // 
            // button1
            // 
            button1.Location = new Point(399, 266);
            button1.Name = "button1";
            button1.Size = new Size(121, 54);
            button1.TabIndex = 3;
            button1.Text = "Вибрати файл";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 300);
            label5.Name = "label5";
            label5.Size = new Size(221, 20);
            label5.TabIndex = 10;
            label5.Text = "Змінити зображення профілю";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 250);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(348, 193);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(348, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(348, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 6;
            // 
            // saveUserButton
            // 
            saveUserButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            saveUserButton.ForeColor = Color.FromArgb(0, 192, 0);
            saveUserButton.Location = new Point(120, 400);
            saveUserButton.Name = "saveUserButton";
            saveUserButton.Size = new Size(300, 60);
            saveUserButton.TabIndex = 4;
            saveUserButton.Text = "Зберегти зміни";
            saveUserButton.UseVisualStyleBackColor = true;
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
            // UserSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserSettings";
            Size = new Size(639, 551);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button saveUserButton;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label passwordLabel;
        private Label label5;
        private Label label4;
        private Label settingsLabel;
    }
}
