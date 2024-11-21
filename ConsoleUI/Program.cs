using ConsoleUI;
using Data;
using Data.Repository;
using Domain.Service;

//Выводит список всех групп и их ID
void ShowAllGrops(IGroupRepository groupRepository)
{
    foreach (var item in groupRepository.GetGroups())
    {
        Console.WriteLine($"{item.ID}\t{item.Name}");
    }
}

RemoteDatabaseContext remoteDatabaseContext = new RemoteDatabaseContext();
SQLGroupRepository groupRepository = new SQLGroupRepository(remoteDatabaseContext);
GroupService groupService = new GroupService(groupRepository);
GroupUI group = new GroupUI(groupService);

group.AddGroupWithStudents();

ShowAllGrops(groupRepository);
