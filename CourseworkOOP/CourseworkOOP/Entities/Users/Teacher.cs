using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Iterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseworkOOP.Entities.Users
{
    public class Teacher : User, ITeacheble
    {
        public Teacher() 
        {
            UserType = 1;
        }
        public Teacher(string name, string surname)
        {
            Id = counter++;
            Name = name;
            Surname = surname;
            UserType = 1;
        }
        public bool AddCourse(List<Course> courses, Course newCourse)
        {
            if (courses is null) return false;
            if (newCourse is null) return false;

            newCourse.AuthorId = Id;
            courses.Add(newCourse);
            return true;
        }

        public bool DeleteCourse(List<Course> courses, uint courseId)
        {
            if (courses is null) return false;
            Course? cToDelete = courses.Find(x => x.Id == courseId);
            if (cToDelete is null) return false;
            if (this.Id != cToDelete.AuthorId) return false;

            courses.RemoveAll(x => x.Id == courseId);
            return true;
        }

        public Course? GetCourse(List<Course> courses, uint courseId)
        {
            return courses.Find(x => x.Id == courseId).AuthorId == Id ? courses.Find(x => x.Id == courseId) : null;
        }
    }
}
