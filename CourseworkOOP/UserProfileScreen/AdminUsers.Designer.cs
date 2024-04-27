namespace UserProfileScreen
{
    partial class AdminUsers
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            login = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            surname = new DataGridViewTextBoxColumn();
            UserType = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            usersLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, login, password, name, surname, UserType, Delete });
            dataGridView1.Location = new Point(29, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(927, 429);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // login
            // 
            login.HeaderText = "login";
            login.MinimumWidth = 6;
            login.Name = "login";
            login.Width = 125;
            // 
            // password
            // 
            password.HeaderText = "password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // surname
            // 
            surname.HeaderText = "surname";
            surname.MinimumWidth = 6;
            surname.Name = "surname";
            surname.Width = 125;
            // 
            // UserType
            // 
            UserType.HeaderText = "UserType";
            UserType.MinimumWidth = 6;
            UserType.Name = "UserType";
            UserType.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 125;
            // 
            // usersLabel
            // 
            usersLabel.AutoSize = true;
            usersLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            usersLabel.Location = new Point(29, 20);
            usersLabel.Name = "usersLabel";
            usersLabel.Size = new Size(198, 25);
            usersLabel.TabIndex = 1;
            usersLabel.Text = "Список Користувачів";
            // 
            // AdminUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(usersLabel);
            Controls.Add(dataGridView1);
            Name = "AdminUsers";
            Size = new Size(975, 519);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn login;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn UserType;
        private DataGridViewButtonColumn Delete;
        private Label usersLabel;
    }
}
