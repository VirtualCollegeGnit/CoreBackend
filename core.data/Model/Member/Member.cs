using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace core.data.Model.Member
{

    public class Member
    {
        public int ID { get; set; }
        [Required]
        public virtual Person.Person? Person { get; set; }
        public bool isActive { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime? DateOfLeaving { get; set; }
        public virtual List<Document> Documents { get; set; } = new List<Document>();
        public virtual List<MemberRole> MemberRole { get; set; } = new List<MemberRole>();
    }

    public class MemberRole
    {
        public int MemberId { get; set; }
        public virtual Member Member { get; set; } = new Member();
        public int RoleId { get; set; }
        public virtual Role Role { get; set; } = new Role();
    }
}
