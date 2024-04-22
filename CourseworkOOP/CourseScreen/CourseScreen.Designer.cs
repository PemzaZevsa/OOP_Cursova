namespace CourseScreenSpace
{
    partial class CourseScreen
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
            authorLabel = new Label();
            buyButton = new Button();
            coursePictureBox = new PictureBox();
            panel2 = new Panel();
            descriptionLabel = new Label();
            raitingLabel = new Label();
            nameLabel = new Label();
            costLabel = new Label();
            tegsLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coursePictureBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(costLabel);
            panel1.Controls.Add(buyButton);
            panel1.Controls.Add(coursePictureBox);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(567, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 510);
            panel1.TabIndex = 0;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(37, 250);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(54, 20);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Author";
            // 
            // buyButton
            // 
            buyButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buyButton.Location = new Point(30, 405);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(240, 61);
            buyButton.TabIndex = 1;
            buyButton.Text = "Придбати";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += buyButton_Click;
            // 
            // coursePictureBox
            // 
            coursePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            coursePictureBox.Location = new Point(30, 100);
            coursePictureBox.Name = "coursePictureBox";
            coursePictureBox.Size = new Size(240, 240);
            coursePictureBox.TabIndex = 0;
            coursePictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tegsLabel);
            panel2.Controls.Add(authorLabel);
            panel2.Controls.Add(descriptionLabel);
            panel2.Controls.Add(raitingLabel);
            panel2.Controls.Add(nameLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 510);
            panel2.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(37, 100);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(85, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description";
            // 
            // raitingLabel
            // 
            raitingLabel.AutoSize = true;
            raitingLabel.Location = new Point(37, 200);
            raitingLabel.Name = "raitingLabel";
            raitingLabel.Size = new Size(64, 20);
            raitingLabel.TabIndex = 1;
            raitingLabel.Text = "Рейтинг";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(37, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(98, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Course Name";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(30, 368);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(38, 20);
            costLabel.TabIndex = 3;
            costLabel.Text = "Cost";
            // 
            // tegsLabel
            // 
            tegsLabel.AutoSize = true;
            tegsLabel.Location = new Point(37, 150);
            tegsLabel.Name = "tegsLabel";
            tegsLabel.Size = new Size(39, 20);
            tegsLabel.TabIndex = 3;
            tegsLabel.Text = "Tegs";
            // 
            // CourseScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CourseScreen";
            Size = new Size(867, 510);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coursePictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox coursePictureBox;
        private Label authorLabel;
        private Button buyButton;
        private Label descriptionLabel;
        private Label raitingLabel;
        private Label nameLabel;
        private Label costLabel;
        private Label tegsLabel;
    }
}
