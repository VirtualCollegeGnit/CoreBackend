using core.data;
using core.data.Model.Person;
using core.logic.ApiModel.PersonModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace core.logic.Supervisor
{
    public class PersonSupervisor : SupervisorBase
    {
        public PersonSupervisor(VirtualCollegeContext context) : base(context)
        {
        }

        internal PersonModel GetPersonModel(Person person)
        {
            var p = new PersonModel(person);
            context.Entry(person).Reference(x => x.Contact).Load();

            p.Id = person.ID;
            p.FirstName = person.FirstName;
            p.MiddleName = person.MiddleName;
            p.LastName = person.LastName;
            p.Gender = person.Gender;
            p.DateOfBirth = person.DateOfBirth;
            p.Email = person.Contact?.Email;
            p.Mobile = person.Contact?.Mobile;
            p.supervisor = this;
            p.rawPerson = person;
            p.RowVersion = person.RowVersion;

            return p;
        }
        internal AddressModel GetAddressModel(Person? person)
        {
            var a = new AddressModel();

            if (person != null)
            {
                context.Entry(person).Reference(x => x.Contact).Load();
                if (person.Contact != null)
                {
                    context.Entry(person.Contact).Reference(x => x.Address).Load();
                    var address = person.Contact?.Address;
                    if (address != null)
                    {
                        a.Id = address.ID;
                        a.AddressLine1 = address.AddressLine1;
                        a.AddressLine2 = address.AddressLine2;
                        a.AddressLine3 = address.AddressLine3;
                        a.RowVersion = address.RowVersion;

                        context.Entry(address).Reference(x => x.PinCode).Load();
                        a.PinCode = address.PinCode?.Pincode;

                        if (address.PinCode != null)
                        {
                            context.Entry(address.PinCode).Reference(x => x.City).Load();
                            if (address.PinCode.City != null)
                            {
                                a.City = address.PinCode.City.Name;
                                context.Entry(address.PinCode.City).Reference(x => x.District).Load();
                                if (address.PinCode.City.District != null)
                                {
                                    a.District = address.PinCode.City.District.Name;
                                    context.Entry(address.PinCode.City.District).Reference(x => x.State).Load();
                                    a.State = address.PinCode.City.District.State?.Name;
                                }
                            }
                        }
                    }

                }
            }
            return a;
        }

        internal List<RemarkModel> GetRemarksModel(Person? rawPerson)
        {
            var remarks = new List<RemarkModel>();
            if (rawPerson != null)
            {
                context.Entry(rawPerson).Collection(x => x.Remarks).Load();
                if (rawPerson.Remarks != null)
                {
                    foreach (var rawRemark in rawPerson.Remarks)
                    {
                        context.Entry(rawRemark).Reference(x => x.GivenBy).Load();
                        if (rawRemark.GivenBy != null)
                        {
                            context.Entry(rawRemark.GivenBy).Reference(x => x.Person).Load();
                            if (rawRemark.GivenBy.Person != null)
                            {
                                var remark = new RemarkModel()
                                {
                                    DateTime = rawRemark.DateTime,
                                    Description = rawRemark.Description,
                                    GivenBy = this.GetPersonModel(rawRemark.GivenBy.Person),
                                    Id = rawRemark.ID,
                                    Rating = rawRemark.Rating,
                                    RowVersion = rawRemark.RowVersion
                                };
                                remarks.Add(remark);
                            }

                        }

                    }
                }
            }
            return remarks;
        }

        internal List<RelativeModel> GetRelatives(Person? rawPerson)
        {
            var relatives = new List<RelativeModel>();
            if (rawPerson != null)
            {
                context.Entry(rawPerson).Reference(x => x.Contact).Load();
                if (rawPerson.Contact != null)
                {
                    context.Entry(rawPerson.Contact).Collection(x => x.Relatives).Load();
                    var rawRelatives = rawPerson.Contact.Relatives;
                    if (rawRelatives != null)
                    {
                        foreach (var rawRelative in rawRelatives)
                        {
                            context.Entry(rawRelative).Reference(x => x.Person).Load();
                            if (rawRelative.Person != null)
                            {
                                var relative = new RelativeModel()
                                {
                                    Id = rawRelative.ID,
                                    Person = GetPersonModel(rawRelative.Person),
                                    Relation = rawRelative.Relation
                                };
                                relatives.Add(relative);
                            }
                        }
                    }
                }
            }
            return relatives;
        }

        public async Task<List<PersonModel>> GetPeopleAsync()
        {
            var rawPeople = await context.People.Include(x => x.Contact).ToListAsync();
            var result = new List<PersonModel>();
            rawPeople.ForEach(x => result.Add(GetPersonModel(x)));
            return result;
        }

        public async Task<PersonModel?> GetPersonAsync(int id)
        {
            var rawPerson = await context.People.Include(x => x.Contact).FirstOrDefaultAsync(p => p.ID == id);
            if (rawPerson is null)
            {
                return null;
            }
            return GetPersonModel(rawPerson);
        }

        public async Task CreatePersonAsync(PersonModel personModel)
        {
            var p = new Person()
            {
                FirstName = personModel.FirstName,
                MiddleName = personModel.MiddleName,
                LastName = personModel.LastName,
                DateOfBirth = personModel.DateOfBirth,
                Gender = personModel.Gender
            };
            context.Add(p);
            await context.SaveChangesAsync();
            if (personModel.Mobile != null)
            {
                var c = new Contact()
                {
                    Mobile = personModel.Mobile,
                    Email = personModel.Email
                };
                context.Add(c);
                p.Contact = c;
                await context.SaveChangesAsync();
            }
        }
    }
}
