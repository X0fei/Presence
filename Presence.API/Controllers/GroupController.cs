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
            var result = _groupService.GetGroupsWithStudents()
                .Select(group => new GroupResponse
                {
                    ID = group.ID,
                    Name = group.Name,
                    Students = group.Students.Select(user => new StudentResponse)
                });
            return Ok(new GroupResponse());
        }
    }
}
