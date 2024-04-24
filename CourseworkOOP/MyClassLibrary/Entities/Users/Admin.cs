using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Iterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Users
{
    public class Admin : User, ITeacheble, IControlable, IStatisticable
    {
        public event Action<Settings> Statistics;
        public Admin()
        {
            UserType = 0;
        }
        public Admin(string name, string surname) 
        {
            Id = counter++;
            Name = name;
            Surname = surname;
            UserType = 0;
        }        

        public void WatchStatistics(Settings settings)
        {
            Statistics?.Invoke(settings);
        }

        public bool AddUser(List<User> users, User newUser)
        {
            if (newUser is null) return false;
            if (newUser == this) return false;
            if (users is null) return false;
            

            users.Add(newUser);
            return true;
        }

        public bool DeleteUser(List<User> users, uint id)
        {
            if (id == this.Id) return false;
            if (users is null) return false;

            users.RemoveAll(x => x.Id == id);
            return true;
        }

        public bool AddCourse(List<Course> courses, Course newCourse)
        {
            if (courses is null) return false;
            if (newCourse is null) return false;

            newCourse.AuthorId = 0;
            courses.Add(newCourse);
            return true;
        }

        public bool DeleteCourse(List<Course> courses, uint courseId)
        {
            if (courses is null) return false;

            courses.RemoveAll(x => x.Id == courseId);
            return true;
        }

        public Course? GetCourse(List<Course> courses, uint courseId)
        {
            return courses.Find(x => x.Id == courseId);
        }
    }
}
