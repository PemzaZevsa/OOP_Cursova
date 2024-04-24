namespace MainScreen
{
    partial class CourseElement
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
            coursePictureBox = new PictureBox();
            nameLabel = new Label();
            descriptionLabel = new Label();
            tegsLabel = new Label();
            raitingLabel = new Label();
            authorLabel = new Label();
            panel1 = new Panel();
            toCourseButton = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)coursePictureBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // coursePictureBox
            // 
            coursePictureBox.Location = new Point(20, 10);
            coursePictureBox.Name = "coursePictureBox";
            coursePictureBox.Size = new Size(270, 180);
            coursePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            coursePictureBox.TabIndex = 0;
            coursePictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14F);
            nameLabel.Location = new Point(14, 10);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 32);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            descriptionLabel.Location = new Point(14, 50);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(82, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description";
            // 
            // tegsLabel
            // 
            tegsLabel.AutoSize = true;
            tegsLabel.Location = new Point(14, 130);
            tegsLabel.Name = "tegsLabel";
            tegsLabel.Size = new Size(39, 20);
            tegsLabel.TabIndex = 3;
            tegsLabel.Text = "Tegs";
            // 
            // raitingLabel
            // 
            raitingLabel.AutoSize = true;
            raitingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            raitingLabel.ForeColor = Color.DarkGoldenrod;
            raitingLabel.Location = new Point(14, 150);
            raitingLabel.Name = "raitingLabel";
            raitingLabel.Size = new Size(59, 20);
            raitingLabel.TabIndex = 4;
            raitingLabel.Text = "Raiting";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(14, 170);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(54, 20);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "Author";
            // 
            // panel1
            // 
            panel1.Controls.Add(toCourseButton);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(authorLabel);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(raitingLabel);
            panel1.Controls.Add(tegsLabel);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(310, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 200);
            panel1.TabIndex = 6;
            // 
            // toCourseButton
            // 
            toCourseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            toCourseButton.Location = new Point(311, 146);
            toCourseButton.Name = "toCourseButton";
            toCourseButton.Size = new Size(126, 53);
            toCourseButton.TabIndex = 6;
            toCourseButton.Text = "Перейти";
            toCourseButton.UseVisualStyleBackColor = true;
            toCourseButton.Click += toCourseButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(coursePictureBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 200);
            panel2.TabIndex = 7;
            // 
            // CourseElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CourseElement";
            Size = new Size(750, 200);
            ((System.ComponentModel.ISupportInitialize)coursePictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox coursePictureBox;
        private Label nameLabel;
        private Label descriptionLabel;
        private Label tegsLabel;
        private Label raitingLabel;
        private Label authorLabel;
        private Panel panel1;
        private Panel panel2;
        private Button toCourseButton;
    }
}
