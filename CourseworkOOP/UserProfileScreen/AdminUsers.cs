using System;
using System.Windows.Forms;
using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities.Users;

namespace UserProfileScreen
{
    public partial class AdminUsers : UserControl
    {
        private List<User> Users;
        CoursesApp coursesApp;
        public AdminUsers(CoursesApp courses)
        {
            InitializeComponent();
            coursesApp = courses;
            Users = coursesApp.Users;
            foreach (var item in Users)
            {
                dataGridView1.Rows.Add(item.Id.ToString(), item.Login,item.Password,item.Name, item.Surname,item.UserType);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                int rowIndex = e.RowIndex;
                
                var res = MessageBox.Show("Ви впевнені, що хочете видалити?","Видалення",MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    try
                    {
                        uint idToDelete = uint.Parse((string)dataGridView1.Rows[e.RowIndex].Cells["id"].Value);                    

                        if(((Admin)coursesApp.CurrentUser).DeleteUser(coursesApp.Users, idToDelete))
                        {
                            dataGridView1.Rows.RemoveAt(rowIndex);
                        }                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при видаленні користувача: {ex.Message}");
                        throw;
                    }                   
                }
            }
        }
    }
}
