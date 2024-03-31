using CourseworkOOP.Iterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Courses
{
    public class Course
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ITeacheble Author { get; set; }
        //public string AuthorId { get; set; } = Guid.NewGuid().ToString();
        public decimal Cost { get; set; }
        public List<Teg> tegs;
        public List<Module> modules;
        public static uint counter;

        public Course()
        {
        }
        public Course(string name, string description)
        {
            Id = counter++;
            Name = name;
            Description = description;
        }
        public Course(uint id, string name, string description, ITeacheble author,decimal cost, List<Teg> tegs, List<Module> modules)
        {
            Id = id;
            Name = name;
            Description = description;
            Author = author;
            Cost = cost;
            this.tegs = tegs;
            this.modules = modules;
        }
    }
}
