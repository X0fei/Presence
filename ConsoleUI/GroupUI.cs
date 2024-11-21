using Domain.Request;
using Domain.Service;
using Domain.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class GroupUI
    {
        private readonly IGroupUseCase _groupService;
        public GroupUI(IGroupUseCase groupService)
        {
            _groupService = groupService;
        }
        public void AddGroup()
        {
            Console.Write("Введите название группы: ");
            _groupService.AddGroup(new AddGroupRequest { Name = Console.ReadLine() });
        }
        public void AddGroupWithStudents()
        {
            Console.Write("Введите название группы: ");
            AddGroupRequest addGroupRequest = new AddGroupRequest { Name = Console.ReadLine() };
            List<AddStudentRequest> addStudentRequests = new List<AddStudentRequest>()
            {
                new AddStudentRequest{StudentName = "123", StudentSurname = "123"},
                new AddStudentRequest{StudentName = "321", StudentSurname = "321"},
                new AddStudentRequest{StudentName = "222", StudentSurname = "222"},
                new AddStudentRequest{StudentName = "444", StudentSurname = "444"}
            };
            AddGroupWithStudentsRequest addGroupWithStudentsRequest = new AddGroupWithStudentsRequest
            {
                AddGroupRequest = addGroupRequest,
                AddStudentRequests = addStudentRequests
            };
            _groupService.AddGroupWithStudents(addGroupWithStudentsRequest);
        }
    }
}
