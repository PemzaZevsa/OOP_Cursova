﻿using CourseworkOOP.Entities.Courses;
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
