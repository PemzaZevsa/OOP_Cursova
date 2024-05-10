using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;

namespace UserProfileScreen
{
    public partial class CourseCreation : UserControl
    {
        public event Action returnToMyCourses;
        //                  name, description, cost, modules, tegs, imagePath
        public event Action<string, string, decimal, List<Module>, List<Teg>, string> createCourse;
        public event Action<Course> deleteCourse;
        public List<Teg> tegs;
        public List<ModuleCreation> modulesElements;
        public Course courseToChange;
        public CourseCreation()
        {
            InitializeComponent();
            tegs = new List<Teg>();
            modulesElements = new List<ModuleCreation>();
            buttonsFlowLayoutPanel.Controls.Clear();
            buttonsFlowLayoutPanel.Controls.Add(createButton);            
        }

        public CourseCreation(Course course)
        {
            InitializeComponent();
            tegs = new List<Teg>();
            modulesElements = new List<ModuleCreation>();
            buttonsFlowLayoutPanel.Controls.Clear();

            
            buttonsFlowLayoutPanel.Controls.Add(changeButton);
            buttonsFlowLayoutPanel.Controls.Add(deleteButton);
            courseToChange = course;
            LoadCourse(courseToChange);
        }

        private void LoadCourse(Course course)
        {
            foreach (var module in course.Modules)
            {
                ModuleCreation moduleCreation = new ModuleCreation(module);

                moduleFlowLayoutPanel.Controls.Add(moduleCreation);
            }
            nameTextBox.Text = course.Name;
            descriptionRichTextBox.Text = course.Description;
            costTextBox.Text = $"{course.Cost}";
            
            if (course.Tegs.Contains(Teg.Development))
            {
                developmentCheckBox.Checked = true;
            }
            if (course.Tegs.Contains(Teg.Cybersecurity))
            {
                cybersecurityCheckBox.Checked = true;
            }
            if (course.Tegs.Contains(Teg.DataScience))
            {
                dataScienceCheckBox.Checked = true;
            }
            if (course.Tegs.Contains(Teg.CloudComputing))
            {
                cloudComputingCheckBox.Checked = true;
            }
            if (course.Tegs.Contains(Teg.Communication))
            {
                communicationCheckBox.Checked = true;
            }
            if (course.Tegs.Contains(Teg.Linguistics))
            {
                linguisticsCheckBox.Checked = true;
            }
            if (course.Tegs.Contains(Teg.Buisness))
            {
                buisnessCheckBox.Checked = true;
            }
            if (course.Tegs.Contains(Teg.LeadershipAndManagement))
            {
                leadershipAndManagementCheckBox.Checked = true;
            }
            if (course.Tegs.Contains(Teg.Design))
            {
                designCheckBox.Checked = true;
            }
            if (course.Tegs.Contains(Teg.Marketing))
            {
                marketingCheckBox.Checked = true;
            }

            previevPictureBox.ImageLocation = course.PicturePath;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете вийти зі сторінки створення курсу? Введені дані не збережуться.", "Вихід до сторінки своїх курсів", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            returnToMyCourses?.Invoke();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете створити новий курс?", "Створення нового курсу", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                List<Module> modules = new List<Module>();
                foreach (var module in modulesElements)
                {
                    modules.Add(module.CreateModule());
                }

                createCourse?.Invoke(nameTextBox.Text.Trim(), descriptionRichTextBox.Text.Trim(), decimal.Parse(costTextBox.Text.Trim()), modules, tegs, pictureFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка:{ex.Message}", "Помилка при створенні нового курсу!");
                return;
            }
            MessageBox.Show("Курс було успішно створено", "Створення нового курсу");
            returnToMyCourses?.Invoke();
        }        

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете змінити курс?", "Змінення курсу", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            List<Module> backUpModules = courseToChange.Modules;

            try
            {
                courseToChange.Name = nameTextBox.Text;
                courseToChange.Description = descriptionRichTextBox.Text.Trim();
                courseToChange.Cost = decimal.Parse(costTextBox.Text.Trim());
                courseToChange.Tegs = tegs;

                if (pictureFileDialog.FileName is not null && pictureFileDialog.FileName != string.Empty)
                {
                    string imagePath = pictureFileDialog.FileName;
                    string destinationImagePath = $"Data\\Courses\\{courseToChange.Id}\\Icon.bmp";

                    try
                    {
                        byte[] imageBytes = File.ReadAllBytes(imagePath);

                        File.WriteAllBytes(destinationImagePath, imageBytes);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при копировании изображения: " + ex.Message);
                    }
                }

                List<Module> tempModules = new List<Module>();
                

                foreach (var module in modulesElements)
                {
                    tempModules.Add(module.ChangeModule());
                }

                courseToChange.Modules = tempModules;

            }
            catch (Exception ex)
            {
                courseToChange.Modules = backUpModules;
                MessageBox.Show($"Помилка:{ex.Message}", "Помилка при зміні курсу!");
                return;
            }
            MessageBox.Show("Курс було змінено", "Редагування курсу");
            returnToMyCourses?.Invoke();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете видалити курс?", "Видалення курсу", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            deleteCourse?.Invoke(courseToChange);
            MessageBox.Show("Курс було видалено", "Видалення курсу");
            returnToMyCourses();
        }

        private void loadPicButton_Click(object sender, EventArgs e)
        {
            if (pictureFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image newProfilePic = Image.FromFile(pictureFileDialog.FileName);
                    previevPictureBox.Image = newProfilePic;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні зображення: " + ex.Message);
                }
            }
        }




        private void addModuleButton_Click(object sender, EventArgs e)
        {
            var module = new ModuleCreation();
            moduleFlowLayoutPanel.Controls.Add(module);
            modulesElements.Add(module);
        }

        private void deleteModuleButton_Click(object sender, EventArgs e)
        {
            if (moduleFlowLayoutPanel.Controls.Count > 0)
                moduleFlowLayoutPanel.Controls.RemoveAt(moduleFlowLayoutPanel.Controls.Count - 1);
            if (modulesElements.Count > 0)
                modulesElements.RemoveAt(modulesElements.Count - 1);
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
