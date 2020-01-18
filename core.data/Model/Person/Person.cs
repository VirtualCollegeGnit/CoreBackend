using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace core.data.Model.Person
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; } = "";
        [MaxLength(20)]
        public string? MiddleName { get; set; }
        [MaxLength(20)]
        public string? LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [Required]
        public virtual Contact? Contact { get; set; }
        public virtual List<Remark>? Remarks { get; set; } = new List<Remark>();
        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}
