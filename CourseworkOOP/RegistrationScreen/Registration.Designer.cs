namespace RegistrationScreen
{
    partial class Registration
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
            panel2 = new Panel();
            panel1 = new Panel();
            WhoAreYouLabel = new Label();
            userTypeBox = new ComboBox();
            errorLabel = new Label();
            AlreadyHaveAccountLabel = new Label();
            headingLabel = new Label();
            loginLabel = new Label();
            RegestrationButton = new Button();
            loginBox = new TextBox();
            passwordLabel = new Label();
            surnameLabel = new Label();
            passwordBox = new TextBox();
            nameLabel = new Label();
            nameBox = new TextBox();
            surnameBox = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(652, 557);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(WhoAreYouLabel);
            panel1.Controls.Add(userTypeBox);
            panel1.Controls.Add(errorLabel);
            panel1.Controls.Add(AlreadyHaveAccountLabel);
            panel1.Controls.Add(headingLabel);
            panel1.Controls.Add(loginLabel);
            panel1.Controls.Add(RegestrationButton);
            panel1.Controls.Add(loginBox);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(surnameLabel);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(surnameBox);
            panel1.Location = new Point(164, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 495);
            panel1.TabIndex = 14;
            // 
            // WhoAreYouLabel
            // 
            WhoAreYouLabel.AutoSize = true;
            WhoAreYouLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            WhoAreYouLabel.ForeColor = SystemColors.ControlLightLight;
            WhoAreYouLabel.Location = new Point(4, 294);
            WhoAreYouLabel.Name = "WhoAreYouLabel";
            WhoAreYouLabel.Size = new Size(69, 25);
            WhoAreYouLabel.TabIndex = 16;
            WhoAreYouLabel.Text = "Хто ви";
            // 
            // userTypeBox
            // 
            userTypeBox.FormattingEnabled = true;
            userTypeBox.Items.AddRange(new object[] { "Студент", "Вчитель" });
            userTypeBox.Location = new Point(4, 322);
            userTypeBox.Name = "userTypeBox";
            userTypeBox.Size = new Size(250, 28);
            userTypeBox.TabIndex = 15;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(4, 322);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 20);
            errorLabel.TabIndex = 14;
            // 
            // AlreadyHaveAccountLabel
            // 
            AlreadyHaveAccountLabel.AutoSize = true;
            AlreadyHaveAccountLabel.Cursor = Cursors.Hand;
            AlreadyHaveAccountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            AlreadyHaveAccountLabel.ForeColor = SystemColors.Highlight;
            AlreadyHaveAccountLabel.Location = new Point(4, 451);
            AlreadyHaveAccountLabel.Name = "AlreadyHaveAccountLabel";
            AlreadyHaveAccountLabel.Size = new Size(104, 20);
            AlreadyHaveAccountLabel.TabIndex = 12;
            AlreadyHaveAccountLabel.Text = "Вже є аккаунт";
            AlreadyHaveAccountLabel.Click += AlreadyHaveAccountLabel_Click;
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            headingLabel.ForeColor = SystemColors.ControlLightLight;
            headingLabel.Location = new Point(31, 8);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(195, 46);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Реєстрація";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.ForeColor = SystemColors.ControlLightLight;
            loginLabel.Location = new Point(4, 62);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(59, 25);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логін";
            // 
            // RegestrationButton
            // 
            RegestrationButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegestrationButton.Location = new Point(4, 388);
            RegestrationButton.Name = "RegestrationButton";
            RegestrationButton.Size = new Size(250, 60);
            RegestrationButton.TabIndex = 2;
            RegestrationButton.Text = "Зареєструватися";
            RegestrationButton.UseVisualStyleBackColor = true;
            RegestrationButton.Click += RegestrationButton_Click;
            // 
            // loginBox
            // 
            loginBox.Location = new Point(4, 90);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(250, 27);
            loginBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            passwordLabel.ForeColor = SystemColors.ControlLightLight;
            passwordLabel.Location = new Point(4, 120);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(79, 25);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Пароль";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            surnameLabel.ForeColor = SystemColors.ControlLightLight;
            surnameLabel.Location = new Point(4, 236);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(98, 25);
            surnameLabel.TabIndex = 9;
            surnameLabel.Text = "Прізвище";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(4, 148);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(250, 27);
            passwordBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            nameLabel.ForeColor = SystemColors.ControlLightLight;
            nameLabel.Location = new Point(4, 178);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(47, 25);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Ім'я";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(3, 206);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(250, 27);
            nameBox.TabIndex = 6;
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(4, 264);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(250, 27);
            surnameBox.TabIndex = 7;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "Registration";
            Size = new Size(652, 557);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label passwordLabel;
        private TextBox loginBox;
        private Button RegestrationButton;
        private Label loginLabel;
        private Label headingLabel;
        private Label surnameLabel;
        private Label nameLabel;
        private TextBox surnameBox;
        private TextBox nameBox;
        private TextBox passwordBox;
        private Label AlreadyHaveAccountLabel;
        private Panel panel1;
        private Label errorLabel;
        private ComboBox userTypeBox;
        private Label WhoAreYouLabel;
    }
}
