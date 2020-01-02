using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace core.data.Model.Person
{
    public class Person
    {
        public Person(string firstName, string? middleName, string? lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime? DateOfBirth{ get; set; }
        public virtual Contact? Contact { get; set; }
        public virtual ICollection<Remark>? Remarks { get; set; }
        public int? MemberId { get; set; }
        public virtual Member.Member? Member { get; set; }
    }
    public enum Gender
    {
        Male,Female,Transgender
    }
}
