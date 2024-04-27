using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities.Users;
using CourseworkOOP.Iterfaces;
using System.Reflection;
using System.Text.Json;

namespace UserProfileScreen
{
    public partial class UserProfileScreenBlock : UserControl
    {
        public event Action logOut;
        public CoursesApp MyApp;
        public User MyUser { get; set; }
        public UserProfileScreenBlock(CoursesApp app)
        {
            InitializeComponent();
            MyApp = app;
            this.MyUser = MyApp.CurrentUser;
            SetPicture(MyUser.ProfilePicturePath);
            settingsButton_Click(new object(), new EventArgs());
            
        }
        //TODO delete
        private void SetPicture(string path)
        {
            try
            {
                Image image = Image.FromFile(path);
                userProfilePictureBox.Image = image;
                //image.Dispose();
            }
            catch (Exception ex)
            {
                Image image2 = Image.FromFile(@"Data/Config/UserProfilePicturePlaceholder.png");
                userProfilePictureBox.Image = image2;
                //MessageBox.Show("Помилка завантаження зображения: " + ex.Message);
            }
        }        

        private void settingsButton_Click(object sender, EventArgs e)
        {
            infoPanel.Controls.Clear();
            var settings = new UserSettings();

            settings.profileUpdate += UpdateUser;

            infoPanel.Controls.Add(settings);
            settings.Dock = DockStyle.Fill;
        }
        //TODO change
        private void UpdateUser(string newPassword,string newName,string newSurname,Image newImage)
        {
            //TODO
            try
            {
                MyUser.Password = newPassword;
                MyUser.Name = newName;
                MyUser.Surname = newName;

                //string imagePath = "PP.jpg";
                //File.Delete(MyUser.ProfilePicturePath);

                //delete
                File.WriteAllBytes(MyUser.ProfilePicturePath, ImageToByteArray(newImage));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка : {ex.Message}", "Помилка при зміні властивостей користувача");
            }
                
        }

        //TODO delete
        static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void istudyableButton_Click(object sender, EventArgs e)
        {
            if (MyUser is not IStudyable)
            {
                //TODO
                MessageBox.Show("Ви не учень");
                return;
            }

            infoPanel.Controls.Clear();
            var myCourses = new StudentCourses(MyApp.Courses,((Student)MyUser).CoursesIds);
            infoPanel.Controls.Add(myCourses);
            myCourses.Dock = DockStyle.Fill;
        }

        private void iTeachebleButton_Click(object sender, EventArgs e)
        {
            if (MyUser is not ITeacheble)
            {
                //TODO
                MessageBox.Show("Ви не вчитель");
                return;
            }

            infoPanel.Controls.Clear();
            var myCreatedCourses = new TeacherCourses(MyApp);
            myCreatedCourses.createNewCourse += () =>
            {
                infoPanel.Controls.Clear();
                var courseCreat = new CourseCreation();
                infoPanel.Controls.Add(courseCreat);

                courseCreat.createCourse += (name, description, cost,modules,tegs,imagePath) =>
                {
                    //TODO COURSE FILE SYSTEM CREATEON
                    
                    var newCourse = new Course(name, description,MyApp.CurrentUser.Id, MyApp.CurrentUser.Name, MyApp.CurrentUser.Surname, 0, 0, cost, tegs,modules);
                    string pathToFolder = $"Data\\Courses\\{newCourse.Id}";
                    Directory.CreateDirectory(pathToFolder);

                    newCourse.Save();
                    //
                    string destinationImagePath = $"Data\\Courses\\{newCourse.Id}\\Icon.bmp";

                    try
                    {
                        byte[] imageBytes = File.ReadAllBytes(imagePath);

                        File.WriteAllBytes(destinationImagePath, imageBytes);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при копировании изображения: " + ex.Message);
                    }
                    //
                    MyApp.Courses.Add(newCourse);
                };

                courseCreat.returnToMyCourses += () =>
                {
                    infoPanel.Controls.Clear();
                    infoPanel.Controls.Add(myCreatedCourses);
                    myCreatedCourses.Dock = DockStyle.Fill;
                };
                courseCreat.Dock = DockStyle.Fill;
            };

            infoPanel.Controls.Add(myCreatedCourses);
            myCreatedCourses.Dock = DockStyle.Fill;
        }

        private void iControlableButton_Click(object sender, EventArgs e)
        {
            if (MyUser is not IControlable)
            {
                //TODO
                MessageBox.Show("У вас немає необхідних прав");
                return;
            }

            infoPanel.Controls.Clear();
            var usersScreen = new AdminUsers(MyApp);
            infoPanel.Controls.Add(usersScreen);
            usersScreen.Dock = DockStyle.Fill;
        }       

        private void statisticButton_Click(object sender, EventArgs e)
        {
            if (MyUser is not IControlable)
            {
                //TODO
                MessageBox.Show("У вас немає необхідних прав");
                return;
            }

            infoPanel.Controls.Clear();
            var statistic = new Statistics(Course.counter, CourseworkOOP.Entities.Courses.Module.counter, Lesson.counter, User.counter);
            infoPanel.Controls.Add(statistic);
            statistic.Dock = DockStyle.Fill;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Ви впевнені?", "Вихід з облікового запису", buttons: MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                logOut?.Invoke();
            }

        }
    }
}
