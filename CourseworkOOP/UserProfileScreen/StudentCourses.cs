using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities.Users;
using MainScreen;
using System.Data;

namespace UserProfileScreen
{
    public partial class StudentCourses : UserControl
    {
        public event Action<CourseEducation> toEducation;
        public event Action returnTo;
        private IEnumerable<Course> result;
        private IEnumerator<Course>? iterator;
        User User { get; set; }
        public StudentCourses(List<Course> courses, List<uint> ids, User user)
        {
            InitializeComponent();
            User = user;
            result = null;
            var tempRes = GetCourse();
            iterator = tempRes.GetEnumerator();

            if (courses != null && courses.Count > 0)
            {
                Load(courses, ids);
            }

            GetNextCourses();
        }

        private void Load(List<Course> courses, List<uint> ids)
        {
            result = courses.Where(x => ids.Contains(x.Id));
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
            CourseEducation courseScreen = new CourseEducation(course, User);
            toEducation?.Invoke(courseScreen);
            courseScreen.returnTo += returnTo;
        }

        private void loadMoreButton_Click(object sender, EventArgs e)
        {
            GetNextCourses();
        }
    }
}
