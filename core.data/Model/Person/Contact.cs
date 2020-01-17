using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Person
{
    public class Contact
    {
        public int ID { get; set; }
        public int PersonId { get; set; }
        [Phone]
        [MaxLength(10)]
        public string Mobile { get; set; } = "";
        [EmailAddress]
        [MaxLength(50)]
        public string? Email { get; set; }
        public virtual Address.Address? Address { get; set; }
        public virtual List<Relative>? Relatives { get; set; } = new List<Relative>();
        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}
