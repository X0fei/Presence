using Data.DAO;
using Microsoft.EntityFrameworkCore;
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
            _dbContext.Groups.Add(group);
            return _dbContext.SaveChanges() > 0;
        }

        public bool AddGroupWithStudents(Groups groups, IEnumerable<Students> students)
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            try
            {
                _dbContext.Groups.Add(groups);
                _dbContext.SaveChanges();
                foreach (var item in students)
                {
                    item.Group = groups;
                    _dbContext.Students.Add(item);
                }
                _dbContext.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
            return false;
        }

        public IEnumerable<Groups> GetGroups()
        {
            return _dbContext.Groups.Include(group => group.Students).ToList();
        }
    }
}
