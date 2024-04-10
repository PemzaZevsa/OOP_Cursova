using HeaderSpace;
using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Metrics;
using CourseworkOOP.Entities.Users;

namespace CourseworkOOP
{
    public partial class Form1 : Form
    {
        public CoursesApp coursesApp;
        public enum splitContainerState
        {
            MainState = 0,
            SideBarExtendState = 1
        }
        public splitContainerState splitState;
        public Form1()
        {
            InitializeComponent();
            header1.toMainScreen += ToMainScreen;
            header1.toUserProfile += ToUserProfileScreen;
            splitState =  splitContainerState.MainState;

            coursesApp = new CoursesApp();

            Course testCourse = new Course("TestCourse", "Testing");

            //testCourse.Tegs.Add(Teg.Development); 
            //testCourse.Tegs.Add(Teg.DataScience);

            //Module module1 = new Module("Module1", "testing");
            //Lesson lesson1 = new Lesson("Lesson1","desc",@"Data\Courses\TestCourse\Module1");
            //lesson1.SaveMaterials("The topic about something.1 There should be a lot of text.");
            //module1.Lessons.Add(lesson1);

            //Module module2 = new Module("Module2", "testing");
            //Lesson lesson2 = new Lesson("Lesson1", "desc", @"Data\Courses\TestCourse\Module2");
            //lesson2.SaveMaterials("The topic about something.2 There should be a lot of text.");
            //module2.Lessons.Add(lesson2);

            //testCourse.Modules.Add(module1); 
            //testCourse.Modules.Add(module2);

            //coursesApp.Courses.Add(testCourse);


            //coursesApp.LoadingError += 
            //    {
            //    ShowDialog(ex)
            //    };

            coursesApp.Load();

            foreach (var item in coursesApp.Courses)
            {
                Debug.WriteLine(item.Name);
                item.Load();
                foreach (var item2 in item.Tegs)
                {
                    Debug.WriteLine(item2);
                }
                foreach (var item2 in item.Modules)
                {
                    Debug.WriteLine(item2.Name);
                }
            }

            coursesApp.Users.Add(new Teacher("Tim", "Kenedy"));
            Student student = new Student("Steve", "Smith") ;
            student.Courses.Add(testCourse);
            coursesApp.Users.Add(student); 

            Debug.WriteLine(Course.counter);
            Debug.WriteLine(Module.counter);
            Debug.WriteLine(Lesson.counter);
            Debug.WriteLine(Teacher.counter);
            Debug.WriteLine(Admin.counter);
            Debug.WriteLine(Student.counter);
            Debug.WriteLine(UnAuthorised.counter);

            coursesApp.Save();            
        }

        public void ToMainScreen()
        {
            mainPanel.Controls.Clear();
            MainScreen.MainScreen screen = new MainScreen.MainScreen();
            mainPanel.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
        }

        public void ToUserProfileScreen()
        {
            mainPanel.Controls.Clear();
            UserProfileScreen.UserProfileScreen screen = new UserProfileScreen.UserProfileScreen();
            mainPanel.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
        }

        //public void Test2()
        //{
        //    panel1.Controls.Clear();
        //    Button button = new Button();
        //    panel1.Controls.Add(button);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
