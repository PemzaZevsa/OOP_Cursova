using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Iterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Users
{
    public class Authorised : User, IStudyable
    {
        public List<Course> courses;

        public Authorised(string name, string surname, List<Course> courses):base (name, surname)
        {
            this.courses = courses;
        }
        public void OpenMyCourses()
        {
            throw new NotImplementedException();
        }

        public bool BuyCourse(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
