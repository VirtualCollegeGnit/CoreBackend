using System.Collections.Generic;

namespace core.data.Model.Address
{
    public class State
    {
        public State(string name)
        {
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Person.Person>? People { get; set; }
    }
}
