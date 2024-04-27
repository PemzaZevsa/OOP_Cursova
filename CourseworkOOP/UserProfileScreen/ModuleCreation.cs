using CourseworkOOP.Entities.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserProfileScreen
{
    public partial class ModuleCreation : UserControl
    {
        public List<LessonCreation> LessonsElements;         
        public ModuleCreation()
        {
            InitializeComponent();
            LessonsElements = new List<LessonCreation>();
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
