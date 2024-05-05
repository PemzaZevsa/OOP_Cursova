using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities.Users;
using System;

namespace UserProfileScreen
{
    public partial class CourseEducation : UserControl
    {
        public event Action returnTo;
        Course MyCourse { get; set; }
        User MyUser { get; set; }
        public CourseEducation(Course course,User user)
        {
            InitializeComponent();
            MyCourse = course;
            courseNameLabel.Text = course.Name;
            MyUser = user;

            //нужно, если бы грузились курсы отдельно от модулей
            //MyCourse.Load();

            SettingButtonsMenu(MyCourse);
        }

        private void SettingButtonsMenu(Course course)
        {
            foreach (var module in course.Modules)
            {
                var moduleElem = new FlowLayoutPanel();
                moduleElem.AutoSize = true;
                moduleElem.FlowDirection = FlowDirection.TopDown;
                moduleElem.Width = courseStuctureFlowLayoutPanel.Width - 10;
                moduleElem.BorderStyle = BorderStyle.FixedSingle;

                var moduleNameLabel = new Label();
                var moduleDescrLabel = new Label();
                moduleNameLabel.Text = module.Name;
                moduleDescrLabel.Text = module.Description;
                courseStuctureFlowLayoutPanel.Controls.Add(moduleNameLabel);
                courseStuctureFlowLayoutPanel.Controls.Add(moduleDescrLabel);

                foreach (var lesson in module.Lessons)
                {
                    var toLessonButton = new Button();
                    toLessonButton.BackColor = Color.White;
                    toLessonButton.Height = 50;
                    toLessonButton.Width = moduleElem.Width - 10;
                    toLessonButton.AutoSize = true;
                    toLessonButton.Text = lesson.Name;

                    toLessonButton.Click += (sender, eventHandler) =>
                    {
                        ChooseLesson(lesson);
                    };

                    moduleElem.Controls.Add(toLessonButton);
                }

                courseStuctureFlowLayoutPanel.Controls.Add(moduleElem);
            }

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            returnTo?.Invoke();
        }

        private void ChooseLesson(Lesson currentLesson)
        {
            nameLessonLabel.Text = currentLesson.Name;
            contentListBox.Items.Clear();
            contentListBox.Items.Add(currentLesson.Materials);
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            if (!MyCourse.RaitedUsersId.Contains(MyUser.Id))
            {
                try
                {
                    var raitingform = new SetRaiting();
                    raitingform.raiting += (r) =>
                    {
                        MyCourse.Rating = r;
                        MyCourse.RaitedUsersId.Add(MyUser.Id);
                    };

                    raitingform.ShowDialog();
                    MessageBox.Show($"Успішна оцінка");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка : {ex.Message}");
                }
            }
        }
    }
}
