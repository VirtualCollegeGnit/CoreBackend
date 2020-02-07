using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Address
{
    public class City
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = "";
        [Required]
        public virtual District? District { get; set; }
    }
}
