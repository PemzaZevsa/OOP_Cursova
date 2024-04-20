namespace RegistrationScreen
{
    partial class Authorisation
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
            errorLabel = new Label();
            headingLabel = new Label();
            DontHaveAccountLabel = new Label();
            loginLabel = new Label();
            AuthorisationButton = new Button();
            loginBox = new TextBox();
            passwordLabel = new Label();
            passwordBox = new TextBox();
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
            panel2.Size = new Size(690, 519);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(errorLabel);
            panel1.Controls.Add(headingLabel);
            panel1.Controls.Add(DontHaveAccountLabel);
            panel1.Controls.Add(loginLabel);
            panel1.Controls.Add(AuthorisationButton);
            panel1.Controls.Add(loginBox);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(passwordBox);
            panel1.Location = new Point(193, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 340);
            panel1.TabIndex = 14;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(17, 200);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 20);
            errorLabel.TabIndex = 14;
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            headingLabel.Location = new Point(96, 48);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(92, 46);
            headingLabel.TabIndex = 7;
            headingLabel.Text = "Вхід";
            // 
            // DontHaveAccountLabel
            // 
            DontHaveAccountLabel.AutoSize = true;
            DontHaveAccountLabel.Cursor = Cursors.Hand;
            DontHaveAccountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            DontHaveAccountLabel.ForeColor = SystemColors.Highlight;
            DontHaveAccountLabel.Location = new Point(17, 286);
            DontHaveAccountLabel.Name = "DontHaveAccountLabel";
            DontHaveAccountLabel.Size = new Size(116, 20);
            DontHaveAccountLabel.TabIndex = 13;
            DontHaveAccountLabel.Text = "Немає аккаута?";
            DontHaveAccountLabel.Click += DontHaveAccountLabel_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(17, 94);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(47, 20);
            loginLabel.TabIndex = 8;
            loginLabel.Text = "Логін";
            // 
            // AuthorisationButton
            // 
            AuthorisationButton.Location = new Point(17, 223);
            AuthorisationButton.Name = "AuthorisationButton";
            AuthorisationButton.Size = new Size(250, 60);
            AuthorisationButton.TabIndex = 12;
            AuthorisationButton.Text = "Увійти";
            AuthorisationButton.UseVisualStyleBackColor = true;
            AuthorisationButton.Click += AuthorisationButton_Click;
            // 
            // loginBox
            // 
            loginBox.Location = new Point(17, 117);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(250, 27);
            loginBox.TabIndex = 9;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(17, 147);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(62, 20);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "Пароль";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(17, 170);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(250, 27);
            passwordBox.TabIndex = 10;
            // 
            // Authorisation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "Authorisation";
            Size = new Size(690, 519);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label DontHaveAccountLabel;
        private Button AuthorisationButton;
        private Label passwordLabel;
        private TextBox passwordBox;
        private TextBox loginBox;
        private Label loginLabel;
        private Label headingLabel;
        private Panel panel1;
        private Label errorLabel;
    }
}
