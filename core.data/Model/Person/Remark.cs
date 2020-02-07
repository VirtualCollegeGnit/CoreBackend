using System;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public virtual Member.Member? GivenBy { get; set; }
        [Range(0,10)]
        public int Rating { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}
