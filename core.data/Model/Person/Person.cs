using System;
using System.Collections.Generic;
using System.Text;

namespace core.data.Model.Person
{
    public class Person
    {
        public Person(string firstName, string middleName, string? lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string? LastName { get; set; }
    }
}
