namespace UserProfileScreen
{
    partial class Statistics
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
            userCreatedLabel = new Label();
            lessonsCreatedLabel = new Label();
            moduleCreatedLabel = new Label();
            coursesCreatedLabel = new Label();
            statisticsLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(userCreatedLabel);
            panel1.Controls.Add(lessonsCreatedLabel);
            panel1.Controls.Add(moduleCreatedLabel);
            panel1.Controls.Add(coursesCreatedLabel);
            panel1.Controls.Add(statisticsLabel);
            panel1.Location = new Point(100, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 460);
            panel1.TabIndex = 0;
            // 
            // userCreatedLabel
            // 
            userCreatedLabel.AutoSize = true;
            userCreatedLabel.Location = new Point(30, 230);
            userCreatedLabel.Name = "userCreatedLabel";
            userCreatedLabel.Size = new Size(216, 20);
            userCreatedLabel.TabIndex = 4;
            userCreatedLabel.Text = "Користувачів зареєстровано :";
            // 
            // lessonsCreatedLabel
            // 
            lessonsCreatedLabel.AutoSize = true;
            lessonsCreatedLabel.Location = new Point(30, 180);
            lessonsCreatedLabel.Name = "lessonsCreatedLabel";
            lessonsCreatedLabel.Size = new Size(131, 20);
            lessonsCreatedLabel.TabIndex = 3;
            lessonsCreatedLabel.Text = "Уроків створено :";
            // 
            // moduleCreatedLabel
            // 
            moduleCreatedLabel.AutoSize = true;
            moduleCreatedLabel.Location = new Point(30, 130);
            moduleCreatedLabel.Name = "moduleCreatedLabel";
            moduleCreatedLabel.Size = new Size(142, 20);
            moduleCreatedLabel.TabIndex = 2;
            moduleCreatedLabel.Text = "Модулів створено :";
            // 
            // coursesCreatedLabel
            // 
            coursesCreatedLabel.AutoSize = true;
            coursesCreatedLabel.Location = new Point(30, 80);
            coursesCreatedLabel.Name = "coursesCreatedLabel";
            coursesCreatedLabel.Size = new Size(129, 20);
            coursesCreatedLabel.TabIndex = 1;
            coursesCreatedLabel.Text = "Курсів створено :";
            // 
            // statisticsLabel
            // 
            statisticsLabel.AutoSize = true;
            statisticsLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            statisticsLabel.Location = new Point(130, 9);
            statisticsLabel.Name = "statisticsLabel";
            statisticsLabel.Size = new Size(199, 46);
            statisticsLabel.TabIndex = 0;
            statisticsLabel.Text = "Статистика";
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Statistics";
            Size = new Size(600, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label userCreatedLabel;
        private Label lessonsCreatedLabel;
        private Label moduleCreatedLabel;
        private Label coursesCreatedLabel;
        private Label statisticsLabel;
    }
}
