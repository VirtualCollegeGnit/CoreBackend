using core.data;
using core.logic.ApiModel.PersonModel;
using core.logic.Supervisor;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly PersonSupervisor personSupervisor;

        public PeopleController(VirtualCollegeContext _context)
        {
            personSupervisor = new PersonSupervisor(_context);
        }

        [HttpGet]
        [Authorize(Roles = "administrator")]
        [EnableQuery()]
        public async Task<ActionResult<IEnumerable<PersonModel>>> GetPeople()
        {
            return await personSupervisor.GetPeopleBasicAsync();
        }

        [HttpGet]
        [Authorize]
        [Route("secure")]
        public IActionResult GetUser()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }

        [HttpPost]
        [Authorize(Roles = "administrator")]

        public async Task<IActionResult> CreatePersonAsync(PersonModel personModel)
        {
            await personSupervisor.CreatePersonAsync(personModel);
            return Ok();
        }

    }
}
