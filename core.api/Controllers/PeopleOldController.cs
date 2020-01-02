//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using core.data;
//using core.data.Model.Person;
//using Microsoft.AspNet.OData;
//using core.logic.ApiModel.Person;

//namespace core.api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class PeopleController : ControllerBase
//    {
//        private readonly VirtualCollegeContext _context;
//        private readonly logic.Supervisor.PersonSupervisor personSupervisor;
//        public PeopleController(VirtualCollegeContext context)
//        {
//            _context = context;
//            personSupervisor = new logic.Supervisor.PersonSupervisor(_context);
//        }

//        // GET: api/People
//        [HttpGet]
//        [EnableQuery()]
//        public async Task<ActionResult<IEnumerable<PersonBasic>>> GetPeople()
//        {
//            return await personSupervisor.GetPeopleBasicAsync();
//            //return await _context.People.ToListAsync();
//            //return await _context.People.Include(s => s.Contact).ThenInclude(c => c.Address).Include(s => s.Contact.Relatives).ToListAsync();
//        }

//        //// GET: api/People/5
//        //[HttpGet("{id}")]
//        //public async Task<ActionResult<logic.ApiModel.Person>> GetPerson(int id)
//        //{
//        //    var person = await personSupervisor.GetPersonBasicAsync(id);

//        //    if (person == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    return person;
//        //}

//        //// PUT: api/People/5
//        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        //// more details see https://aka.ms/RazorPagesCRUD.
//        //[HttpPut("{id}")]
//        //public async Task<IActionResult> PutPerson(int id, Person person)
//        //{
//        //    if (id != person.ID)
//        //    {
//        //        return BadRequest();
//        //    }

//        //    _context.Entry(person).State = EntityState.Modified;

//        //    try
//        //    {
//        //        await _context.SaveChangesAsync();
//        //    }
//        //    catch (DbUpdateConcurrencyException)
//        //    {
//        //        if (!PersonExists(id))
//        //        {
//        //            return NotFound();
//        //        }
//        //        else
//        //        {
//        //            throw;
//        //        }
//        //    }

//        //    return NoContent();
//        //}

//        //// POST: api/People
//        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        //// more details see https://aka.ms/RazorPagesCRUD.
//        //[HttpPost]
//        //public async Task<ActionResult<Person>> PostPerson(core.logic.ApiModel.Person person)
//        //{
//        //    var p = new Person(person.FirstName, person.MiddleName, person.LastName);
//        //    _context.People.Add(p);
//        //    await _context.SaveChangesAsync();

//        //    return CreatedAtAction("GetPerson", new { id = p.ID }, person);
//        //}

//        //// DELETE: api/People/5
//        //[HttpDelete("{id}")]
//        //public async Task<ActionResult<Person>> DeletePerson(int id)
//        //{
//        //    var person = await _context.People.FindAsync(id);
//        //    if (person == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    _context.People.Remove(person);
//        //    await _context.SaveChangesAsync();

//        //    return person;
//        //}

//        //private bool PersonExists(int id)
//        //{
//        //    return _context.People.Any(e => e.ID == id);
//        //}
//    }
//}
