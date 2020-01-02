namespace core.data.Model.Address
{
    public class Address
    {
        public Address(string addressLine1, string? addressLine2, string? addressLine3)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
        }

        public int ID { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public virtual PinCode? PinCode { get; set; }
    }
}
