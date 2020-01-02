using core.data.Model.Person;

namespace core.logic.ApiModel.PersonModel
{
    public class AddressModel
    {
        public AddressModel(Person person)
        {
            if (person != null)
            {
                var address = person.Contact?.Address;
                Id = address?.ID;
                AddressLine1 = address?.AddressLine1;
                AddressLine2 = address?.AddressLine2;
                AddressLine3 = address?.AddressLine3;
                PinCode = address?.PinCode?.Pincode;
                District = address?.PinCode?.City?.District?.Name;
                City = address?.PinCode?.City?.Name;
                State = address?.PinCode?.City?.District?.State?.Name;
            }
        }
        public int? Id { get; set; }

        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public int? PinCode { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
    }
}
