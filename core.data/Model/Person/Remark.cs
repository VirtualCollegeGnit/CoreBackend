using System;

namespace core.data.Model.Person
{
    public class Remark
    {
        public Remark(int rating, string description, DateTime dateTime)
        {
            Rating = rating;
            Description = description;
            DateTime = dateTime;
        }

        public int ID { get; set; }
        public Person Person { get; set; }
        public Member.Member GivenBy { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
    }
}
