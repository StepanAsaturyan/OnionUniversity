using Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionUniversity.Infrastructure.Data
{
    public class GroupRepository : IGroupRepository
    {
        private readonly Task6Context _db;

        public GroupRepository()
        {
            this._db = new Task6Context();
        }

        public IEnumerable<Group> GetAllGroupList()
        {
            return _db.Groups.ToList();
        }       

        public void Create(Group group)
        {
            _db.Groups.Add(group);
        }

        public void Update(Group group)
        {
            _db.Entry(group).State = EntityState.Modified;
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
