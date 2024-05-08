namespace SeachScreen
{
    partial class SeacrchScreenBlock
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
            tagsGroupBox = new GroupBox();
            marketingCheckBox = new CheckBox();
            designCheckBox = new CheckBox();
            communicationCheckBox = new CheckBox();
            cloudComputingCheckBox = new CheckBox();
            leadershipAndManagementCheckBox = new CheckBox();
            buisnessCheckBox = new CheckBox();
            linguisticsCheckBox = new CheckBox();
            dataScienceCheckBox = new CheckBox();
            cybersecurityCheckBox = new CheckBox();
            developmentCheckBox = new CheckBox();
            filterLabel = new Label();
            raitingGroupBox = new GroupBox();
            allRadioButton = new RadioButton();
            fiveRadioButton = new RadioButton();
            sixRadioButton = new RadioButton();
            sevenRadioButton = new RadioButton();
            eightRadioButton = new RadioButton();
            nineRadioButton = new RadioButton();
            filterButton = new Button();
            panel2 = new Panel();
            foundLabel = new Label();
            coursesFlowLayoutPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            tagsGroupBox.SuspendLayout();
            raitingGroupBox.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(tagsGroupBox);
            panel1.Controls.Add(filterLabel);
            panel1.Controls.Add(raitingGroupBox);
            panel1.Controls.Add(filterButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 575);
            panel1.TabIndex = 0;
            // 
            // tagsGroupBox
            // 
            tagsGroupBox.BackColor = SystemColors.Control;
            tagsGroupBox.Controls.Add(marketingCheckBox);
            tagsGroupBox.Controls.Add(designCheckBox);
            tagsGroupBox.Controls.Add(communicationCheckBox);
            tagsGroupBox.Controls.Add(cloudComputingCheckBox);
            tagsGroupBox.Controls.Add(leadershipAndManagementCheckBox);
            tagsGroupBox.Controls.Add(buisnessCheckBox);
            tagsGroupBox.Controls.Add(linguisticsCheckBox);
            tagsGroupBox.Controls.Add(dataScienceCheckBox);
            tagsGroupBox.Controls.Add(cybersecurityCheckBox);
            tagsGroupBox.Controls.Add(developmentCheckBox);
            tagsGroupBox.Location = new Point(20, 59);
            tagsGroupBox.Name = "tagsGroupBox";
            tagsGroupBox.Size = new Size(260, 201);
            tagsGroupBox.TabIndex = 5;
            tagsGroupBox.TabStop = false;
            tagsGroupBox.Text = "Теги";
            // 
            // marketingCheckBox
            // 
            marketingCheckBox.AutoSize = true;
            marketingCheckBox.Location = new Point(153, 146);
            marketingCheckBox.Name = "marketingCheckBox";
            marketingCheckBox.Size = new Size(106, 24);
            marketingCheckBox.TabIndex = 9;
            marketingCheckBox.Text = "Маркетинг";
            marketingCheckBox.UseVisualStyleBackColor = true;
            marketingCheckBox.CheckStateChanged += marketingCheckBox_CheckedChanged;
            // 
            // designCheckBox
            // 
            designCheckBox.AutoSize = true;
            designCheckBox.Location = new Point(153, 116);
            designCheckBox.Name = "designCheckBox";
            designCheckBox.Size = new Size(83, 24);
            designCheckBox.TabIndex = 8;
            designCheckBox.Text = "Дизайн";
            designCheckBox.UseVisualStyleBackColor = true;
            designCheckBox.CheckStateChanged += designCheckBox_CheckedChanged;
            // 
            // communicationCheckBox
            // 
            communicationCheckBox.AutoSize = true;
            communicationCheckBox.Location = new Point(6, 146);
            communicationCheckBox.Name = "communicationCheckBox";
            communicationCheckBox.Size = new Size(116, 24);
            communicationCheckBox.TabIndex = 7;
            communicationCheckBox.Text = "Комунікація";
            communicationCheckBox.UseVisualStyleBackColor = true;
            communicationCheckBox.CheckStateChanged += communicationCheckBox_CheckedChanged;
            // 
            // cloudComputingCheckBox
            // 
            cloudComputingCheckBox.AutoSize = true;
            cloudComputingCheckBox.Location = new Point(6, 116);
            cloudComputingCheckBox.Name = "cloudComputingCheckBox";
            cloudComputingCheckBox.Size = new Size(138, 24);
            cloudComputingCheckBox.TabIndex = 6;
            cloudComputingCheckBox.Text = "Хмарні обчисл.";
            cloudComputingCheckBox.UseVisualStyleBackColor = true;
            cloudComputingCheckBox.CheckStateChanged += cloudComputingCheckBox_CheckedChanged;
            // 
            // leadershipAndManagementCheckBox
            // 
            leadershipAndManagementCheckBox.AutoSize = true;
            leadershipAndManagementCheckBox.Location = new Point(153, 86);
            leadershipAndManagementCheckBox.Name = "leadershipAndManagementCheckBox";
            leadershipAndManagementCheckBox.Size = new Size(112, 24);
            leadershipAndManagementCheckBox.TabIndex = 5;
            leadershipAndManagementCheckBox.Text = "Управління";
            leadershipAndManagementCheckBox.UseVisualStyleBackColor = true;
            leadershipAndManagementCheckBox.CheckStateChanged += leadershipAndManagementCheckBox_CheckedChanged;
            // 
            // buisnessCheckBox
            // 
            buisnessCheckBox.AutoSize = true;
            buisnessCheckBox.Location = new Point(153, 56);
            buisnessCheckBox.Name = "buisnessCheckBox";
            buisnessCheckBox.Size = new Size(75, 24);
            buisnessCheckBox.TabIndex = 4;
            buisnessCheckBox.Text = "Бізнес";
            buisnessCheckBox.UseVisualStyleBackColor = true;
            buisnessCheckBox.CheckStateChanged += buisnessCheckBox_CheckedChanged;
            // 
            // linguisticsCheckBox
            // 
            linguisticsCheckBox.AutoSize = true;
            linguisticsCheckBox.Location = new Point(153, 26);
            linguisticsCheckBox.Name = "linguisticsCheckBox";
            linguisticsCheckBox.Size = new Size(109, 24);
            linguisticsCheckBox.TabIndex = 3;
            linguisticsCheckBox.Text = "Лінгвістика";
            linguisticsCheckBox.UseVisualStyleBackColor = true;
            linguisticsCheckBox.CheckStateChanged += linguisticsCheckBox_CheckedChanged;
            // 
            // dataScienceCheckBox
            // 
            dataScienceCheckBox.AutoSize = true;
            dataScienceCheckBox.Location = new Point(6, 86);
            dataScienceCheckBox.Name = "dataScienceCheckBox";
            dataScienceCheckBox.Size = new Size(113, 24);
            dataScienceCheckBox.TabIndex = 2;
            dataScienceCheckBox.Text = "DataScience";
            dataScienceCheckBox.UseVisualStyleBackColor = true;
            dataScienceCheckBox.CheckStateChanged += dataScienceCheckBox_CheckedChanged;
            // 
            // cybersecurityCheckBox
            // 
            cybersecurityCheckBox.AutoSize = true;
            cybersecurityCheckBox.Location = new Point(6, 56);
            cybersecurityCheckBox.Name = "cybersecurityCheckBox";
            cybersecurityCheckBox.Size = new Size(126, 24);
            cybersecurityCheckBox.TabIndex = 1;
            cybersecurityCheckBox.Text = "Кібербезпека";
            cybersecurityCheckBox.UseVisualStyleBackColor = true;
            cybersecurityCheckBox.CheckStateChanged += cybersecurityCheckBox_CheckedChanged;
            // 
            // developmentCheckBox
            // 
            developmentCheckBox.AutoSize = true;
            developmentCheckBox.Location = new Point(6, 26);
            developmentCheckBox.Name = "developmentCheckBox";
            developmentCheckBox.Size = new Size(97, 24);
            developmentCheckBox.TabIndex = 0;
            developmentCheckBox.Text = "Розробка";
            developmentCheckBox.UseVisualStyleBackColor = true;
            developmentCheckBox.CheckStateChanged += developmentCheckBox_CheckedChanged;
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            filterLabel.ForeColor = SystemColors.ControlLightLight;
            filterLabel.Location = new Point(20, 21);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(87, 25);
            filterLabel.TabIndex = 4;
            filterLabel.Text = "Фільтри";
            // 
            // raitingGroupBox
            // 
            raitingGroupBox.BackColor = SystemColors.Control;
            raitingGroupBox.Controls.Add(allRadioButton);
            raitingGroupBox.Controls.Add(fiveRadioButton);
            raitingGroupBox.Controls.Add(sixRadioButton);
            raitingGroupBox.Controls.Add(sevenRadioButton);
            raitingGroupBox.Controls.Add(eightRadioButton);
            raitingGroupBox.Controls.Add(nineRadioButton);
            raitingGroupBox.Location = new Point(20, 266);
            raitingGroupBox.Name = "raitingGroupBox";
            raitingGroupBox.Size = new Size(260, 209);
            raitingGroupBox.TabIndex = 3;
            raitingGroupBox.TabStop = false;
            raitingGroupBox.Text = "Рейтинг";
            // 
            // allRadioButton
            // 
            allRadioButton.AutoSize = true;
            allRadioButton.Checked = true;
            allRadioButton.Location = new Point(6, 176);
            allRadioButton.Name = "allRadioButton";
            allRadioButton.Size = new Size(50, 24);
            allRadioButton.TabIndex = 5;
            allRadioButton.TabStop = true;
            allRadioButton.Text = "Усі";
            allRadioButton.UseVisualStyleBackColor = true;
            allRadioButton.CheckedChanged += allRadioButton_CheckedChanged;
            // 
            // fiveRadioButton
            // 
            fiveRadioButton.AutoSize = true;
            fiveRadioButton.Location = new Point(6, 146);
            fiveRadioButton.Name = "fiveRadioButton";
            fiveRadioButton.Size = new Size(52, 24);
            fiveRadioButton.TabIndex = 4;
            fiveRadioButton.Text = "5 +";
            fiveRadioButton.UseVisualStyleBackColor = true;
            fiveRadioButton.CheckedChanged += fiveRadioButton_CheckedChanged;
            // 
            // sixRadioButton
            // 
            sixRadioButton.AutoSize = true;
            sixRadioButton.Location = new Point(6, 116);
            sixRadioButton.Name = "sixRadioButton";
            sixRadioButton.Size = new Size(52, 24);
            sixRadioButton.TabIndex = 3;
            sixRadioButton.TabStop = true;
            sixRadioButton.Text = "6 +";
            sixRadioButton.UseVisualStyleBackColor = true;
            sixRadioButton.CheckedChanged += sixRadioButton_CheckedChanged;
            // 
            // sevenRadioButton
            // 
            sevenRadioButton.AutoSize = true;
            sevenRadioButton.Location = new Point(6, 86);
            sevenRadioButton.Name = "sevenRadioButton";
            sevenRadioButton.Size = new Size(52, 24);
            sevenRadioButton.TabIndex = 2;
            sevenRadioButton.TabStop = true;
            sevenRadioButton.Text = "7 +";
            sevenRadioButton.UseVisualStyleBackColor = true;
            sevenRadioButton.CheckedChanged += sevenRadioButton_CheckedChanged;
            // 
            // eightRadioButton
            // 
            eightRadioButton.AutoSize = true;
            eightRadioButton.Location = new Point(6, 56);
            eightRadioButton.Name = "eightRadioButton";
            eightRadioButton.Size = new Size(52, 24);
            eightRadioButton.TabIndex = 1;
            eightRadioButton.TabStop = true;
            eightRadioButton.Text = "8 +";
            eightRadioButton.UseVisualStyleBackColor = true;
            eightRadioButton.CheckedChanged += eightRadioButton_CheckedChanged;
            // 
            // nineRadioButton
            // 
            nineRadioButton.AutoSize = true;
            nineRadioButton.Location = new Point(6, 26);
            nineRadioButton.Name = "nineRadioButton";
            nineRadioButton.Size = new Size(52, 24);
            nineRadioButton.TabIndex = 0;
            nineRadioButton.TabStop = true;
            nineRadioButton.Text = "9 +";
            nineRadioButton.UseVisualStyleBackColor = true;
            nineRadioButton.CheckedChanged += nineRadioButton_CheckedChanged;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(20, 481);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(260, 60);
            filterButton.TabIndex = 2;
            filterButton.Text = "Фільтрувати";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(foundLabel);
            panel2.Controls.Add(coursesFlowLayoutPanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(898, 575);
            panel2.TabIndex = 1;
            // 
            // foundLabel
            // 
            foundLabel.AutoSize = true;
            foundLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            foundLabel.Location = new Point(38, 21);
            foundLabel.Name = "foundLabel";
            foundLabel.Size = new Size(261, 25);
            foundLabel.TabIndex = 1;
            foundLabel.Text = "Знайдені курси по запиту :";
            // 
            // coursesFlowLayoutPanel
            // 
            coursesFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            coursesFlowLayoutPanel.AutoSize = true;
            coursesFlowLayoutPanel.Location = new Point(38, 59);
            coursesFlowLayoutPanel.Name = "coursesFlowLayoutPanel";
            coursesFlowLayoutPanel.Size = new Size(812, 452);
            coursesFlowLayoutPanel.TabIndex = 0;
            // 
            // SeacrchScreenBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SeacrchScreenBlock";
            Size = new Size(1198, 575);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tagsGroupBox.ResumeLayout(false);
            tagsGroupBox.PerformLayout();
            raitingGroupBox.ResumeLayout(false);
            raitingGroupBox.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button filterButton;
        private Panel panel2;
        private Label foundLabel;
        private FlowLayoutPanel coursesFlowLayoutPanel;
        private GroupBox raitingGroupBox;
        private RadioButton sixRadioButton;
        private RadioButton sevenRadioButton;
        private RadioButton eightRadioButton;
        private RadioButton nineRadioButton;
        private Label filterLabel;
        private RadioButton allRadioButton;
        private RadioButton fiveRadioButton;
        private GroupBox tagsGroupBox;
        private CheckBox leadershipAndManagementCheckBox;
        private CheckBox buisnessCheckBox;
        private CheckBox linguisticsCheckBox;
        private CheckBox dataScienceCheckBox;
        private CheckBox cybersecurityCheckBox;
        private CheckBox developmentCheckBox;
        private CheckBox communicationCheckBox;
        private CheckBox cloudComputingCheckBox;
        private CheckBox marketingCheckBox;
        private CheckBox designCheckBox;
    }
}
