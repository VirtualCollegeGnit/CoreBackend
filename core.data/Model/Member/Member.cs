using System;
using System.Collections.Generic;
using System.Text;

namespace core.data.Model.Member
{

    public class Member
    {
        public Member(bool isActive, DateTime dateOfJoining, DateTime? dateOfLeaving )
        {
            this.isActive = isActive;
            DateOfJoining = dateOfJoining;
            DateOfLeaving = dateOfLeaving;
        }

        public int ID { get; set; }
        public virtual Person.Person? Person { get; set; }
        public bool isActive { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime? DateOfLeaving { get; set; }
        public virtual List<Document>? Documents { get; set; }
    }
}
