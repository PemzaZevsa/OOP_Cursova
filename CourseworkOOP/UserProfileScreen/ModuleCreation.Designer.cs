namespace UserProfileScreen
{
    partial class ModuleCreation
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
            deleteLessonButton = new Button();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            lessonsFlowLayoutPanel = new FlowLayoutPanel();
            addLessonButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(deleteLessonButton);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(lessonsFlowLayoutPanel);
            panel1.Controls.Add(addLessonButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 410);
            panel1.TabIndex = 0;
            // 
            // deleteLessonButton
            // 
            deleteLessonButton.Location = new Point(182, 107);
            deleteLessonButton.Name = "deleteLessonButton";
            deleteLessonButton.Size = new Size(159, 56);
            deleteLessonButton.TabIndex = 6;
            deleteLessonButton.Text = "Видалити урок";
            deleteLessonButton.UseVisualStyleBackColor = true;
            deleteLessonButton.Click += deleteLessonButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(248, 56);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(469, 27);
            descriptionTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(17, 59);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(45, 20);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Опис";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(17, 23);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(136, 25);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Назва модуля";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(248, 21);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(469, 27);
            nameTextBox.TabIndex = 2;
            // 
            // lessonsFlowLayoutPanel
            // 
            lessonsFlowLayoutPanel.AutoSize = true;
            lessonsFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            lessonsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            lessonsFlowLayoutPanel.Location = new Point(17, 169);
            lessonsFlowLayoutPanel.Name = "lessonsFlowLayoutPanel";
            lessonsFlowLayoutPanel.Size = new Size(700, 221);
            lessonsFlowLayoutPanel.TabIndex = 1;
            // 
            // addLessonButton
            // 
            addLessonButton.Location = new Point(17, 107);
            addLessonButton.Name = "addLessonButton";
            addLessonButton.Size = new Size(159, 56);
            addLessonButton.TabIndex = 0;
            addLessonButton.Text = "Додати урок";
            addLessonButton.UseVisualStyleBackColor = true;
            addLessonButton.Click += addLessonButton_Click;
            // 
            // ModuleCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ModuleCreation";
            Size = new Size(740, 410);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private FlowLayoutPanel lessonsFlowLayoutPanel;
        private Button addLessonButton;
        private Button deleteLessonButton;
    }
}
