namespace UserProfileScreen
{
    partial class SetRaiting
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
            raiteButton = new Button();
            raiteLabel = new Label();
            raitingTrackBar = new TrackBar();
            raitingChangeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)raitingTrackBar).BeginInit();
            SuspendLayout();
            // 
            // raiteButton
            // 
            raiteButton.BackColor = SystemColors.HotTrack;
            raiteButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            raiteButton.ForeColor = SystemColors.ControlLightLight;
            raiteButton.Location = new Point(91, 146);
            raiteButton.Name = "raiteButton";
            raiteButton.Size = new Size(230, 57);
            raiteButton.TabIndex = 0;
            raiteButton.Text = "Оцінити";
            raiteButton.UseVisualStyleBackColor = false;
            raiteButton.Click += raiteButton_Click;
            // 
            // raiteLabel
            // 
            raiteLabel.AutoSize = true;
            raiteLabel.Location = new Point(40, 37);
            raiteLabel.Name = "raiteLabel";
            raiteLabel.Size = new Size(171, 20);
            raiteLabel.TabIndex = 1;
            raiteLabel.Text = "Оцініть курс від 0 до 10";
            // 
            // raitingTrackBar
            // 
            raitingTrackBar.Location = new Point(40, 60);
            raitingTrackBar.Name = "raitingTrackBar";
            raitingTrackBar.Size = new Size(332, 56);
            raitingTrackBar.TabIndex = 3;
            raitingTrackBar.Value = 10;
            raitingTrackBar.Scroll += raitingTrackBar_Scroll;
            // 
            // raitingChangeLabel
            // 
            raitingChangeLabel.AutoSize = true;
            raitingChangeLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            raitingChangeLabel.ForeColor = Color.DarkGoldenrod;
            raitingChangeLabel.Location = new Point(340, 32);
            raitingChangeLabel.Name = "raitingChangeLabel";
            raitingChangeLabel.Size = new Size(32, 25);
            raitingChangeLabel.TabIndex = 4;
            raitingChangeLabel.Text = "10";
            // 
            // SetRaiting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 215);
            Controls.Add(raitingChangeLabel);
            Controls.Add(raitingTrackBar);
            Controls.Add(raiteLabel);
            Controls.Add(raiteButton);
            Name = "SetRaiting";
            Text = "Оцінка";
            ((System.ComponentModel.ISupportInitialize)raitingTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button raiteButton;
        private Label raiteLabel;
        private TrackBar raitingTrackBar;
        private Label raitingChangeLabel;
    }
}