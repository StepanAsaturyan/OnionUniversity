using OnionUniversity.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICourseRepository : IDisposable
    {
        IEnumerable<Course> GetAllCourseList();
        IEnumerable<Group> GetGroupsByCourseId(int courseId);

        Course GetCourse(int id);
        void Create(Course item);
        void Update(Course item);
        void Delete(int id);
        void Save();
    }
}
