using System.ComponentModel.DataAnnotations;
using core.data.Model.Address;

namespace core.data.Model.Person
{
    public class Contact
    {
        public Contact(Person person, string mobile, string? email, Address.Address address)
        {
            Person = person;
            Mobile = mobile;
            Email = email;
            Address = address;
        }

        public int ID { get; set; }
        public Person Person { get; set; }
        [Phone]
        public string Mobile { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public Address.Address Address { get; set; }
    }
}
