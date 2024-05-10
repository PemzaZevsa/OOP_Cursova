using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Iterfaces;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Users
{
    public class Student : User, IStudyable
    {
        public List<uint> CoursesIds { get; set; }

        public Student()
        {
            CoursesIds = new List<uint>();
            UserType = 2;
        }
        public Student(string name, string surname)
        {
            Id = counter++;
            Name = name;
            Surname = surname;
            UserType = 2;
            CoursesIds = new List<uint>();
        }
        public Student(string name, string surname, string login, string password)
        {
            Id = counter++;
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            UserType = 2;
            CoursesIds = new List<uint>();
        }
        public bool BuyCourse(Course course, decimal MoneyAmount)
        {
            if (course is null) throw new ArgumentNullException(nameof(course));

            if (course.Cost > MoneyAmount)
            {
                return false;
            }
            else
            {
                if (CoursesIds.Contains(course.Id))
                {
                    return false;
                }

                course.BoughtCourseAmount++;
                CoursesIds.Add(course.Id);
                return true;
            }
        }
    }
}
