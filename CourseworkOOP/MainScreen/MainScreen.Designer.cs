using CourseworkOOP.Entities;

namespace MainScreen
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(CoursesApp coursesApp)
        {
            panel1 = new Panel();
            welcomeLabel = new Label();
            panel2 = new Panel();
            aboutLabel = new Label();
            coursesFlowLayoutPanel = new FlowLayoutPanel();
            courseElement1 = new CourseElement(coursesApp.Courses[0]);
            courseElement2 = new CourseElement(coursesApp.Courses[0]);
            courseElement3 = new CourseElement(coursesApp.Courses[0]);
            courseElement4 = new CourseElement(coursesApp.Courses[0]);
            courseElement5 = new CourseElement(coursesApp.Courses[0]);
            courseElement6 = new CourseElement(coursesApp.Courses[0]);
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            coursesFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(welcomeLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 68);
            panel1.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            welcomeLabel.Location = new Point(43, 12);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(388, 46);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to Learnopia!";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(aboutLabel);
            panel2.Controls.Add(coursesFlowLayoutPanel);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 589);
            panel2.TabIndex = 1;
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.Font = new Font("Segoe UI", 11F);
            aboutLabel.Location = new Point(43, 19);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new Size(320, 25);
            aboutLabel.TabIndex = 6;
            aboutLabel.Text = "Курси, які вам можуть сподобатися";
            // 
            // coursesFlowLayoutPanel
            // 
            coursesFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            coursesFlowLayoutPanel.AutoSize = true;
            coursesFlowLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            coursesFlowLayoutPanel.Controls.Add(courseElement1);
            coursesFlowLayoutPanel.Controls.Add(courseElement2);
            coursesFlowLayoutPanel.Controls.Add(courseElement3);
            coursesFlowLayoutPanel.Controls.Add(courseElement4);
            coursesFlowLayoutPanel.Controls.Add(courseElement5);
            coursesFlowLayoutPanel.Controls.Add(courseElement6);
            coursesFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            coursesFlowLayoutPanel.Location = new Point(43, 58);
            coursesFlowLayoutPanel.Name = "coursesFlowLayoutPanel";
            coursesFlowLayoutPanel.Size = new Size(760, 1386);
            coursesFlowLayoutPanel.TabIndex = 5;
            // 
            // courseElement1
            // 
            courseElement1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            courseElement1.BorderStyle = BorderStyle.FixedSingle;
            courseElement1.Location = new Point(3, 3);
            courseElement1.Name = "courseElement1";
            courseElement1.Size = new Size(750, 200);
            courseElement1.TabIndex = 0;
            // 
            // courseElement2
            // 
            courseElement2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            courseElement2.BorderStyle = BorderStyle.FixedSingle;
            courseElement2.Location = new Point(3, 209);
            courseElement2.Name = "courseElement2";
            courseElement2.Size = new Size(750, 200);
            courseElement2.TabIndex = 1;
            // 
            // courseElement3
            // 
            courseElement3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            courseElement3.BorderStyle = BorderStyle.FixedSingle;
            courseElement3.Location = new Point(3, 415);
            courseElement3.Name = "courseElement3";
            courseElement3.Size = new Size(750, 200);
            courseElement3.TabIndex = 2;
            // 
            // courseElement4
            // 
            courseElement4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            courseElement4.BorderStyle = BorderStyle.FixedSingle;
            courseElement4.Location = new Point(3, 621);
            courseElement4.Name = "courseElement4";
            courseElement4.Size = new Size(750, 200);
            courseElement4.TabIndex = 3;
            // 
            // courseElement5
            // 
            courseElement5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            courseElement5.BorderStyle = BorderStyle.FixedSingle;
            courseElement5.Location = new Point(3, 827);
            courseElement5.Name = "courseElement5";
            courseElement5.Size = new Size(750, 250);
            courseElement5.TabIndex = 4;
            // 
            // courseElement6
            // 
            courseElement6.BorderStyle = BorderStyle.FixedSingle;
            courseElement6.Location = new Point(3, 1083);
            courseElement6.Name = "courseElement6";
            courseElement6.Size = new Size(750, 250);
            courseElement6.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(838, 58);
            button1.Name = "button1";
            button1.Size = new Size(119, 54);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainScreen";
            Size = new Size(996, 657);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            coursesFlowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label welcomeLabel;
        private Button button1;
        private FlowLayoutPanel coursesFlowLayoutPanel;
        private CourseElement courseElement1;
        private CourseElement courseElement2;
        private CourseElement courseElement3;
        private CourseElement courseElement4;
        private CourseElement courseElement5;
        private CourseElement courseElement6;
        private Label aboutLabel;
    }
}
