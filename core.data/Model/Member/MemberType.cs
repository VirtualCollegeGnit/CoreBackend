using System.Collections.Generic;

namespace core.data.Model.Member
{
    public class MemberType
    {
        public MemberType(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Member>? Members { get; set; }
    }
}
