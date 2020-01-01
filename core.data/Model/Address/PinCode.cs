using System.Collections.Generic;

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
        public City? City { get; set; }
        public ICollection<Person.Person>? People { get; set; }
    }
}
