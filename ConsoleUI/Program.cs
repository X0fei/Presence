using ConsoleUI;
using Data;
using Data.Repository;
using Domain.Service;
using Domain.UseCase;
using Microsoft.Extensions.DependencyInjection;

//Выводит список всех групп и их ID
void ShowAllGrops(IGroupRepository groupRepository)
{
    foreach (var item in groupRepository.GetGroups())
    {
        Console.WriteLine($"{item.ID}\t{item.Name}");
    }
}

IServiceCollection serviceCollection = new ServiceCollection();

serviceCollection
    .AddDbContext<RemoteDatabaseContext>()
    .AddSingleton<IGroupRepository, SQLGroupRepository>()
    .AddSingleton<IGroupUseCase, GroupService>()
    .AddSingleton<GroupUI>();

var serviceProvider = serviceCollection.BuildServiceProvider();
var groupUI = serviceProvider.GetService<GroupUI>();

groupUI?.AddGroup();
