using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities.Users;
using System.Linq;
using SeachScreen;
using System.Windows.Forms;

namespace CourseworkOOP
{
    public partial class MainForm : Form
    {
        private CoursesApp coursesApp;

        public MainForm()
        {
            InitializeComponent();

            myHeader.toMainScreen += ToMain;
            myHeader.toRegistrationScreen += ToRegistration;
            myHeader.toUserProfileScreen += ToUserProfile;
            myHeader.toSearchScreen += Search;

            coursesApp = new CoursesApp();
            coursesApp.Load();          
            ToMain();
        }

        public void ToRegistration()
        {
            mainPanel.Controls.Clear();
            RegistrationScreen.RegistrationScreen registration = new RegistrationScreen.RegistrationScreen();

            //���������� �� ������ �����������
            registration.authorisation.authorisationButtonClick += (string login, string password) =>
            {
                // �������� ������������ ����� �� ������ => ��� ���� �������� � �������� label
                var tempUser = coursesApp.Users.Where(u => u.Login == login).Where(u => u.Password == password).Take(1).FirstOrDefault();
                if (tempUser != null)
                {
                    coursesApp.CurrentUser = tempUser;
                    tempUser.updatePassword += (newPassword) =>
                    {
                        tempUser.Password = newPassword;
                        MessageBox.Show("�����, ������ ���� ������!","���� ������");
                    };

                    myHeader.ChangeToAuthorised();
                    //myHeader.ChangePicToUserPic(coursesApp.CurrentUser.ProfilePicturePath);
                    myHeader.ChangeCurrentUserLabel(coursesApp.CurrentUser.Name, coursesApp.CurrentUser.Surname);
                    MessageBox.Show("������ �����������!");
                    ToMain();
                }
                else
                {
                    registration.authorisation.ActivateError();
                }
            };
            
            //���������� �� ������ ���������
            registration.registration.regestrationButtonClick += (string login, string password, string name, string surname,int userType) =>
            {
                //�������� �� � ����� ����� ����
                if (coursesApp.Users.Where(u => u.Login == login).Take(1).FirstOrDefault() is null)
                {
                    //�������� �� userType ����������� ��������� �����
                    switch (userType)
                    {
                        case 1: 
                            Teacher teacher = new Teacher(name,surname,login,password);
                            coursesApp.Users.Add(teacher);
                            coursesApp.CurrentUser = teacher;

                            //TODO delete folder and prof pic
                            //Directory.CreateDirectory($"Data\\Users\\{teacher.Id}");
                            myHeader.ChangeToAuthorised();
                            //myHeader.ChangePicToUserPic(coursesApp.CurrentUser.ProfilePicturePath);
                            myHeader.ChangeCurrentUserLabel(coursesApp.CurrentUser.Name, coursesApp.CurrentUser.Surname);
                            MessageBox.Show("������ ����������!");
                            ToMain();
                            break;
                        case 2: 
                            Student student = new Student(name,surname,login,password);
                            coursesApp.Users.Add(student);
                            coursesApp.CurrentUser = student;

                            //Directory.CreateDirectory($"Data\\Users\\{student.Id}");
                            myHeader.ChangeToAuthorised();
                            //myHeader.ChangePicToUserPic(coursesApp.CurrentUser.ProfilePicturePath);
                            myHeader.ChangeCurrentUserLabel(coursesApp.CurrentUser.Name, coursesApp.CurrentUser.Surname);
                            MessageBox.Show("������ ����������!");
                            ToMain();
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
            MainScreen.MainScreenBlock screen = new MainScreen.MainScreenBlock(coursesApp);

            //������ �������� ����� � ������� �������
            screen.openCourse += (someCourse) =>
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(someCourse);
                someCourse.Dock = DockStyle.Fill;
            };

            //������ ���������� � ������� ����� �� ������� �������
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
            UserProfileScreen.UserProfileScreenBlock screen = new UserProfileScreen.UserProfileScreenBlock(coursesApp);

            //������ ������ � ��������� ������
            screen.logOut += () =>
            {
                coursesApp.CurrentUser = null;
                myHeader.ChangeToUnAuthorised();
                ToMain();
            };

            screen.changeHeaderNameSurname += () =>
            {
                myHeader.ChangeCurrentUserLabel(coursesApp.CurrentUser.Name, coursesApp.CurrentUser.Surname);
            };

            mainPanel.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
        }

        public void Search()
        {
            mainPanel.Controls.Clear();
            var search = new SeacrchScreenBlock(myHeader.searchBar.Text,coursesApp);

            //������ �������� ����� � ������� �������
            search.openCourse += (someCourse) =>
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(someCourse);
                someCourse.Dock = DockStyle.Fill;
            };

            //������ ���������� � ������� ����� �� ������� �������
            search.returnTo += () =>
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(search);
                search.Dock = DockStyle.Fill;
            };


            mainPanel.Controls.Add(search);
            search.Dock = DockStyle.Fill;
        }
    }
}
