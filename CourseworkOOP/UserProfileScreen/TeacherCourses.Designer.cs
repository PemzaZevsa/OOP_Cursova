namespace UserProfileScreen
{
    partial class TeacherCourses
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
            coursesFlowLayoutPanel = new FlowLayoutPanel();
            createButton = new Button();
            loadMoreButton = new Button();
            SuspendLayout();
            // 
            // coursesFlowLayoutPanel
            // 
            coursesFlowLayoutPanel.AutoSize = true;
            coursesFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            coursesFlowLayoutPanel.Location = new Point(40, 87);
            coursesFlowLayoutPanel.Name = "coursesFlowLayoutPanel";
            coursesFlowLayoutPanel.Size = new Size(719, 420);
            coursesFlowLayoutPanel.TabIndex = 0;
            // 
            // createButton
            // 
            createButton.Location = new Point(40, 21);
            createButton.Name = "createButton";
            createButton.Size = new Size(200, 60);
            createButton.TabIndex = 1;
            createButton.Text = "Створити новий курс";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // loadMoreButton
            // 
            loadMoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loadMoreButton.Location = new Point(530, 21);
            loadMoreButton.Name = "loadMoreButton";
            loadMoreButton.Size = new Size(229, 60);
            loadMoreButton.TabIndex = 2;
            loadMoreButton.Text = "Завантажити наступні курси";
            loadMoreButton.UseVisualStyleBackColor = true;
            loadMoreButton.Click += loadMoreButton_Click;
            // 
            // TeacherCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(loadMoreButton);
            Controls.Add(createButton);
            Controls.Add(coursesFlowLayoutPanel);
            Name = "TeacherCourses";
            Size = new Size(803, 542);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel coursesFlowLayoutPanel;
        private Button createButton;
        private Button loadMoreButton;
    }
}
