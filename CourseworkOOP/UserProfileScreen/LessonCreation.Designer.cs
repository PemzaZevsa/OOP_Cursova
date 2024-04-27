namespace UserProfileScreen
{
    partial class LessonCreation
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
            materialsRichTextBox = new RichTextBox();
            materialsLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(materialsRichTextBox);
            panel1.Controls.Add(materialsLabel);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(nameLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 237);
            panel1.TabIndex = 0;
            // 
            // materialsRichTextBox
            // 
            materialsRichTextBox.Location = new Point(151, 71);
            materialsRichTextBox.Name = "materialsRichTextBox";
            materialsRichTextBox.Size = new Size(501, 134);
            materialsRichTextBox.TabIndex = 4;
            materialsRichTextBox.Text = "";
            // 
            // materialsLabel
            // 
            materialsLabel.AutoSize = true;
            materialsLabel.Location = new Point(17, 185);
            materialsLabel.Name = "materialsLabel";
            materialsLabel.Size = new Size(82, 20);
            materialsLabel.TabIndex = 3;
            materialsLabel.Text = "Матеріали";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(151, 15);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(501, 27);
            nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(17, 22);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(95, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Назва урока";
            // 
            // LessonCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "LessonCreation";
            Size = new Size(668, 237);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox materialsRichTextBox;
        private Label materialsLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
    }
}
