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
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 121);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 329);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 53);
            label1.Name = "label1";
            label1.Size = new Size(334, 20);
            label1.TabIndex = 0;
            label1.Text = "texttexttexttexttexttexttexttexttexttexttexttexttext";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 56);
            label2.Name = "label2";
            label2.Size = new Size(334, 20);
            label2.TabIndex = 1;
            label2.Text = "texttexttexttexttexttexttexttexttexttexttexttexttext";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 76);
            label3.Name = "label3";
            label3.Size = new Size(334, 20);
            label3.TabIndex = 2;
            label3.Text = "texttexttexttexttexttexttexttexttexttexttexttexttext";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 249);
            label4.Name = "label4";
            label4.Size = new Size(334, 20);
            label4.TabIndex = 3;
            label4.Text = "texttexttexttexttexttexttexttexttexttexttexttexttext";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainScreen";
            Size = new Size(800, 450);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
