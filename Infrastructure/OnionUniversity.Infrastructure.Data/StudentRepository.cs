using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using OnionUniversity.Infrastructure.Data;

namespace OnionApp.Infrastructure.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly Task6Context db;

        public StudentRepository()
        {
            this.db = new Task6Context();
        }

        public IEnumerable<Student> GetStudentList()
        {
            return db.Students.ToList();
        }

        public Student GetStudent(int id)
        {
            return db.Students.Find(id);
        }

        public void Create(Student student)
        {
            db.Students.Add(student);
        }

        public void Update(Student student)
        {
            db.Entry(student).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Student student = db.Students.Find(id);
            if (student != null)
                db.Students.Remove(student);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
