using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Courses
{
    public class Lesson
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Materials { get; set; }
        public bool IsCompleted { get; set; }
        public static uint counter;

        public Lesson(string name, string description, string materials)
        {
            Id = counter++;
            Name = name;
            Materials = materials;
            Materials = materials;
        }

        public Lesson(uint id, string name, string materials, bool isCompleted)
        {
            Id = id;
            Name = name;
            Materials = materials;
            IsCompleted = isCompleted; 
        }
        public void DoLesson()
        {
            throw new NotImplementedException();    
        }

        public void CompleteLesson()
        {
            throw new NotImplementedException();
        }
    }
}
