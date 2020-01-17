using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Address
{
    public class State
    {
        public State(string name)
        {
            Name = name;
        }

        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
