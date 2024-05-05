using CourseworkOOP.Entities.Courses;

namespace UserProfileScreen
{
    public partial class LessonCreation : UserControl
    {
        Lesson lessonToChange;
        public LessonCreation()
        {
            InitializeComponent();
        }
        public LessonCreation(Lesson lesson)
        {
            InitializeComponent();
            lessonToChange = lesson;
            nameTextBox.Text = lesson.Name;
            materialsRichTextBox.Text = lesson.Materials;
        }
        public Lesson ChangeLesson()
        {
            if (lessonToChange != null)
            {
                lessonToChange.Name = nameTextBox.Text;
                lessonToChange.Materials = materialsRichTextBox.Text;
                return lessonToChange;
            }
            else
            {
                return CreateLesson();
            }
        }
        public Lesson CreateLesson()
        {
            return new Lesson(nameTextBox.Text,materialsRichTextBox.Text);
        }
    }
}
