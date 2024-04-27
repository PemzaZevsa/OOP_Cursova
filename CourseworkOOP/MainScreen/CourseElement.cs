using CourseworkOOP.Entities;
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
            SetName(Course.Name);
            SetDescription(Course.Description);
            SetRaiting(Course.Rating, Course.RatingsAmount);
            SetTegs(Course.Tegs);
            SetPicture(Course.PicturePath);
            SetAuthor(Course.AuthorName, Course.AuthorSurname);
        }

        private void SetName(string name)
        {
            nameLabel.Text = name;
        }
        private void SetDescription(string description)
        {
            descriptionLabel.Text = description;
        }
        private void SetRaiting(double raiting, int raitingsAmount)
        {
            raitingLabel.Text += " " + string.Join(" ", $"{Math.Round(raiting, 2)}", $"({raitingsAmount} відгуків)");
        }
        private void SetTegs(List<Teg> Tegs)
        {
            tegsLabel.Text += " " + string.Join(", ", Tegs);
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
        private void SetAuthor(string authorName, string authorSurname)
        {
            authorLabel.Text += " " + string.Join(" ", authorName, authorSurname);
        }

        private void toCourseButton_Click(object sender, EventArgs e)
        {
            toCourse?.Invoke(Course);
        }
    }
}
