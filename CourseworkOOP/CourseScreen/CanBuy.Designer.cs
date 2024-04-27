namespace CourseScreen
{
    partial class CanBuy
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
            panel3 = new Panel();
            buyButton = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(buyButton);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 150);
            panel3.TabIndex = 6;
            // 
            // buyButton
            // 
            buyButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buyButton.BackColor = SystemColors.HotTrack;
            buyButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buyButton.ForeColor = SystemColors.Control;
            buyButton.Location = new Point(30, 26);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(291, 93);
            buyButton.TabIndex = 1;
            buyButton.Text = "Придбати";
            buyButton.UseVisualStyleBackColor = false;
            buyButton.Click += buyButton_Click;
            // 
            // CanBuy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "CanBuy";
            Size = new Size(350, 150);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button buyButton;
    }
}
