using Data;
using Data.Repository;
using Domain.Service;
using Domain.UseCase;
using Presence.API.Controllers;

namespace Presence.API.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddCommonServices(this IServiceCollection services)
        {
            services
                .AddDbContext<RemoteDatabaseContext>()
                .AddScoped<IGroupRepository, SQLGroupRepository>()
                .AddScoped<IGroupUseCase, GroupService>()
                .AddScoped<GroupController>();
        }
    }
}
