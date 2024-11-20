using Data.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IGroupRepository
    {
        public IEnumerable<Groups> GetGroups();
        public bool AddGroup(Groups group);
        public bool AddGroupWithStudents(Groups groups, IEnumerable<Students> students);
    }
}
