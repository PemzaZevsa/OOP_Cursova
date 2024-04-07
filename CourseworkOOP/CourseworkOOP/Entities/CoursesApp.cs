using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseworkOOP.Entities.Users;
using CourseworkOOP.Entities.Courses;
using System.IO;
using System.Diagnostics;
using static System.Windows.Forms.LinkLabel;
using System.Security.Principal;
using System.Text.Json;


namespace CourseworkOOP.Entities
{
    public class CoursesApp
    {
        public delegate void Action<Exception>(Exception ex);
        public event Action<Exception>? LoadingError;
        public event Action<Exception>? SavingError;
        public User CurrentUser { get; set; }
        private List<User> users;
        public List<User> Users { get { return users; } }
        private List<Course> courses;
        public List<Course> Courses { get { return courses; } }

        public CoursesApp() 
        {
            users = new List<User>();
            courses = new List<Course>();
        }
        public CoursesApp(string coursesPath = @"Data\Courses\CoursesData.txt", string usersPath = @"Data\Users\UsersData.txt")
        {
            users = new List<User>();
            courses = new List<Course>();
            LoadData(coursesPath, usersPath);
        }
        public bool SaveData(string coursesPath = @"Data\Courses\CoursesData.txt", string usersPath = @"Data\Users\UsersData.txt")
        {
            try
            {
                SaveCourses();
                SaveUsers();
                SaveSettings();
            }
            catch (Exception e)
            {
                LoadingError?.Invoke(e);
                return false;
            }

            return true;
        }
        public bool SaveUsers(string usersPath = @"Data\Users\UsersData.txt")
        {
            try
            {
                string jsonstring = "";
                foreach (var item in users)
                {
                    switch (item)
                    {
                        case Admin:
                            jsonstring += JsonSerializer.Serialize<Admin>((Admin)item);
                            break;
                        case Teacher:
                            jsonstring += JsonSerializer.Serialize<Teacher>((Teacher)item);
                            break;
                        case Authorised:
                            jsonstring += JsonSerializer.Serialize<Authorised>((Authorised)item);
                            break;
                    }
                    jsonstring += "\n";
                }
                File.WriteAllText(usersPath, jsonstring);
            }
            catch (IOException e)
            {
                SavingError?.Invoke(e);
                return false;
            }
            catch (Exception e)
            {
                SavingError?.Invoke(e);
                return false;
            }

            return true;
        }
        public bool SaveCourses(string coursesPath = @"Data\Courses\CoursesData.txt")
        {
            try
            {
                string jsonstring = "";
                foreach (var item in courses)
                {
                    item.Save();
                    jsonstring += JsonSerializer.Serialize<Course>(item);
                    jsonstring += "\n";
                }
                File.WriteAllText(coursesPath, jsonstring);
            }
            catch (IOException e)
            {
                SavingError?.Invoke(e);
                return false;
            }
            catch (Exception e)
            {
                SavingError?.Invoke(e);
                return false;
            }

            return true;
        }
        public bool SaveSettings(string dataPath = @"Data\Config\Settings.txt")
        {
            try
            {
                string jsonstring = "";
                Settings settings = new Settings(Course.counter, Module.counter, Lesson.counter, User.counter);

                jsonstring += JsonSerializer.Serialize<Settings>(settings);
                jsonstring += "\n";

                File.WriteAllText(dataPath, jsonstring);
            }
            catch (IOException e)
            {
                SavingError?.Invoke(e);
                return false;
            }
            catch (Exception e)
            {
                SavingError?.Invoke(e);
                return false;
            }

            return true;
        }
        public bool LoadData(string coursesPath = @"Data\Courses\CoursesData.txt", string usersPath = @"Data\Users\UsersData.txt")
        {
            try
            {
                LoadCourses();
                LoadUsers();
                LoadSettings();
            }
            catch (Exception e)
            {
                LoadingError?.Invoke(e);
                return false;
            }

            return true;
        }
        public bool LoadCourses(string coursesPath = @"Data\Courses\CoursesData.txt")
        {
            try
            {
                List<string> lines = File.ReadAllLines(coursesPath).ToList();

                foreach (var item in lines)
                {
                    Course? course = JsonSerializer.Deserialize<Course>(item);
                    if (course != null) courses.Add(course);
                }
            }
            catch (IOException e)
            {
                LoadingError?.Invoke(e);
                return false;
            }
            catch (Exception e)
            {
                LoadingError?.Invoke(e);
                return false;
            }
            return true;
        }
        public bool LoadUsers(string usersPath = @"Data\Users\UsersData.txt")
        {
            try
            {
                List<string> lines = File.ReadAllLines(usersPath).ToList();

                foreach (var item in lines)
                {
                    User? user = null;
                    switch (item[^2])
                    {
                        case '0':
                            user = JsonSerializer.Deserialize<Admin>(item);
                            break;
                        case '1':
                            user = JsonSerializer.Deserialize<Teacher>(item);
                            break;
                        case '2':
                            user = JsonSerializer.Deserialize<Authorised>(item);
                            break;
                    }

                    if (user != null) users.Add(user);
                }
            }
            catch (IOException e)
            {
                LoadingError?.Invoke(e);
                return false;
            }
            catch (Exception e)
            {
                LoadingError?.Invoke(e);
                return false;
            }
            return true;
        }
        public bool LoadSettings(string dataPath = @"Data\Config\Settings.txt")
        {
            try
            {
                List<string> lines = File.ReadAllLines(dataPath).ToList();

                Settings settings = JsonSerializer.Deserialize<Settings>(lines[0]);

                Course.counter = settings.CourseCounter;
                Module.counter = settings.ModuleCounter;
                Lesson.counter = settings.LessonCounter;
                User.counter = settings.UserCounter;
            }
            catch (IOException e)
            {
                LoadingError?.Invoke(e);
                return false;
            }
            catch (Exception e)
            {
                LoadingError?.Invoke(e);
                return false;
            }
            return true;
        }
        
        public List<Course> SearchCourses(string stringToSearch)
        {
            return courses.FindAll(x => x.Name.Contains(stringToSearch));
        }
        public List<Course> SearchCourses(params Teg[] tegs)
        {
            List<Course> coursesWithTags = new List<Course>();
            foreach (var course in courses)
            {
                if (tegs.All(teg => course.Tegs.Contains(teg)))
                {
                    coursesWithTags.Add(course);
                }
            }

            return coursesWithTags;
        }
    }
}
