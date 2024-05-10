using CourseworkOOP.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP.Iterfaces
{
    public interface IStudyable
    {
        public List<uint> CoursesIds { get; set; }
        bool BuyCourse(Course course, decimal cost);
    }
}
