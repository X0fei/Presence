using Data.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class SQLGroupRepository : IGroupRepository
    {
        private readonly RemoteDatabaseContext _dbContext;
        public SQLGroupRepository(RemoteDatabaseContext remoteDatabaseContext)
        {
            _dbContext = remoteDatabaseContext;
        }
        public bool AddGroup(Groups group)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Groups> GetGroups()
        {
            return _dbContext.Groups.ToList();
        }
    }
}
