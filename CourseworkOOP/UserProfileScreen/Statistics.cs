using CourseworkOOP.Entities;
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
    public partial class Statistics : UserControl
    {
        public Statistics(uint courses,uint modules, uint lessons, uint users)
        {
            InitializeComponent();
            SetLabels(courses, modules, lessons, users);
        }

        public Statistics(CoursesAppSettings settings)
        {
            InitializeComponent();
            SetLabels(settings.CourseCounter, settings.ModuleCounter, settings.LessonCounter, settings.UserCounter);
        }

        public void SetLabels(uint courses, uint modules, uint lessons, uint users)
        {
            userCreatedLabel.Text += users;
            coursesCreatedLabel.Text += courses;
            moduleCreatedLabel.Text += modules;
            lessonsCreatedLabel.Text += lessons;
        }
    }
}
