namespace UserProfileScreen
{
    partial class StudentCourses
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
            myCoursesLabel = new Label();
            coursesFlowLayoutPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(myCoursesLabel);
            panel1.Controls.Add(coursesFlowLayoutPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 533);
            panel1.TabIndex = 0;
            // 
            // myCoursesLabel
            // 
            myCoursesLabel.AutoSize = true;
            myCoursesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            myCoursesLabel.Location = new Point(29, 39);
            myCoursesLabel.Name = "myCoursesLabel";
            myCoursesLabel.Size = new Size(161, 25);
            myCoursesLabel.TabIndex = 1;
            myCoursesLabel.Text = "Придбані курси";
            // 
            // coursesFlowLayoutPanel
            // 
            coursesFlowLayoutPanel.AutoSize = true;
            coursesFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            coursesFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            coursesFlowLayoutPanel.Location = new Point(29, 89);
            coursesFlowLayoutPanel.Name = "coursesFlowLayoutPanel";
            coursesFlowLayoutPanel.Size = new Size(721, 405);
            coursesFlowLayoutPanel.TabIndex = 0;
            // 
            // StudentCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Name = "StudentCourses";
            Size = new Size(780, 533);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label myCoursesLabel;
        private FlowLayoutPanel coursesFlowLayoutPanel;
    }
}
