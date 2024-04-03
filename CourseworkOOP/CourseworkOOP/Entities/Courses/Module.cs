using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Courses
{
    public class Module
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public string Author { get; set; }
        public bool IsCompleted { get; set; }
        public int LessonsComplete { get; set; }
        public List<Lesson> lessons;
        public static uint counter;

        public Module(string name, string description)
        {
            Id = counter++;
            Name = name;
            Description = description;
        }

        public Module(uint id, string name, string description, bool isCompleted, int lessonsComplete, List<Lesson> lessons)
        {
            Id = id;
            Name = name;
            Description = description;
            IsCompleted = isCompleted;
            LessonsComplete = lessonsComplete;
            this.lessons = lessons;
        }
        public Lesson StartNLesson(int lesson)
        {
            throw new NotImplementedException();
        }
        public void CompleteModule()
        {
            throw new NotImplementedException();
        }
    }
}
