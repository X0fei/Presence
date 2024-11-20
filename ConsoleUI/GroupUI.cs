using Domain.Request;
using Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class GroupUI
    {
        private readonly GroupService _groupService;
        public GroupUI(GroupService groupService)
        {
            _groupService = groupService;
        }
        public void AddGroup()
        {
            Console.Write("Введите название группы: ");
            _groupService.AddGroup(new AddGroupRequest { Name = Console.ReadLine() });
        }
    }
}
