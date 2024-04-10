using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities.Users;
using CourseworkOOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class UsersTests
    {
        [TestMethod]
        public void CreatingStudent()
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
        public void StudentBuysCourse()
        {
            Course testCourse = new Course((uint)0, "TestCourse", "Testing", "", 0,0,0, 400, null);
            Student student = new Student("Steve", "Smith");

            Assert.IsTrue(student.BuyCourse(testCourse, 400));
            Assert.IsTrue(student.BuyCourse(testCourse, 500));
        }
        [TestMethod]
        public void StudentBuysCourseWithNotEnoughMoney()
        {
            Course testCourse = new Course((uint)0, "TestCourse", "Testing", "", 0, 0, 0, 400, null);
            Student student = new Student("Steve", "Smith");

            Assert.IsFalse(student.BuyCourse(testCourse, 300));
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
            Admin admin = new Admin("", "");
            Teacher teacher = new Teacher("", "");
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
            Course course = new Course("test", "testing");
            admin.AddCourse(coursesApp.Courses, course);
            uint id = course.Id;

            admin.DeleteCourse(coursesApp.Courses, id);

            Assert.AreEqual(coursesApp.Courses.Count, 0);
        }
        [TestMethod]
        public void AdminCreateUser()
        {
            Admin admin = new Admin();
            CoursesApp coursesApp = new CoursesApp();
            Student user = new Student("Tom", "Tommer");

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
            Course course = new Course("Test", "Course");
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

            teacher.DeleteCourse(coursesApp.Courses, course.Id);

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
    }
}
