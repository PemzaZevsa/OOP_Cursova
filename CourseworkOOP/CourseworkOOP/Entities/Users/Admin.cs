using CourseworkOOP.Iterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Users
{
    public class Admin : User, ITeacheble, IControlable
    {
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
        public void CreateCourse()
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse()
        {
            throw new NotImplementedException();
        }

        public void WatchStatistics()
        {

        }

        public bool CreateUser()
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser()
        {
            throw new NotImplementedException();
        }
    }
}
