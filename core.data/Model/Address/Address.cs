using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Address
{
    public class Address
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string AddressLine1 { get; set; } = "";
        [MaxLength(100)]
        public string? AddressLine2 { get; set; }
        [MaxLength(100)]
        public string? AddressLine3 { get; set; }
        [Required]
        public virtual PinCode? PinCode { get; set; }
        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}
