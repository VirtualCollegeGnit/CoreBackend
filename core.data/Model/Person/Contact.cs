using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Person
{
    public class Contact
    {
        public Contact(string mobile, string? email)
        {
            Mobile = mobile;
            Email = email;
        }

        public int ID { get; set; }
        public int PersonId { get; set; }
        public Person? Person { get; set; }
        [Phone]
        public string Mobile { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public Address.Address? Address { get; set; }
        public ICollection<Relative>? Relatives { get; set; }
    }
}
