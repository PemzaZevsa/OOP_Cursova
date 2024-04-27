using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities
{
    public class CoursesAppSettings
    {
        public uint CourseCounter {  get; set; }
        public uint ModuleCounter { get; set; }
        public uint LessonCounter { get; set; }
        public uint UserCounter { get; set; }
        public CoursesAppSettings() { }
        public CoursesAppSettings(uint courseCounter, uint moduleCounter, uint lessonCounter, uint userCounter) 
        { 
            CourseCounter = courseCounter;
            ModuleCounter = moduleCounter;
            LessonCounter = lessonCounter;
            UserCounter = userCounter;
        }
    }
}
