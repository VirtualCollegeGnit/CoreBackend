using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Member
{
    public class Student
    {
        [Key]
        [Required]
        public virtual Member? Member { get; set; }
        [Required]
        public virtual StudentData? StudentData { get; set; }
    }
}
