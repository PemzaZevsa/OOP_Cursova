using CourseworkOOP.Entities;

namespace MainScreen
{
    partial class MainScreenBlock
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
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            aboutCoursesLabel = new Label();
            coursesFlowLayoutPanel = new FlowLayoutPanel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(aboutCoursesLabel);
            panel2.Controls.Add(coursesFlowLayoutPanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 657);
            panel2.TabIndex = 1;
            // 
            // aboutCoursesLabel
            // 
            aboutCoursesLabel.AutoSize = true;
            aboutCoursesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            aboutCoursesLabel.Location = new Point(43, 21);
            aboutCoursesLabel.Name = "aboutCoursesLabel";
            aboutCoursesLabel.Size = new Size(347, 25);
            aboutCoursesLabel.TabIndex = 1;
            aboutCoursesLabel.Text = "Курси, які вам можуть сподобатися";
            // 
            // coursesFlowLayoutPanel
            // 
            coursesFlowLayoutPanel.AutoSize = true;
            coursesFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            coursesFlowLayoutPanel.Location = new Point(43, 74);
            coursesFlowLayoutPanel.Name = "coursesFlowLayoutPanel";
            coursesFlowLayoutPanel.Size = new Size(652, 356);
            coursesFlowLayoutPanel.TabIndex = 0;
            // 
            // MainScreenBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "MainScreenBlock";
            Size = new Size(996, 657);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FlowLayoutPanel coursesFlowLayoutPanel;
        private Label aboutCoursesLabel;
    }
}
