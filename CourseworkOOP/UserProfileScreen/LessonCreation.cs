using CourseworkOOP.Entities.Courses;

namespace UserProfileScreen
{
    public partial class LessonCreation : UserControl
    {
        public LessonCreation()
        {
            InitializeComponent();
        }

        public Lesson CreateLesson()
        {
            return new Lesson(nameTextBox.Text,materialsRichTextBox.Text);
        }
    }
}
