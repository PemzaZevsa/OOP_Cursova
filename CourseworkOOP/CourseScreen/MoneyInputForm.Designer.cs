﻿namespace CourseScreen
{
    partial class MoneyInputForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            payButton = new Button();
            label1 = new Label();
            moneyTextBox = new TextBox();
            SuspendLayout();
            // 
            // payButton
            // 
            payButton.Location = new Point(207, 105);
            payButton.Name = "payButton";
            payButton.Size = new Size(178, 53);
            payButton.TabIndex = 0;
            payButton.Text = "Ввести";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(415, 20);
            label1.TabIndex = 1;
            label1.Text = "Введіть суму, яка (в теорії) могла би бути на вашій картці :";
            // 
            // moneyTextBox
            // 
            moneyTextBox.Location = new Point(433, 47);
            moneyTextBox.Name = "moneyTextBox";
            moneyTextBox.Size = new Size(136, 27);
            moneyTextBox.TabIndex = 2;
            // 
            // MoneyInputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 179);
            Controls.Add(moneyTextBox);
            Controls.Add(label1);
            Controls.Add(payButton);
            Name = "MoneyInputForm";
            Text = "Емуляція операції покупки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button payButton;
        private Label label1;
        private TextBox moneyTextBox;
    }
}