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
        public void CreateCourse()
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse()
        {
            throw new NotImplementedException();
        }
    }
}
