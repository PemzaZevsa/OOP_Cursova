﻿using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace MainScreen
{
    public partial class CourseElement : UserControl
    {
        public event Action<Course> toCourse;
        public Course Course { get; set; }
        public CourseElement(Course course)
        {
            InitializeComponent();
            Course = course;
            SetPicture(Course.PicturePath);


            nameLabel.Text = Course.Name;
            descriptionLabel.Text = Course.Description;
            raitingLabel.Text += " " + string.Join(" ", $"{Math.Round(Course.Rating, 2)}", $"({Course.RatingsAmount} відгуків)");
            tegsLabel.Text += " " + string.Join(", ", Course.Tegs);
            authorLabel.Text += " " + string.Join(" ", Course.AuthorName, Course.AuthorSurname);
        }

        private void SetPicture(string path)
        {
            try
            {
                Image image = Image.FromFile(path);
                coursePictureBox.Image = image;
            }
            catch (Exception ex)
            {
                Image image2 = Image.FromFile(@"Data/Config/CoursePlaceholder.png");
                coursePictureBox.Image = image2;
            }

        }

        private void toCourseButton_Click(object sender, EventArgs e)
        {
            toCourse?.Invoke(Course);
        }
    }
}