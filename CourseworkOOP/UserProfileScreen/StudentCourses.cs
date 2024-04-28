using CourseworkOOP.Entities.Courses;
using MainScreen;
using System.Data;

namespace UserProfileScreen
{
    public partial class StudentCourses : UserControl
    {
        public event Action<CourseEducation> toEducation;
        public event Action returnTo;
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
            var MyCouses = courses.Where(x => ids.Contains(x.Id));
            foreach (Course course in MyCouses)
            {
                var courseEl = new CourseElement(course);
                courseEl.toCourse += ToCourse;

                coursesFlowLayoutPanel.Controls.Add(courseEl);
            }
        }

        private void ToCourse(Course course)
        {
            CourseEducation courseScreen = new CourseEducation(course);
            toEducation?.Invoke(courseScreen);
            courseScreen.returnTo += returnTo;
        }
    }
}
