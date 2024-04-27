using CourseScreenSpace;
using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainScreen
{
    public partial class MainScreenBlock : UserControl
    {
        public event Action<CourseScreenSpace.CourseScreenBlock> openCourse;
        public event Action returnTo;
        public CoursesApp CoursesApp { get; set; }
        public MainScreenBlock(CoursesApp coursesApp)
        {
            InitializeComponent();
            CoursesApp = coursesApp;
            LoadCourses(CoursesApp.Courses);
        }
        //TODO
        private void LoadCourses(List<Course> courses)
        {
            Random rnd = new Random();
            int randNum = rnd.Next(0, 10);

            //change
            var loadingCourses = courses.Take(10);

            foreach (var course in loadingCourses)
            {
                var cElem = new CourseElement(course);

                //var cScreen = new CourseScreenBlock(course, CoursesApp.CurrentUser);
                //cScreen.returnToScreen += returnTo;

                cElem.toCourse += ToCourse;

                coursesFlowLayoutPanel.Controls.Add(cElem);
                cElem.Width = 1000;
            }
        }

        private void ToCourse(Course course)
        {
            CourseScreenBlock courseScreen = new CourseScreenBlock(course, CoursesApp.CurrentUser);
            openCourse?.Invoke(courseScreen);
            courseScreen.returnToScreen += returnTo;
        }
    }
}
