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
    public class CoursesTests
    {
        [TestMethod]
        public void SetCourseRating()
        {
            Course testCourse = new Course("TestCourse", "Testing");

            testCourse.Rating = 10;

            Assert.IsNotNull(testCourse);
            Assert.AreEqual(testCourse.Rating,10d);
        }
        [TestMethod]
        public void ChangeCourseRating()
        {
            Course testCourse = new Course("TestCourse", "Testing");

            testCourse.Rating = 7;
            testCourse.Rating = 9;

            Assert.IsNotNull(testCourse);
            Assert.AreEqual(testCourse.Rating, 8d);
        }
        [TestMethod]
        public void ChangeCourseRatingWithWrongValue()
        {
            Course testCourse = new Course("TestCourse", "Testing");

            testCourse.Rating = 7;
            Action action = () => testCourse.Rating = 11;

            Assert.ThrowsException<ArgumentException>(action);
            Assert.AreEqual(testCourse.Rating, 7d);
        }
        [TestMethod]
        public void SetCourseCost()
        {
            Course testCourse = new Course("TestCourse", "Testing");

            testCourse.Cost = 199.99M;

            Assert.IsNotNull(testCourse);
            Assert.AreEqual(testCourse.Cost, 199.99M);
        }
        [TestMethod]
        public void SetWrongCourseCost()
        {
            Course testCourse = new Course("TestCourse", "Testing");

            testCourse.Cost = 199.99M;            

            Action action = () => testCourse.Cost = -99.99M;

            Assert.ThrowsException<ArgumentException>(action);
            Assert.IsNotNull(testCourse);
            Assert.AreEqual(testCourse.Cost, 199.99M);
        }
        [TestMethod]
        public void SetCourseAvgAge()
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void ChangeCourseAvgAge()
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void SetCourseAvgAgeWithWrongValue()
        {
            throw new NotImplementedException();
        }
    }
}
