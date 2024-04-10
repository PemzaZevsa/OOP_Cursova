using System;
using CourseworkOOP.Entities.Users;
using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities;
using Microsoft.VisualBasic.Devices;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreatingNewAuthorisedUser()
        {
            Course testCourse = new Course("TestCourse", "Testing");
            List<Course> courses = new List<Course>();
            courses.Add(testCourse);

            Student student = new Student("Steve", "Smith", courses);

            Assert.IsNotNull(student); 
            Assert.AreEqual(student.Name, "Steve");
            Assert.AreEqual("TestCourse", student.Courses[0].Name);
        }
        [TestMethod]
        public void AuthorisedBuyCourse()
        {
            Course testCourse = new Course((uint)0,"TestCourse", "Testing","",0,4.5,400,null);

            Student student = new Student("Steve", "Smith");
            Assert.IsFalse(student.BuyCourse(testCourse, 300));
            Assert.IsTrue(student.BuyCourse(testCourse, 400));
            Assert.IsTrue(student.BuyCourse(testCourse, 500));
        }

        [TestMethod]
        public void AdminCreatesCourse()
        {
            Admin admin = new Admin();
            CoursesApp coursesApp = new CoursesApp();
            Course course = new Course("test", "testing");

            admin.AddCourse(coursesApp.Courses, course);

            Assert.IsTrue(coursesApp.Courses.Contains(course));
        }
        [TestMethod]
        public void AdminGetsHisCourse()
        {
            Admin admin = new Admin();
            Course course = new Course("Test", "Course");
            CoursesApp coursesApp = new CoursesApp();
            uint courseId = course.Id;
            admin.AddCourse(coursesApp.Courses, course);

            Course? gotCourse = admin.GetCourse(coursesApp.Courses, courseId);

            Assert.IsTrue(coursesApp.Courses.Contains(course));
            Assert.IsNotNull(gotCourse);
        }
        [TestMethod]
        public void AdminGetsAnotherCourse()
        {
            Admin admin = new Admin("","");
            Teacher teacher = new Teacher("","");
            Course course = new Course("Test", "Course");
            CoursesApp coursesApp = new CoursesApp();
            uint courseId = course.Id;
            teacher.AddCourse(coursesApp.Courses, course);

            Course? gotCourse = admin.GetCourse(coursesApp.Courses, courseId);

            Assert.IsTrue(coursesApp.Courses.Contains(course));
            Assert.IsNotNull(gotCourse);
        }
        [TestMethod]
        public void AdminDeletesCourse()
        {
            Admin admin = new Admin();
            CoursesApp coursesApp = new CoursesApp();
            Course course = new Course("test","testing");
            admin.AddCourse(coursesApp.Courses, course);
            uint id = course.Id;

            admin.DeleteCourse(coursesApp.Courses,id);

            Assert.AreEqual(coursesApp.Courses.Count, 0);
        }
        [TestMethod]
        public void AdminCreateUser()
        {
            Admin admin = new Admin();
            CoursesApp coursesApp = new CoursesApp();
            Student user = new Student("Tom","Tommer");

            admin.AddUser(coursesApp.Users, user);

            Assert.IsTrue(coursesApp.Users.Contains(user));
        }
        [TestMethod]
        public void AdminTryesToDeletesHimself()
        {
            Admin admin = new Admin();
            CoursesApp coursesApp = new CoursesApp();
            coursesApp.Users.Add(admin);
            uint id = admin.Id;

            admin.DeleteUser(coursesApp.Users, id);

            Assert.AreEqual(coursesApp.Users.Count, 1);
        }
        [TestMethod]
        public void AdminDeletesUser()
        {
            Admin admin = new Admin();
            CoursesApp coursesApp = new CoursesApp();
            Student user = new Student("Tom", "Tommer");
            admin.AddUser(coursesApp.Users, user);
            uint id = user.Id;

            admin.DeleteUser(coursesApp.Users, id);

            Assert.AreEqual(coursesApp.Users.Count, 0);
        }
        [TestMethod]
        public void TeacherCreatesCourse()
        {
            Teacher teacher = new Teacher("Bill", "Gates");
            Course course = new Course("Test","Course");
            CoursesApp coursesApp = new CoursesApp();

            teacher.AddCourse(coursesApp.Courses, course);

            Assert.IsTrue(coursesApp.Courses.Any());
            Assert.IsTrue(coursesApp.Courses.Contains(course));
        }
        [TestMethod]
        public void TeacherGetsHisCourse()
        {
            Teacher teacher = new Teacher("Bill", "Gates");
            Course course = new Course("Test", "Course");
            CoursesApp coursesApp = new CoursesApp();
            uint courseId = course.Id;
            teacher.AddCourse(coursesApp.Courses, course);

            Course? gotCourse = teacher.GetCourse(coursesApp.Courses, courseId);

            Assert.IsTrue(coursesApp.Courses.Contains(course));
            Assert.IsNotNull(gotCourse);
        }
        [TestMethod]
        public void TeacherGetsAnotherCourse()
        {
            Teacher teacher = new Teacher("Bill", "Gates");
            Teacher anotherTeacher = new Teacher("Tim", "Cook");
            Course course = new Course("Test", "Course");
            CoursesApp coursesApp = new CoursesApp();
            anotherTeacher.AddCourse(coursesApp.Courses, course);
            uint courseId = course.Id;

            Course? gotCourse = teacher.GetCourse(coursesApp.Courses, courseId);

            Assert.IsTrue(coursesApp.Courses.Contains(course));
            Assert.IsNull(gotCourse);
        }
        [TestMethod]
        public void TeacherDeletesHisCourse()
        {
            Teacher teacher = new Teacher("Bill", "Gates");
            Course course = new Course("Test", "Course");
            CoursesApp coursesApp = new CoursesApp();
            teacher.AddCourse(coursesApp.Courses, course);

            teacher.DeleteCourse(coursesApp.Courses,course.Id);

            Assert.IsTrue(!coursesApp.Courses.Any());
            Assert.IsTrue(!coursesApp.Courses.Contains(course));
        }
        [TestMethod]
        public void TeacherDeletesAnotherCourse()
        {
            Teacher teacher = new Teacher("Bill", "Gates");
            Teacher anotherTeacher = new Teacher("Tim", "Cook");
            Course course = new Course("Test", "Course");
            CoursesApp coursesApp = new CoursesApp();

            anotherTeacher.AddCourse(coursesApp.Courses, course);
            teacher.DeleteCourse(coursesApp.Courses, course.Id);

            Assert.IsTrue(coursesApp.Courses.Any());
            Assert.IsTrue(coursesApp.Courses.Contains(course));
        }


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
            Course course1 = new Course("The Test course", "nothing","",3,4,10,new List<Teg>() { Teg.Cybersecurity, Teg.Development});
            Course course2 = new Course("The Test courseword", "nothing", "", 3, 4, 10, new List<Teg>() { Teg.Development });
            Course course3 = new Course("The word course", "nothing", "", 3, 4, 10, new List<Teg>() { Teg.Cybersecurity });
            Course course4 = new Course("The WoRD course 2", "nothing", "", 3, 4, 10, new List<Teg>() { Teg.Marketing });
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