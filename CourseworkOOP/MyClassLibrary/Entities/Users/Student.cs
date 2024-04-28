using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Iterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Users
{
    public class Student : User, IStudyable
    {
        private List<Course> courses;
        [JsonIgnore]
        public List<Course> Courses { get => courses; }
        public List<uint> CoursesIds { get; set; }

        static public event Action paymentError;
        static public event Action paymentComplete;

        public Student()
        {
            courses = new List<Course>();
            CoursesIds = new List<uint>();
            UserType = 2;
        }
        public Student(string name, string surname)
        {
            Id = counter++;
            Name = name;
            Surname = surname;
            UserType = 2;
            courses = new List<Course>();
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
            courses = new List<Course>();
            CoursesIds = new List<uint>();
        }
        public Student(string name, string surname, List<Course> courses):base (name, surname)
        {
            this.courses = courses;
            UserType = 2;
            CoursesIds = new List<uint>();
        }
        //public bool BuyCourse(Course course)
        //{
        //    if (course is null) throw new ArgumentNullException(nameof(course));

        //    decimal money = Payment();
        //    if (course.Cost > money)
        //    {
        //        paymentError?.Invoke();
        //        return false;
        //    }
        //    else
        //    {
        //        if (CoursesIds.Contains(course.Id))
        //        {
        //            return false;
        //        }
        //        courses.Add(course);
        //        CoursesIds.Add(course.Id);
        //        paymentComplete?.Invoke();
        //        return true;
        //    }            
        //}
        public bool BuyCourse(Course course, decimal MoneyAmount)
        {
            if (course is null) throw new ArgumentNullException(nameof(course));

            if (course.Cost > MoneyAmount)
            {
                paymentError?.Invoke();
                return false;
            }
            else
            {
                if (CoursesIds.Contains(course.Id))
                {
                    return false;
                }

                course.BoughtCourseAmount++;
                courses.Add(course);
                CoursesIds.Add(course.Id);
                paymentComplete?.Invoke();
                return true;
            }
        }
        public decimal Payment()
        {
            Random random = new Random();
            return (decimal)random.Next(0, 1000);
        }
        //public void LoadListOfCourses(List<Course> AllCourses)
        //{
        //    foreach (var course in AllCourses)
        //    {
        //        if (CoursesIds.Contains( course.Id ))
        //        {
        //            Courses.Add(course);
        //        }
        //    }
        //}
    }
}
