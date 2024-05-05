namespace UserProfileScreen
{
    partial class CourseEducation
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
            courseStuctureFlowLayoutPanel = new FlowLayoutPanel();
            panel3 = new Panel();
            rateButton = new Button();
            returnButton = new Button();
            panel2 = new Panel();
            contentListBox = new ListBox();
            nameLessonLabel = new Label();
            courseNameLabel = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(courseStuctureFlowLayoutPanel);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(695, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 581);
            panel1.TabIndex = 0;
            // 
            // courseStuctureFlowLayoutPanel
            // 
            courseStuctureFlowLayoutPanel.AutoSize = true;
            courseStuctureFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            courseStuctureFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            courseStuctureFlowLayoutPanel.Location = new Point(6, 99);
            courseStuctureFlowLayoutPanel.Name = "courseStuctureFlowLayoutPanel";
            courseStuctureFlowLayoutPanel.Size = new Size(308, 535);
            courseStuctureFlowLayoutPanel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(rateButton);
            panel3.Controls.Add(returnButton);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 93);
            panel3.TabIndex = 1;
            // 
            // rateButton
            // 
            rateButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rateButton.Location = new Point(6, 14);
            rateButton.Name = "rateButton";
            rateButton.Size = new Size(150, 60);
            rateButton.TabIndex = 1;
            rateButton.Text = "Оцінити курс";
            rateButton.UseVisualStyleBackColor = true;
            rateButton.Click += rateButton_Click;
            // 
            // returnButton
            // 
            returnButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            returnButton.Location = new Point(162, 14);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(152, 60);
            returnButton.TabIndex = 0;
            returnButton.Text = "Повернутися";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(contentListBox);
            panel2.Controls.Add(nameLessonLabel);
            panel2.Controls.Add(courseNameLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(695, 581);
            panel2.TabIndex = 1;
            // 
            // contentListBox
            // 
            contentListBox.FormattingEnabled = true;
            contentListBox.Location = new Point(27, 92);
            contentListBox.Name = "contentListBox";
            contentListBox.Size = new Size(648, 464);
            contentListBox.TabIndex = 1;
            // 
            // nameLessonLabel
            // 
            nameLessonLabel.AutoSize = true;
            nameLessonLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            nameLessonLabel.Location = new Point(27, 49);
            nameLessonLabel.Name = "nameLessonLabel";
            nameLessonLabel.Size = new Size(548, 25);
            nameLessonLabel.TabIndex = 2;
            nameLessonLabel.Text = "Оберіть урок, натиснувши на кнопку відповідного уроку";
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Location = new Point(27, 14);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new Size(95, 20);
            courseNameLabel.TabIndex = 0;
            courseNameLabel.Text = "Course name";
            // 
            // CourseEducation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CourseEducation";
            Size = new Size(1044, 581);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel courseStuctureFlowLayoutPanel;
        private Button returnButton;
        private Panel panel2;
        private Label nameLessonLabel;
        private ListBox contentListBox;
        private Label courseNameLabel;
        private Panel panel3;
        private RichTextBox richTextBox1;
        private Button rateButton;
    }
}
