namespace CourseworkOOP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            coursesApp.Save();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            headPanel = new Panel();
            myHeader = new HeaderSpace.HeaderBlock();
            mainPanel = new Panel();
            headPanel.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 928);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1291, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // headPanel
            // 
            headPanel.Controls.Add(myHeader);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.Size = new Size(1291, 120);
            headPanel.TabIndex = 3;
            // 
            // myHeader
            // 
            myHeader.BorderStyle = BorderStyle.FixedSingle;
            myHeader.Dock = DockStyle.Fill;
            myHeader.Location = new Point(0, 0);
            myHeader.Name = "myHeader";
            myHeader.Size = new Size(1291, 120);
            myHeader.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 120);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1291, 808);
            mainPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1291, 953);
            Controls.Add(mainPanel);
            Controls.Add(headPanel);
            Controls.Add(toolStrip1);
            MinimumSize = new Size(1100, 800);
            Name = "MainForm";
            Text = "Learnopia";
            WindowState = FormWindowState.Maximized;
            headPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private Panel headPanel;
        private Panel mainPanel;
        private HeaderSpace.HeaderBlock myHeader;
    }
}
