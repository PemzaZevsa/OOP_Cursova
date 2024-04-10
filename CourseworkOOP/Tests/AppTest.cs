using System;
using CourseworkOOP.Entities.Users;
using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities;
using Microsoft.VisualBasic.Devices;

namespace Tests
{
    [TestClass]
    public class AppTest
    {    
        [TestMethod]
        public void SeacrchCourseByString()
        {
            CoursesApp coursesApp = new CoursesApp();
            Course course1 = new Course("The Test course","nothing");
            Course course2 = new Course("The Test courseword", "nothing");
            Course course3 = new Course("The word course", "nothing");
            Course course4 = new Course("The WoRD course 2", "nothing");
            coursesApp.Courses.Add(course1);
            coursesApp.Courses.Add(course2);
            coursesApp.Courses.Add(course3);
            coursesApp.Courses.Add(course4);

            List<Course> courses = coursesApp.SearchCourses("word");

            Assert.IsNotNull(courses);
            Assert.IsTrue(courses.Contains(course2));
            Assert.IsTrue(courses.Contains(course3));
            Assert.IsTrue(courses.Contains(course4));
        }
        [TestMethod]
        public void SeacrchCourseByTegs()
        {
            CoursesApp coursesApp = new CoursesApp();
            Course course1 = new Course("The Test course", "nothing","",3,4,0,10,new List<Teg>() { Teg.Cybersecurity, Teg.Development});
            Course course2 = new Course("The Test courseword", "nothing", "", 3, 4,0, 10, new List<Teg>() { Teg.Development });
            Course course3 = new Course("The word course", "nothing", "", 3, 4,0, 10, new List<Teg>() { Teg.Cybersecurity });
            Course course4 = new Course("The WoRD course 2", "nothing", "", 3, 4,0, 10, new List<Teg>() { Teg.Marketing });
            coursesApp.Courses.Add(course1);
            coursesApp.Courses.Add(course2);
            coursesApp.Courses.Add(course3);
            coursesApp.Courses.Add(course4);

            List<Course> courses = coursesApp.SearchCourses(Teg.Cybersecurity, Teg.Development);

            Assert.IsNotNull(courses);
            Assert.IsTrue(courses.Contains(course1));
            Assert.IsTrue(courses.Contains(course2));
            Assert.IsTrue(courses.Contains(course3));
        }
    }
}