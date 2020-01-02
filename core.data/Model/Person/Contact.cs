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
        public virtual Person? Person { get; set; }
        [Phone]
        public string Mobile { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public virtual Address.Address? Address { get; set; }
        public virtual ICollection<Relative>? Relatives { get; set; }
    }
}
