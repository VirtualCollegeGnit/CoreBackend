﻿using core.data;
using core.logic.ApiModel.PersonModel;
using core.logic.Supervisor;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class PeopleController : AuthController
    {
        private readonly PersonSupervisor personSupervisor;
        private readonly VirtualCollegeContext context;

        public PeopleController(VirtualCollegeContext _context)
        {
            personSupervisor = new PersonSupervisor(_context);
            context = _context;
        }

        [HttpGet]
        [EnableQuery()]
        public async Task<ActionResult<IEnumerable<PersonModel>>> GetPeople()
        {
            var read = VerifyUserHasScope("basic_person_read");
            var x = new JsonResult(from c in User.Claims select new { c.Type, c.Value }).ToString();
            return await personSupervisor.GetPeopleAsync();
        }

        [HttpGet]
        [Route("secure")]
        public IActionResult GetUser()
        {
            var sb = new StringBuilder();
            if (User.IsInRole("admin"))
            {
                sb.Append("You are admin\n");
            }
            if (User.IsInRole("superuser"))
            {
                sb.Append("You are superuser\n");
            }
            return Ok(sb.ToString());
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
