using CourseScreenSpace;
using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using MainScreen;
using System.Data;

namespace UserProfileScreen
{
    public partial class TeacherCourses : UserControl
    {
        public event Action createNewCourse;
        public event Action returnTo;
        public event Action<CourseScreenSpace.CourseScreenBlock> openCourse;
        public CoursesApp MyApp;
        public TeacherCourses(CoursesApp App)
        {
            InitializeComponent();
            MyApp = App;
            LoadCourses(MyApp.Courses);
        }

        private void LoadCourses(List<Course> courses)
        {
            coursesFlowLayoutPanel.Controls.Clear();
            //TODO mb change?
            var result = courses.Where(x => x.AuthorId == MyApp.CurrentUser.Id);

            foreach (var course in result)
            {
                var cElem = new CourseElement(course);

                cElem.toCourse += ToCourse;

                coursesFlowLayoutPanel.Controls.Add(cElem);
                cElem.Width = 1000;
            }
        }

        private void ToCourse(Course course)
        {
            CourseScreenBlock courseScreen = new CourseScreenBlock(course, MyApp.CurrentUser);
            openCourse?.Invoke(courseScreen);
            courseScreen.returnToScreen += returnTo;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createNewCourse?.Invoke();
        }


    }
}
