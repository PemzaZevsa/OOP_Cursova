using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseworkOOP.Entities.Users;
using CourseworkOOP.Entities.Courses;
using System.IO;
using System.Diagnostics;
using System.Security.Principal;
using System.Text.Json;
using CourseworkOOP.Iterfaces;


namespace CourseworkOOP.Entities
{
    public class CoursesApp : ISaveble
    {
        public event Action LoadError;
        public event Action SaveError;
        public event Action LoadComplete;
        public event Action SaveComplete;
        public event Action<string,string> CurrentUserNameLabel;

        private User currentUser;
        public User CurrentUser 
        {
            get => currentUser;
            set
            {
                if (currentUser is not null && value is null)
                {
                    currentUser = value;
                }
                else if (value is null)
                {
                    throw new ArgumentNullException(nameof(currentUser));
                }
                else
                {
                    currentUser = value;
                    CurrentUserNameLabel?.Invoke(currentUser.Name, currentUser.Surname);
                }                      
            }
        }
        private List<User> users;
        public List<User> Users { get { return users; } }
        private List<Course> courses;
        public List<Course> Courses { get { return courses; } }

        public CoursesApp() 
        {
            users = new List<User>();
            courses = new List<Course>();
        }
        public CoursesApp(Action<string, string> currentUserNameLabel)
        {
            users = new List<User>();
            courses = new List<Course>();
            CurrentUserNameLabel = currentUserNameLabel;
        }
        //public CoursesApp(string coursesPath = @"Data\Courses\CoursesData.txt", string usersPath = @"Data\Users\UsersData.txt")
        //{
        //    users = new List<User>();
        //    courses = new List<Course>();
        //    Load();
        //}
        public bool Save(string path = @"Data")
        {
            string coursesPath = path + @"\Courses\CoursesData.txt";
            string usersPath = path + @"\Users\UsersData.txt";
            try
            {
                SaveCourses();
                SaveUsers();
                SaveSettings();
            }
            catch (Exception e)
            {
                SaveError?.Invoke();
                return false;
            }

            SaveComplete?.Invoke();
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
                        case Student:
                            jsonstring += JsonSerializer.Serialize<Student>((Student)item);
                            break;
                    }
                    jsonstring += "\n";
                }
                File.WriteAllText(usersPath, jsonstring);
            }
            catch (IOException e)
            {
                SaveError?.Invoke();
                return false;
            }
            catch (Exception e)
            {
                SaveError?.Invoke();
                return false;
            }

            SaveComplete?.Invoke();
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
                SaveError?.Invoke();
                return false;
            }
            catch (Exception e)
            {
                SaveError?.Invoke();
                return false;
            }

            SaveComplete?.Invoke();
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
                SaveError?.Invoke();
                return false;
            }
            catch (Exception e)
            {
                SaveError?.Invoke();
                return false;
            }

            SaveComplete?.Invoke() ;
            return true;
        }
        public bool Load(string path = @"Data")
        {
            string coursesPath = path + @"\Courses\CoursesData.txt";
            string usersPath = path + @"\Users\UsersData.txt";
            try
            {
                LoadCourses();
                LoadUsers();
                LoadSettings();
            }
            catch (Exception e)
            {
                LoadError?.Invoke();
                return false;
            }

            LoadComplete?.Invoke();
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
                LoadError?.Invoke();
                return false;
            }
            catch (Exception e)
            {
                LoadError?.Invoke();
                return false;
            }

            LoadComplete?.Invoke();
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
                            user = JsonSerializer.Deserialize<Student>(item);
                            break;
                    }

                    if (user != null) users.Add(user);
                }
            }
            catch (IOException e)
            {
                LoadError?.Invoke();
                return false;
            }
            catch (Exception e)
            {
                LoadError?.Invoke();
                return false;
            }

            LoadComplete?.Invoke();
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
                LoadError?.Invoke();
                return false;
            }
            catch (Exception e)
            {
                LoadError?.Invoke();
                return false;
            }

            LoadComplete?.Invoke();
            return true;
        }
        
        public List<Course> SearchCourses(string stringToSearch)
        {
            return courses.FindAll(x => x.Name.ToUpperInvariant().Contains(stringToSearch.ToUpperInvariant()));
        }
        public List<Course> SearchCourses(params Teg[] tegs)
        {
            List<Course> coursesWithTags = new List<Course>();

            foreach (var course in courses)
            {
                for (int i = 0; i < tegs.Length; i++)
                {
                    if (course.Tegs.Contains(tegs[i]))
                    {
                        coursesWithTags.Add(course);
                    }
                }                
            }

            return coursesWithTags;
        }
    }
}
