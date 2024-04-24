using HeaderSpace;
using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Metrics;
using CourseworkOOP.Entities.Users;
using System.Linq;

namespace CourseworkOOP
{
    public partial class Form1 : Form
    {
        public CoursesApp coursesApp;
        public UserProfileScreen.UserProfileScreenBlock UserProfile {  get; set; }

        public Form1()
        {
            InitializeComponent();

            myHeader.toMainScreen += ToMain;
            myHeader.toRegistrationScreen += ToRegistration;
            myHeader.toUserProfileScreen += ToUserProfile;
            //UserProfile = new UserProfileScreen.UserProfileScreenBlock(coursesApp.CurrentUser);

            coursesApp = new CoursesApp((name,surname) =>
            {
                myHeader.ActivateChangeCurrentUserLabel(name,surname);
            });
            coursesApp.Load();          
        }
        public void ToRegistration()
        {
            mainPanel.Controls.Clear();
            RegistrationScreen.RegistrationScreen registration = new RegistrationScreen.RegistrationScreen();
            registration.authorisation.authorisationButtonClick += (string login, string password) =>
            {
                var tempUser = coursesApp.Users.Where(u => u.Login == login).Where(u => u.Password == password).Take(1).FirstOrDefault();
                if (tempUser != null)
                {
                    coursesApp.CurrentUser = tempUser;
                    myHeader.ChangeToAuthorised();
                    MessageBox.Show("Успішна авторизація!");
                    ToMain();
                }
                else
                {
                    registration.authorisation.ActivateError();
                }
            };

            registration.registration.regestrationButtonClick += (string login, string password, string name, string surname,int userType) =>
            {
                if (coursesApp.Users.Where(u => u.Login == login).Take(1).FirstOrDefault() is null)
                {
                    switch (userType)
                    {
                        case 1: 
                            Teacher teacher = new Teacher(name,surname,login,password);
                            coursesApp.Users.Add(teacher);
                            coursesApp.CurrentUser = teacher;
                            break;
                        case 2: 
                            Student student = new Student(name,surname,login,password);
                            coursesApp.Users.Add(student);
                            coursesApp.CurrentUser = student;
                            break;
                        default:
                            break;
                    }
                    
                }
                else
                {
                    registration.registration.ActivateError();
                }

            };

            mainPanel.Controls.Add(registration);
            registration.Dock = DockStyle.Fill;
        }

        public void ToMain()
        {
            mainPanel.Controls.Clear();
            MainScreen.MainScreen screen = new MainScreen.MainScreen(coursesApp);
            screen.openCourse += (someCourse) =>
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(someCourse);
                someCourse.Dock = DockStyle.Fill;
            };

            screen.returnTo += () =>
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(screen);
                screen.Dock = DockStyle.Fill;
            };
            mainPanel.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
        }

        public void ToUserProfile()
        {
            mainPanel.Controls.Clear();
            UserProfileScreen.UserProfileScreenBlock screen = new UserProfileScreen.UserProfileScreenBlock(coursesApp.CurrentUser);
            screen.logOut += () =>
            {
                coursesApp.CurrentUser = null;
                myHeader.ChangeToUnAuthorised();
                ToMain();
            };
            mainPanel.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
        }

        private void Screen_logOut()
        {
            throw new NotImplementedException();
        }
    }
}
