using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseworkOOP.Entities.Users;
using CourseworkOOP.Entities.Courses;
using System.IO;


namespace CourseworkOOP.Entities
{
    public class CoursesApp
    {
        public User CurrentUser { get; set; }
        public List<User> users;
        public List<Course> courses;
        public CoursesApp() 
        {
        }
        public CoursesApp(string path1, string path2)
        {
            LoadData(path1, path2);
        }
        public bool LoadData(string path1, string path2)
        {
            LoadCourses(path1);
            LoadUsers(path2);
            throw new NotImplementedException();
        }
        public bool LoadCourses(string path)
        {
            throw new NotImplementedException();
        }
        public bool LoadUsers(string path)
        {
            throw new NotImplementedException();
        }
        public List<Course> SearchCourses(string name)
        {
            throw new NotImplementedException();
        }
        public List<Course> SearchCourses(params Teg[] tegs)
        {
            throw new NotImplementedException();
        }
    }
}
