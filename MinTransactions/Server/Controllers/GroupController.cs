using Microsoft.AspNetCore.Mvc;


namespace MinTransactions.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        public static List<Group> groups = new()
        {
            new Group
            {
                Id = "1",
                Name = "White Villa"
            },
            new Group
            {
                Id="2",
                Name = "Black Mansion"
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Group>>> GetGroups()
        {
            return Ok(groups);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Group>> GetSingleGroup(String Id)
        {
            var group = groups.FirstOrDefault(h => h.Id.Equals(Id));
            if (group == null)
            {
                return NotFound("Group Not Found!");
            }
            return Ok(group);
        }
    }
}
