namespace Header
{
    partial class Authorised
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
            nameLabel = new Label();
            userProfileButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(userProfileButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 120);
            panel1.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(41, 96);
            nameLabel.MaximumSize = new Size(180, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(111, 20);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name Surname";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userProfileButton
            // 
            userProfileButton.BackgroundImage = Properties.Resources.UserProfile_Icon;
            userProfileButton.BackgroundImageLayout = ImageLayout.Stretch;
            userProfileButton.Cursor = Cursors.Hand;
            userProfileButton.FlatStyle = FlatStyle.Popup;
            userProfileButton.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            userProfileButton.ForeColor = SystemColors.Control;
            userProfileButton.Location = new Point(51, 3);
            userProfileButton.Name = "userProfileButton";
            userProfileButton.Size = new Size(90, 90);
            userProfileButton.TabIndex = 3;
            userProfileButton.UseVisualStyleBackColor = true;
            userProfileButton.Click += userProfileButton_Click;
            // 
            // Authorised
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Authorised";
            Size = new Size(200, 120);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label nameLabel;
        private Button userProfileButton;
    }
}
