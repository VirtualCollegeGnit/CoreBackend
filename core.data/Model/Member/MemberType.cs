using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Member
{
    public class MemberType
    {
        public int ID { get; set; }
        [MaxLength(20)]
        public string Name { get; set; } = "";
        [MaxLength(20)]
        public string Description { get; set; } = "";
        public virtual List<Member> Members { get; set; } = new List<Member>();
    }
}
