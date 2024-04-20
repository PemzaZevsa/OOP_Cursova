namespace RegistrationScreen
{
    partial class RegistrationScreen
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
        private void InitializeComponent()
        {
            basePanel = new Panel();
            middlePanel = new Panel();
            authorisation1 = new Authorisation();
            panel4 = new Panel();
            panel3 = new Panel();
            basePanel.SuspendLayout();
            middlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // basePanel
            // 
            basePanel.BackColor = SystemColors.ButtonFace;
            basePanel.Controls.Add(middlePanel);
            basePanel.Controls.Add(panel4);
            basePanel.Controls.Add(panel3);
            basePanel.Dock = DockStyle.Fill;
            basePanel.Location = new Point(0, 0);
            basePanel.Name = "basePanel";
            basePanel.Size = new Size(1205, 500);
            basePanel.TabIndex = 0;
            // 
            // middlePanel
            // 
            middlePanel.Controls.Add(authorisation1);
            middlePanel.Dock = DockStyle.Fill;
            middlePanel.Location = new Point(300, 0);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(605, 500);
            middlePanel.TabIndex = 4;
            // 
            // authorisation1
            // 
            authorisation1.Dock = DockStyle.Fill;
            authorisation1.Location = new Point(0, 0);
            authorisation1.Name = "authorisation1";
            authorisation1.Size = new Size(605, 500);
            authorisation1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(905, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 500);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 500);
            panel3.TabIndex = 1;
            // 
            // RegistrationScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(basePanel);
            Name = "RegistrationScreen";
            Size = new Size(1205, 500);
            basePanel.ResumeLayout(false);
            middlePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel basePanel;
        private Panel panel4;
        private Panel panel3;
        private Authorisation authorisation1;
        private Panel middlePanel;
    }
}
