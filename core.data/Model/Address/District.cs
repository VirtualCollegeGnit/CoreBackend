using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Address
{
    public class District
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = "";
        [Required]
        public virtual State? State { get; set; }
    }
}
