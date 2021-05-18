using OnionUniversity.Infrastructure.Data;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IStudentRepository : IDisposable
    {
        IEnumerable<Student> GetAllStudentList();
        IEnumerable<Student> GetStudentListByName(string namePart);
        IEnumerable<Student> GetStudentsByGroup(int groupId);


        Student GetStudent(int id);
        void Create(Student item);
        void Update(Student item);
        void Delete(int id);
        void Save();
    }
}
