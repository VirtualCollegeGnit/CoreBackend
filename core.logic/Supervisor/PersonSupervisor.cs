using core.data;
using core.data.Model.Person;
using core.logic.ApiModel.PersonModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.logic.Supervisor
{
    public class PersonSupervisor : SupervisorBase
    {
        public PersonSupervisor(VirtualCollegeContext context) : base(context)
        {
        }

        public async Task<List<PersonModel>> GetPeopleBasicAsync()
        {
            var rawPeople = await context.People.ToListAsync();
            var result = new List<PersonModel>();
            rawPeople.ForEach(x => result.Add(new PersonModel(x)));
            return result;
        }

        public async Task<PersonModel?> GetPersonAsync(int id)
        {
            var rawPerson = await context.People.FirstOrDefaultAsync(p => p.ID == id);
            if (rawPerson is null)
            {
                return null;
            }
            return new ApiModel.PersonModel.PersonModel(rawPerson);
        }

        public async Task CreatePersonAsync(PersonModel personModel)
        {
            var p = new Person(personModel.FirstName, personModel.MiddleName, personModel.LastName);
            p.DateOfBirth = personModel.DateOfBirth;
            p.Gender = personModel.Gender;
            context.Add(p);
            await context.SaveChangesAsync();
            if (personModel.Mobile != null)
            {
                var c = new Contact(personModel.Mobile, personModel.Email);
                context.Add(c);
                p.Contact = c;
                await context.SaveChangesAsync();
            }
        }
    }
}
