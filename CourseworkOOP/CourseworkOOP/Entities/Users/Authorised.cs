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
        private List<Course> courses;

        public List<Course> Courses { get => courses; }

        public event Action paymentError;
        public event Action paymentComplete;

        public Authorised()
        {
            courses = new List<Course>();
            UserType = 2;
        }
        public Authorised(string name, string surname)
        {
            Id = counter++;
            Name = name;
            Surname = surname;
            UserType = 2;
            courses = new List<Course>();
        }
        public Authorised(string name, string surname, List<Course> courses):base (name, surname)
        {
            this.courses = courses;
            UserType = 2;
        }

        public bool BuyCourse(Course course)
        {
            if (course is null) throw new ArgumentNullException(nameof(course));

            decimal money = Payment();
            if (course.Cost > money)
            {
                paymentError?.Invoke();
                return false;
            }
            else
            {
                paymentComplete?.Invoke();
                return true;
            }            
        }

        public decimal Payment()
        {
            Random random = new Random();
            return (decimal)random.Next(0, 1000);
        }
    }
}
