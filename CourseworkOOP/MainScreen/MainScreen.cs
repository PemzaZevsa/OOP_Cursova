using CourseScreenSpace;
using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities.Users;

namespace MainScreen
{
    public partial class MainScreen : UserControl
    {
        public event Action<CourseScreenSpace.CourseScreenBlock> openCourse;
        public event Action returnTo;
        public CoursesApp CoursesApp { get; set; }
        public MainScreen(CoursesApp coursesApp)
        {
            InitializeComponent(coursesApp);
            CoursesApp = coursesApp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseScreenSpace.CourseScreenBlock courseScreen = new CourseScreenSpace.CourseScreenBlock(CoursesApp.Courses[0],CoursesApp.CurrentUser);
            openCourse?.Invoke(courseScreen);
            courseScreen.returnToScreen += returnTo;
        }
    }
}
