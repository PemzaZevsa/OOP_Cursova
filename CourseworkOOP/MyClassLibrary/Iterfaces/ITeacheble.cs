using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;

namespace CourseworkOOP.Iterfaces
{
    public interface ITeacheble
    {
        bool AddCourse(List<Course> courses, Course newCourse);
        IEnumerable<Course> GetMyCourses(List<Course> courses);
        bool DeleteCourse(List<Course> courses, uint courseId);
    }
}
