using Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionUniversity.Infrastructure.Data
{
    public class CourseRepository : ICourseRepository
    {
        private readonly Task6Context _db;

        public CourseRepository()
        {
            this._db = new Task6Context();
        }

        public IEnumerable<Course> GetAllCourseList()
        {
            return _db.Courses.ToList();
        }

        public IEnumerable<Group> GetGroupsByCourseId(int courseId)
        {
            var groups = _db.Groups.Where(group => group.CourseId.Equals(courseId));

            return groups;
        }

        public Course GetCourse(int id)
        {
            return _db.Courses.Find(id);
        }

        public void Create(Course course)
        {
            _db.Courses.Add(course);
        }

        public void Update(Course course)
        {
            _db.Entry(course).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Group group = _db.Groups.Find(id);
            if (group != null)
                _db.Groups.Remove(group);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool _disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Group GetGroup(int id)
        {
            return _db.Groups.Find(id);
        }
    }
}
