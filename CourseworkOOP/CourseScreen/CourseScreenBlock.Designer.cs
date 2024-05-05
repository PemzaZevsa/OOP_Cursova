namespace CourseScreenSpace
{
    partial class CourseScreenBlock
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
            costLabel = new Label();
            buyPanel = new Panel();
            backButton = new Button();
            coursePictureBox = new PictureBox();
            authorLabel = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            nameLabel = new Label();
            tegsLabel = new Label();
            raitingLabel = new Label();
            descriptionLabel = new Label();
            studentsLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coursePictureBox).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(costLabel);
            panel1.Controls.Add(buyPanel);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(coursePictureBox);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(680, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 649);
            panel1.TabIndex = 0;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            costLabel.ForeColor = SystemColors.ButtonHighlight;
            costLabel.Location = new Point(12, 464);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(65, 25);
            costLabel.TabIndex = 6;
            costLabel.Text = "Ціна :";
            // 
            // buyPanel
            // 
            buyPanel.Dock = DockStyle.Bottom;
            buyPanel.Location = new Point(0, 492);
            buyPanel.Name = "buyPanel";
            buyPanel.Size = new Size(400, 157);
            buyPanel.TabIndex = 5;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            backButton.Location = new Point(221, 15);
            backButton.Name = "backButton";
            backButton.Size = new Size(160, 60);
            backButton.TabIndex = 4;
            backButton.Text = "Повернутися";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // coursePictureBox
            // 
            coursePictureBox.Location = new Point(12, 100);
            coursePictureBox.Name = "coursePictureBox";
            coursePictureBox.Size = new Size(375, 250);
            coursePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            coursePictureBox.TabIndex = 0;
            coursePictureBox.TabStop = false;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new Font("Segoe UI", 11F);
            authorLabel.Location = new Point(3, 480);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(73, 25);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Автор :";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 649);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(authorLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(tegsLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(raitingLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(descriptionLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(studentsLabel, 0, 5);
            tableLayoutPanel1.Location = new Point(34, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(608, 600);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            nameLabel.Location = new Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(188, 37);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Course Name";
            // 
            // tegsLabel
            // 
            tegsLabel.AutoSize = true;
            tegsLabel.Font = new Font("Segoe UI", 11F);
            tegsLabel.Location = new Point(3, 360);
            tegsLabel.Name = "tegsLabel";
            tegsLabel.Size = new Size(59, 25);
            tegsLabel.TabIndex = 3;
            tegsLabel.Text = "Теги :";
            // 
            // raitingLabel
            // 
            raitingLabel.AutoSize = true;
            raitingLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            raitingLabel.ForeColor = Color.Goldenrod;
            raitingLabel.Location = new Point(3, 420);
            raitingLabel.Name = "raitingLabel";
            raitingLabel.Size = new Size(96, 25);
            raitingLabel.TabIndex = 1;
            raitingLabel.Text = "Рейтинг :";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            descriptionLabel.Location = new Point(3, 120);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(105, 25);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description";
            // 
            // studentsLabel
            // 
            studentsLabel.AutoSize = true;
            studentsLabel.Font = new Font("Segoe UI", 11F);
            studentsLabel.Location = new Point(3, 540);
            studentsLabel.Name = "studentsLabel";
            studentsLabel.Size = new Size(188, 25);
            studentsLabel.TabIndex = 4;
            studentsLabel.Text = "Кількість студентів : ";
            // 
            // CourseScreenBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CourseScreenBlock";
            Size = new Size(1080, 649);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coursePictureBox).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox coursePictureBox;
        private Label authorLabel;
        private Label descriptionLabel;
        private Label raitingLabel;
        private Label nameLabel;
        private Label tegsLabel;
        private Button backButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label studentsLabel;
        private Panel buyPanel;
        private Label costLabel;
    }
}
