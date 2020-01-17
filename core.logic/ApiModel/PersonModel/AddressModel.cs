using core.data.Model.Person;
using core.logic.Supervisor;

namespace core.logic.ApiModel.PersonModel
{
    public class AddressModel
    {
        public int Id { get; set; } = 0;

        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public int? PinCode { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public byte[]? RowVersion { get; internal set; }
    }
}
