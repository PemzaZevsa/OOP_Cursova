using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Iterfaces;
using System.Linq;

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
        public Teacher(string name, string surname,string login, string password)
        {
            Id = counter++;
            Name = name;
            Surname = surname;
            UserType = 1;
            Login = login;
            Password = password;
        }
        public bool AddCourse(List<Course> courses, Course newCourse)
        {
            if (courses is null) return false;
            if (newCourse is null) return false;

            newCourse.AuthorId = Id;
            newCourse.AuthorSurname = Surname;
            newCourse.AuthorName = Name;
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

        public IEnumerable<Course> GetMyCourses(List<Course> courses)
        {
            return courses.Where(x => x.AuthorId == Id).OrderBy(x => x.Id);
        }
    }
}
