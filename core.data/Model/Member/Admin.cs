using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Member
{
    public class Admin
    {
        public int Id { get; set; }
        [Required]
        public virtual Member? Member { get; set; }
    }
}
