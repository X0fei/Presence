using Microsoft.AspNetCore.Mvc;
using Domain.UseCase;
using Domain.Service;

namespace Presence.API.Controllers
{
    [ApiController]
    [Route("[controller]/api")]
    public class GroupController : ControllerBase
    {
        private readonly IGroupUseCase _groupService;
        public GroupController 
    }
}
