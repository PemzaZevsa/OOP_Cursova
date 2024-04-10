using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Users
{
    public abstract class User: IComparable<User>
    {
        private uint id;
        public uint Id { get; set; }
        private string login;
        public string Login { get; set; }
        private string password;
        public string Password { get; set; }
        private string name;
        public string Name { get; set; }
        private string surname;
        public string Surname { get; set; }
        public static uint counter;
        public event Action<String> UpdatePassword;
        public short UserType { get; set; }

        public User() 
        {
        }
        public User(string name, string surname)
        {
            Id = counter++;
            Name = name;
            Surname = surname;
        }
        public User(uint id, string name, string surname, string login, string password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
        }

        public int CompareTo(User? other)
        {
            if (other == null)
                return 1;

            return string.Compare(Name, other.Name);
        }

    }
}
