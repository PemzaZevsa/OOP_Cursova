using CourseworkOOP.Entities.Courses;

namespace UserProfileScreen
{
    public partial class ModuleCreation : UserControl
    {
        public List<LessonCreation> LessonsElements;
        public Module moduleToChange;
        public ModuleCreation()
        {
            InitializeComponent();
            LessonsElements = new List<LessonCreation>();
        }
        public ModuleCreation(Module module)
        {
            InitializeComponent();
            LessonsElements = new List<LessonCreation>();
            moduleToChange = module;

            nameTextBox.Text = module.Name;
            descriptionTextBox.Text = module.Description;

            LoadModule(moduleToChange);
        }

        private void LoadModule(Module module)
        {
            foreach (var lesson in module.Lessons)
            {
                var lessonEl = new LessonCreation(lesson);
                lessonsFlowLayoutPanel.Controls.Add(lessonEl);
            }
        }


        private void addLessonButton_Click(object sender, EventArgs e)
        {
            var lesson = new LessonCreation();
            lessonsFlowLayoutPanel.Controls.Add(lesson);
            LessonsElements.Add(lesson);
        }

        private void deleteLessonButton_Click(object sender, EventArgs e)
        {
            if (lessonsFlowLayoutPanel.Controls.Count > 0)
                lessonsFlowLayoutPanel.Controls.RemoveAt(lessonsFlowLayoutPanel.Controls.Count - 1);
            if (LessonsElements.Count > 0)
                LessonsElements.RemoveAt(LessonsElements.Count - 1);
        }
        public Module ChangeModule()
        {
            if (moduleToChange is not null) 
            {
                List<Lesson> TempLessons = new List<Lesson>();

                foreach (var lessonItem in LessonsElements)
                {
                    TempLessons.Add(lessonItem.ChangeLesson());
                }
                moduleToChange.Name = nameTextBox.Text;
                moduleToChange.Description = descriptionTextBox.Text;

                moduleToChange.Lessons = TempLessons;

                return moduleToChange;
            }
            else
            {
                return CreateModule();
            }            
        }

        public Module CreateModule()
        {
            List<Lesson> Lessons = new List<Lesson>();
            foreach (var lessonItem in LessonsElements)
            {
                Lessons.Add(lessonItem.CreateLesson());
            }

            return new Module(nameTextBox.Text,descriptionTextBox.Text, Lessons);
        }
    }
}
