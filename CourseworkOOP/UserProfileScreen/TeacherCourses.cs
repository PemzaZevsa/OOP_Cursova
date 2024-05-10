using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Iterfaces;
using MainScreen;
using System.Data;

namespace UserProfileScreen
{
    public partial class TeacherCourses : UserControl
    {
        public event Action createNewCourse;
        public event Action returnTo;
        public event Action<CourseCreation> openCourse;
        public CoursesApp MyApp;
        private IEnumerable<Course> result;
        private IEnumerator<Course>? iterator;
        public TeacherCourses(CoursesApp App)
        {
            InitializeComponent();
            MyApp = App;            
            result = null;
            LoadCourses(MyApp.Courses);

            var tempRes = GetCourse();
            iterator = tempRes.GetEnumerator();
            GetNextCourses();
        }

        private void LoadCourses(List<Course> courses)
        {
            coursesFlowLayoutPanel.Controls.Clear();

            result = ((ITeacheble)MyApp.CurrentUser).GetMyCourses(courses);
        }

        private void GetNextCourses()
        {
            for (int i = 0; i < 5; i++)
            {
                if (iterator.MoveNext())
                {
                    var cElem = new CourseElement(iterator.Current);

                    cElem.toCourse += ToCourse;

                    coursesFlowLayoutPanel.Controls.Add(cElem);
                    cElem.Width = 1200;
                }
                else
                {
                    break;
                }
            }
        }

        private IEnumerable<Course> GetCourse()
        {
            foreach (var item in result)
            {
                yield return item;
            }
        }

        private void ToCourse(Course course)
        {
            CourseCreation courseScreen = new CourseCreation(course);
            openCourse?.Invoke(courseScreen);
            courseScreen.returnToMyCourses += returnTo;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createNewCourse?.Invoke();
        }

        private void loadMoreButton_Click(object sender, EventArgs e)
        {
            GetNextCourses();
        }
    }
}
