using CourseworkOOP.Iterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Courses
{
    public class Lesson 
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Materials { get; set; }
        public static uint counter;
        public Lesson()
        {
        }
        public Lesson(string name, string materials)
        {
            Id = counter++;
            Name = name;
            Materials = materials;
        }
        public Lesson(uint id, string name, string materials)
        {
            Id = id;
            Name = name;
            Materials = materials;
        }
    }
}
