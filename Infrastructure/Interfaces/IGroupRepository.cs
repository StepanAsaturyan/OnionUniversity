using OnionUniversity.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IGroupRepository : IDisposable
    {
        IEnumerable<Group> GetAllGroupList();

        Group GetGroup(int id);
        void Create(Group item);
        void Update(Group item);
        void Delete(int id);
        void Save();
    }
}
