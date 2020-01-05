using core.data.Model.Address;
using core.data.Model.Person;
using core.logic.Supervisor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace core.logic.ApiModel.PersonModel
{
    public class PersonModel
    {
        internal readonly Person? person;

        public PersonModel() : this(null)
        {

        }

        public PersonModel(Person? person = null)
        {
            FirstName = "";
            this.person = person;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Mobile { get; set; }

        internal PersonSupervisor? supervisor;
        internal Person? rawPerson;

        private AddressModel? address;
        public AddressModel? Address
        {
            get
            {
                if (address == null && person != null)
                {
                    Console.WriteLine("\n\n\nFetching address");
                    address = supervisor?.GetAddressModel(rawPerson);
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
                    relatives = supervisor?.GetRelatives(rawPerson);
                }
                return relatives;
            }
            set { relatives = value; }
        }

        private List<RemarkModel>? remarks;

        public List<RemarkModel>? Remarks
        {
            get
            {
                if (remarks == null)
                {
                    remarks = supervisor?.GetRemarksModel(rawPerson);
                }
                return remarks;
            }
            set { remarks = value; }
        }


        public byte[]? RowVersion { get; internal set; }
    }
}
