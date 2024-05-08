namespace UserProfileScreen
{
    partial class CourseCreation
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            descriptionLabel = new Label();
            descriptionRichTextBox = new RichTextBox();
            costLabel = new Label();
            costTextBox = new TextBox();
            tegsLabel = new Label();
            courseCreationLabel = new Label();
            loadPicButton = new Button();
            profilePicLabel = new Label();
            previevPictureBox = new PictureBox();
            backButton = new Button();
            panel1 = new Panel();
            buttonsFlowLayoutPanel = new FlowLayoutPanel();
            createButton = new Button();
            changeButton = new Button();
            deleteButton = new Button();
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
            deleteModuleButton = new Button();
            moduleFlowLayoutPanel = new FlowLayoutPanel();
            addModuleButton = new Button();
            pictureFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)previevPictureBox).BeginInit();
            panel1.SuspendLayout();
            buttonsFlowLayoutPanel.SuspendLayout();
            tagsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(27, 76);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Назва";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(402, 69);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(421, 27);
            nameTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(27, 151);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(45, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Опис";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(402, 102);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(421, 69);
            descriptionRichTextBox.TabIndex = 4;
            descriptionRichTextBox.Text = "";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(27, 184);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(41, 20);
            costLabel.TabIndex = 5;
            costLabel.Text = "Ціна";
            // 
            // costTextBox
            // 
            costTextBox.Location = new Point(706, 177);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(117, 27);
            costTextBox.TabIndex = 6;
            // 
            // tegsLabel
            // 
            tegsLabel.AutoSize = true;
            tegsLabel.Location = new Point(27, 290);
            tegsLabel.Name = "tegsLabel";
            tegsLabel.Size = new Size(40, 20);
            tegsLabel.TabIndex = 7;
            tegsLabel.Text = "Теги";
            // 
            // courseCreationLabel
            // 
            courseCreationLabel.AutoSize = true;
            courseCreationLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            courseCreationLabel.Location = new Point(213, 17);
            courseCreationLabel.Name = "courseCreationLabel";
            courseCreationLabel.Size = new Size(305, 32);
            courseCreationLabel.TabIndex = 9;
            courseCreationLabel.Text = "Створення нового курсу";
            // 
            // loadPicButton
            // 
            loadPicButton.Location = new Point(444, 422);
            loadPicButton.Name = "loadPicButton";
            loadPicButton.Size = new Size(133, 54);
            loadPicButton.TabIndex = 10;
            loadPicButton.Text = "Завантажити";
            loadPicButton.UseVisualStyleBackColor = true;
            loadPicButton.Click += loadPicButton_Click;
            // 
            // profilePicLabel
            // 
            profilePicLabel.AutoSize = true;
            profilePicLabel.Location = new Point(27, 456);
            profilePicLabel.Name = "profilePicLabel";
            profilePicLabel.Size = new Size(97, 20);
            profilePicLabel.TabIndex = 11;
            profilePicLabel.Text = "Зображення";
            // 
            // previevPictureBox
            // 
            previevPictureBox.Location = new Point(583, 316);
            previevPictureBox.Name = "previevPictureBox";
            previevPictureBox.Size = new Size(240, 160);
            previevPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            previevPictureBox.TabIndex = 12;
            previevPictureBox.TabStop = false;
            // 
            // backButton
            // 
            backButton.Location = new Point(700, 10);
            backButton.Name = "backButton";
            backButton.Size = new Size(123, 53);
            backButton.TabIndex = 13;
            backButton.Text = "Повернутися";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(buttonsFlowLayoutPanel);
            panel1.Controls.Add(tagsGroupBox);
            panel1.Controls.Add(deleteModuleButton);
            panel1.Controls.Add(moduleFlowLayoutPanel);
            panel1.Controls.Add(addModuleButton);
            panel1.Controls.Add(courseCreationLabel);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(previevPictureBox);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(profilePicLabel);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(loadPicButton);
            panel1.Controls.Add(descriptionRichTextBox);
            panel1.Controls.Add(costLabel);
            panel1.Controls.Add(costTextBox);
            panel1.Controls.Add(tegsLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 813);
            panel1.TabIndex = 14;
            // 
            // buttonsFlowLayoutPanel
            // 
            buttonsFlowLayoutPanel.Controls.Add(createButton);
            buttonsFlowLayoutPanel.Controls.Add(changeButton);
            buttonsFlowLayoutPanel.Controls.Add(deleteButton);
            buttonsFlowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            buttonsFlowLayoutPanel.Location = new Point(366, 482);
            buttonsFlowLayoutPanel.Name = "buttonsFlowLayoutPanel";
            buttonsFlowLayoutPanel.Size = new Size(457, 65);
            buttonsFlowLayoutPanel.TabIndex = 21;
            // 
            // createButton
            // 
            createButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            createButton.ForeColor = Color.FromArgb(0, 192, 0);
            createButton.Location = new Point(310, 3);
            createButton.Name = "createButton";
            createButton.Size = new Size(144, 54);
            createButton.TabIndex = 14;
            createButton.Text = "Створити";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // changeButton
            // 
            changeButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            changeButton.ForeColor = SystemColors.HotTrack;
            changeButton.Location = new Point(160, 3);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(144, 54);
            changeButton.TabIndex = 20;
            changeButton.Text = "Змінити";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.ForeColor = Color.Red;
            deleteButton.Location = new Point(10, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(144, 54);
            deleteButton.TabIndex = 18;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
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
            tagsGroupBox.Location = new Point(237, 210);
            tagsGroupBox.Name = "tagsGroupBox";
            tagsGroupBox.Size = new Size(586, 100);
            tagsGroupBox.TabIndex = 6;
            tagsGroupBox.TabStop = false;
            tagsGroupBox.Text = "Теги";
            // 
            // marketingCheckBox
            // 
            marketingCheckBox.AutoSize = true;
            marketingCheckBox.Location = new Point(473, 56);
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
            designCheckBox.Location = new Point(384, 56);
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
            communicationCheckBox.Location = new Point(473, 26);
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
            cloudComputingCheckBox.Location = new Point(6, 26);
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
            leadershipAndManagementCheckBox.Location = new Point(266, 56);
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
            buisnessCheckBox.Location = new Point(384, 26);
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
            linguisticsCheckBox.Location = new Point(150, 26);
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
            dataScienceCheckBox.Location = new Point(265, 26);
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
            developmentCheckBox.Location = new Point(150, 56);
            developmentCheckBox.Name = "developmentCheckBox";
            developmentCheckBox.Size = new Size(97, 24);
            developmentCheckBox.TabIndex = 0;
            developmentCheckBox.Text = "Розробка";
            developmentCheckBox.UseVisualStyleBackColor = true;
            developmentCheckBox.CheckStateChanged += developmentCheckBox_CheckedChanged;
            // 
            // deleteModuleButton
            // 
            deleteModuleButton.BackColor = SystemColors.HotTrack;
            deleteModuleButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteModuleButton.ForeColor = SystemColors.ControlLightLight;
            deleteModuleButton.Location = new Point(213, 553);
            deleteModuleButton.Name = "deleteModuleButton";
            deleteModuleButton.Size = new Size(180, 54);
            deleteModuleButton.TabIndex = 17;
            deleteModuleButton.Text = "Видалити модуль";
            deleteModuleButton.UseVisualStyleBackColor = false;
            deleteModuleButton.Click += deleteModuleButton_Click;
            // 
            // moduleFlowLayoutPanel
            // 
            moduleFlowLayoutPanel.AutoSize = true;
            moduleFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            moduleFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            moduleFlowLayoutPanel.Location = new Point(27, 613);
            moduleFlowLayoutPanel.Name = "moduleFlowLayoutPanel";
            moduleFlowLayoutPanel.Size = new Size(796, 167);
            moduleFlowLayoutPanel.TabIndex = 16;
            // 
            // addModuleButton
            // 
            addModuleButton.BackColor = SystemColors.HotTrack;
            addModuleButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addModuleButton.ForeColor = SystemColors.ControlLight;
            addModuleButton.Location = new Point(27, 553);
            addModuleButton.Name = "addModuleButton";
            addModuleButton.Size = new Size(180, 54);
            addModuleButton.TabIndex = 15;
            addModuleButton.Text = "Додати модуль";
            addModuleButton.UseVisualStyleBackColor = false;
            addModuleButton.Click += addModuleButton_Click;
            // 
            // pictureFileDialog
            // 
            pictureFileDialog.FileName = "openFileDialog1";
            pictureFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp";
            // 
            // CourseCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(panel1);
            Name = "CourseCreation";
            Size = new Size(860, 813);
            ((System.ComponentModel.ISupportInitialize)previevPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            buttonsFlowLayoutPanel.ResumeLayout(false);
            tagsGroupBox.ResumeLayout(false);
            tagsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label descriptionLabel;
        private RichTextBox descriptionRichTextBox;
        private Label costLabel;
        private TextBox costTextBox;
        private Label tegsLabel;
        private Label courseCreationLabel;
        private Button loadPicButton;
        private Label profilePicLabel;
        private PictureBox previevPictureBox;
        private Button backButton;
        private Panel panel1;
        private Button createButton;
        private Button addModuleButton;
        private FlowLayoutPanel moduleFlowLayoutPanel;
        private Button deleteModuleButton;
        private GroupBox tagsGroupBox;
        private CheckBox marketingCheckBox;
        private CheckBox designCheckBox;
        private CheckBox communicationCheckBox;
        private CheckBox cloudComputingCheckBox;
        private CheckBox leadershipAndManagementCheckBox;
        private CheckBox buisnessCheckBox;
        private CheckBox linguisticsCheckBox;
        private CheckBox dataScienceCheckBox;
        private CheckBox cybersecurityCheckBox;
        private CheckBox developmentCheckBox;
        private OpenFileDialog pictureFileDialog;
        private Button deleteButton;
        private Button changeButton;
        private FlowLayoutPanel buttonsFlowLayoutPanel;
    }
}
