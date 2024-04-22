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

        public Form1()
        {
            InitializeComponent();

            myHeader.toMainScreen += ToMain;
            myHeader.toRegistrationScreen += ToRegistration;
            myHeader.toUserProfileScreen += ToUserProfile;


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
                    //message about succsesfull authorising?
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
            MainScreen.MainScreen screen = new MainScreen.MainScreen();
            mainPanel.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
        }

        public void ToUserProfile()
        {
            mainPanel.Controls.Clear();
            UserProfileScreen.UserProfileScreen screen = new UserProfileScreen.UserProfileScreen();
            mainPanel.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
        }

        
    }
}
