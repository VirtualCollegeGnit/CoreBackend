using System.Collections.Generic;

namespace core.data.Model.Address
{
    public class State
    {
        public State(int name)
        {
            Name = name;
        }

        public int ID { get; set; }
        public int Name { get; set; }
        public ICollection<Person.Person>? People { get; set; }
    }
}
