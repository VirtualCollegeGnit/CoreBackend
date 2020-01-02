using core.data.Model.Address;
using core.data.Model.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.logic.ApiModel.PersonModel
{
    public class PersonModel
    {
        internal readonly Person? rawPerson;

        public PersonModel(Person rawPerson)
        {
            Id = rawPerson.ID;
            FirstName = rawPerson.FirstName;
            MiddleName = rawPerson.MiddleName;
            LastName = rawPerson.LastName;
            Gender = rawPerson.Gender;
            DateOfBirth = rawPerson.DateOfBirth;
            Email = rawPerson.Contact?.Email;
            Mobile = rawPerson.Contact?.Mobile;
            this.rawPerson = rawPerson;
        }

        public PersonModel()
        {
            FirstName = "";
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }

        private AddressModel? address;
        public AddressModel? Address
        {
            get
            {
                if (address != null)
                {
                    return address;
                }
                if (rawPerson != null)
                {
                    Console.WriteLine("\n\n\nFetching address");
                    address = new AddressModel(rawPerson);
                }
                return address;
            }
            set
            {
                address = value;
            }
        }

        private List<RelativeModel>? relatives;
        public List<RelativeModel>? Relatives
        {
            get
            {
                if (relatives == null)
                {
                    var rawRelatives = rawPerson?.Contact?.Relatives.ToList();
                    relatives = new List<RelativeModel>();
                    rawRelatives?.ForEach(x =>
                    {
                        if (x.Person != null)
                        {
                            relatives.Add(new RelativeModel(x));
                        }
                    });
                }
                return relatives;
            }
            set { relatives = value; }
        }

    }

    public class RelativeModel
    {
        public RelativeModel(Relative x)
        {
            if (x.Person == null)
            {
                throw new NullReferenceException("Relative person cannot be null");
            }
            Relation = x.Relation;
            Person = new PersonModel(x.Person);
        }

        public int Id { get; set; }
        public Relation Relation { get; set; }
        public PersonModel Person { get; set; }
    }
}
