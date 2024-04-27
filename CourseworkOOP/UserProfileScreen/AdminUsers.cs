using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities.Users;

namespace UserProfileScreen
{
    public partial class AdminUsers : UserControl
    {
        private List<User> Users;
        CoursesApp Courses;
        public AdminUsers(CoursesApp courses)
        {
            InitializeComponent();
            Courses = courses;
            Users = Courses.Users;
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
                    var idToDelete = dataGridView1.Rows[e.RowIndex].Cells["id"].Value;

                    Users.RemoveAll(p => p.Id == uint.Parse(idToDelete.ToString()) );
                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
            }
        }
    }
}
