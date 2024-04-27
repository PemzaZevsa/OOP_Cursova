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
            panel2 = new Panel();
            panel1 = new Panel();
            toCourseButton = new Button();
            nameLabel = new Label();
            authorLabel = new Label();
            descriptionLabel = new Label();
            raitingLabel = new Label();
            tegsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)coursePictureBox).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            coursePictureBox.Click += toCourseButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(coursePictureBox);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 200);
            panel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(toCourseButton);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(authorLabel);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(raitingLabel);
            panel1.Controls.Add(tegsLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(310, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 200);
            panel1.TabIndex = 8;
            // 
            // toCourseButton
            // 
            toCourseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toCourseButton.Location = new Point(311, 144);
            toCourseButton.Name = "toCourseButton";
            toCourseButton.Size = new Size(126, 53);
            toCourseButton.TabIndex = 6;
            toCourseButton.Text = "Перейти";
            toCourseButton.UseVisualStyleBackColor = true;
            toCourseButton.Click += toCourseButton_Click;
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
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(14, 170);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(58, 20);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "Автор :";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            descriptionLabel.Location = new Point(14, 50);
            descriptionLabel.MaximumSize = new Size(800, 80);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(82, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description";
            // 
            // raitingLabel
            // 
            raitingLabel.AutoSize = true;
            raitingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            raitingLabel.ForeColor = Color.DarkGoldenrod;
            raitingLabel.Location = new Point(14, 150);
            raitingLabel.Name = "raitingLabel";
            raitingLabel.Size = new Size(74, 20);
            raitingLabel.TabIndex = 4;
            raitingLabel.Text = "Рейтинг :";
            // 
            // tegsLabel
            // 
            tegsLabel.AutoSize = true;
            tegsLabel.Location = new Point(14, 130);
            tegsLabel.MaximumSize = new Size(500, 20);
            tegsLabel.Name = "tegsLabel";
            tegsLabel.Size = new Size(47, 20);
            tegsLabel.TabIndex = 3;
            tegsLabel.Text = "Теги :";
            // 
            // CourseElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "CourseElement";
            Size = new Size(750, 200);
            ((System.ComponentModel.ISupportInitialize)coursePictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox coursePictureBox;
        private Panel panel2;
        private Panel panel1;
        private Button toCourseButton;
        private Label nameLabel;
        private Label authorLabel;
        private Label descriptionLabel;
        private Label raitingLabel;
        private Label tegsLabel;
    }
}
