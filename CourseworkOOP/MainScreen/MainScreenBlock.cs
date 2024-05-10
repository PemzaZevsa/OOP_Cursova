using CourseScreenSpace;
using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using System.Data;

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

        private void LoadCourses(List<Course> courses)
        {
            Random rnd = new Random();
            int randNum = rnd.Next(1, 10);

            var loadingCourses = courses.Where(x => x.Id % randNum == 0).Take(20).OrderByDescending(x => x.Rating);

            foreach (var course in loadingCourses)
            {
                var cElem = new CourseElement(course);

                cElem.toCourse += ToCourse;

                coursesFlowLayoutPanel.Controls.Add(cElem);
                cElem.Width = 1200;
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
