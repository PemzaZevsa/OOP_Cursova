using CourseworkOOP.Entities.Courses;
using MainScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserProfileScreen
{
    public partial class StudentCourses : UserControl
    {
        public StudentCourses(List<Course> courses,List<uint> ids)
        {
            InitializeComponent();

            if (courses != null && courses.Count > 0)
            {
                Load(courses, ids);
            }
            
        }

        private void Load(List<Course> courses, List<uint> ids)
        {
            var MyCouses = courses.Where(x =>  ids.Contains(x.Id));
            foreach (Course course in MyCouses)
            {
                var courseEl = new CourseElement(course);
                coursesFlowLayoutPanel.Controls.Add(courseEl);
            }
        }
    }
}
