using CourseScreenSpace;
using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities.Users;
using MainScreen;

namespace SeachScreen
{
    public partial class SeacrchScreenBlock : UserControl
    {
        public event Action<CourseScreenSpace.CourseScreenBlock> openCourse;
        public event Action returnTo;

        public string Query { get; set; }
        public CoursesApp MyCoursesApp { get; set; }
        private IEnumerable<Course> result;
        private List<Teg> tegs;
        private double raitings;
        public SeacrchScreenBlock(string query, CoursesApp coursesApp)
        {
            InitializeComponent();
            tegs = new List<Teg>();
            Query = query;
            MyCoursesApp = coursesApp;

            foundLabel.Text += $"\"{query}\"";
            LoadCourses(coursesApp.Courses);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            coursesFlowLayoutPanel.Controls.Clear();

            var loadingCourses = result.Where(x => x.Rating >= raitings);
            
            //Якщо користувач не вказав жодний checkBox, то це не виконується
            if (tegs.Count > 0)
            {
                loadingCourses = from o in loadingCourses
                                 where o.Tegs.Any(x => tegs.Contains(x))
                                 select o;
            }

            foreach (var course in loadingCourses)
            {
                var cElem = new CourseElement(course);

                cElem.toCourse += ToCourse;

                coursesFlowLayoutPanel.Controls.Add(cElem);
                cElem.Width = 1000;
            }
        }

        private void LoadCourses(List<Course> courses)
        {
            coursesFlowLayoutPanel.Controls.Clear();
            //mb change?
            result = courses.Where(x => x.Name.ToLowerInvariant().Contains(Query.ToLowerInvariant()));

            foreach (var course in result)
            {
                var cElem = new CourseElement(course);

                cElem.toCourse += ToCourse;

                coursesFlowLayoutPanel.Controls.Add(cElem);
                cElem.Width = 1200;
            }
        }

        private void ToCourse(Course course)
        {
            CourseScreenBlock courseScreen = new CourseScreenBlock(course, MyCoursesApp.CurrentUser);
            openCourse?.Invoke(courseScreen);
            courseScreen.returnToScreen += returnTo;
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (allRadioButton.Checked)
            {
                raitings = 0;
            }
        }

        private void fiveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fiveRadioButton.Checked)
            {
                raitings = 5;
            }
        }

        private void sixRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sixRadioButton.Checked)
            {
                raitings = 6;
            }
        }

        private void sevenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sevenRadioButton.Checked)
            {
                raitings = 7;
            }
        }

        private void eightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (eightRadioButton.Checked)
            {
                raitings = 8;
            }
        }

        private void nineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (nineRadioButton.Checked)
            {
                raitings = 9;
            }
        }




        private void developmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (developmentCheckBox.Checked)
            {
                tegs.Add(Teg.Development);
            }
            else
            {
                tegs.RemoveAll(x => x == Teg.Development);
            }
        }

        private void cybersecurityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cybersecurityCheckBox.Checked)
            {
                tegs.Add(Teg.Cybersecurity);
            }
            else
            {
                tegs.RemoveAll(x => x == Teg.Cybersecurity);
            }
        }

        private void dataScienceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dataScienceCheckBox.Checked)
            {
                tegs.Add(Teg.DataScience);
            }
            else
            {
                tegs.RemoveAll(x => x == Teg.DataScience);
            }
        }

        private void cloudComputingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cloudComputingCheckBox.Checked)
            {
                tegs.Add(Teg.CloudComputing);
            }
            else
            {
                tegs.RemoveAll(x => x == Teg.CloudComputing);
            }
        }

        private void communicationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (communicationCheckBox.Checked)
            {
                tegs.Add(Teg.Communication);
            }
            else
            {
                tegs.RemoveAll(x => x == Teg.Communication);
            }
        }

        private void linguisticsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (linguisticsCheckBox.Checked)
            {
                tegs.Add(Teg.Linguistics);
            }
            else
            {
                tegs.RemoveAll(x => x == Teg.Linguistics);
            }
        }

        private void buisnessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (buisnessCheckBox.Checked)
            {
                tegs.Add(Teg.Buisness);
            }
            else
            {
                tegs.RemoveAll(x => x == Teg.Buisness);
            }
        }

        private void leadershipAndManagementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (leadershipAndManagementCheckBox.Checked)
            {
                tegs.Add(Teg.LeadershipAndManagement);
            }
            else
            {
                tegs.RemoveAll(x => x == Teg.LeadershipAndManagement);
            }
        }

        private void designCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (designCheckBox.Checked)
            {
                tegs.Add(Teg.Design);
            }
            else
            {
                tegs.RemoveAll(x => x == Teg.Design);
            }
        }

        private void marketingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (marketingCheckBox.Checked)
            {
                tegs.Add(Teg.Marketing);
            }
            else
            {
                tegs.RemoveAll(x => x == Teg.Marketing);
            }
        }
    }
}
