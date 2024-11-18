using Data;
using Data.Repository;

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

ShowAllGrops(groupRepository);