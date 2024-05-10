using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Iterfaces;
using System;
using System.Collections.Generic;

namespace CourseworkOOP.Entities.Users
{
    public class Admin : User, ITeacheble, IControlable, IStatisticable
    {
        public event Action<CoursesAppSettings> Statistics;
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

        public void WatchStatistics(CoursesAppSettings settings)
        {
            Statistics?.Invoke(settings);
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
            newCourse.AuthorSurname = Surname;
            newCourse.AuthorName = Name;
            courses.Add(newCourse);
            return true;
        }

        public bool DeleteCourse(List<Course> courses, uint courseId)
        {
            if (courses is null) return false;

            courses.RemoveAll(x => x.Id == courseId);
            return true;
        }

        public IEnumerable<Course> GetMyCourses(List<Course> courses)
        {
            return courses.OrderBy(x => x.Id);
        }
    }
}
