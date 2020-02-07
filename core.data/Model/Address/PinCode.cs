using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Address
{
    public class PinCode
    {
        public PinCode(int pincode)
        {
            Pincode = pincode;
        }

        public int ID { get; set; }
        public int Pincode { get; set; }
        [Required]
        public virtual City? City { get; set; }
        public virtual List<Person.Person> People { get; set; } = new List<Person.Person>();
    }
}
