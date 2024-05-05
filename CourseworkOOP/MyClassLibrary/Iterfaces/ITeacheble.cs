using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;

namespace CourseworkOOP.Iterfaces
{
    public interface ITeacheble
    {
        bool AddCourse(List<Course> courses, Course newCourse);
        Course? GetCourse(List<Course> courses, uint courseId);
        bool DeleteCourse(List<Course> courses, uint courseId);
    }
}
