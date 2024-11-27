using Data.DAO;
using Data.Repository;
using Domain.Entity;
using Domain.Request;
using Domain.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class GroupService : IGroupUseCase
    {
        private readonly IGroupRepository _groupRepository;
        public GroupService(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public void AddGroup(AddGroupRequest addGroupRequest)
        {
            _groupRepository.AddGroup(new Groups { Name = addGroupRequest.Name });
        }

        public void AddGroupWithStudents(AddGroupWithStudentsRequest addGroupWithStudents)
        {
            Groups groups = new Groups { Name = addGroupWithStudents.AddGroupRequest.Name };
            List<Students> students = addGroupWithStudents
                .AddStudentRequests
                .Select(it => new Students { Name = it.StudentName, Surname = it.StudentSurname })
                .ToList();
            _groupRepository.AddGroupWithStudents(groups, students);
        }

        public IEnumerable<GroupEntity> GetGroupsWithStudents()
        {
            return _groupRepository.GetGroups().Select(
                group => new GroupEntity
                {
                    ID = group.ID,
                    Name = group.Name,
                    Students = group.Students.Select(
                        student => new StudentEntity
                        {
                            Guid = student.Guid,
                            Name = student.Name,
                            Group = new GroupEntity 
                            { 
                                ID = group.ID, 
                                Name = group.Name 
                            }
                        }).ToList()
                }).ToList();
        }
    }
}
