using Microsoft.AspNetCore.Mvc;
using Domain.UseCase;
using Domain.Service;
using Presence.API.Response;

namespace Presence.API.Controllers
{
    [ApiController]
    [Route("[controller]/api")]
    public class GroupController : ControllerBase
    {
        private readonly IGroupUseCase _groupService;
        public GroupController(IGroupUseCase groupService)
        {
            _groupService = groupService;
        }
        [HttpGet]
        public ActionResult<GroupResponse> GetAllGroups()
        {
            _groupService.
            return Ok(new GroupResponse());
        }
    }
}
