namespace core.data.Model.Address
{
    public class PinCode
    {
        public PinCode(int pincode, City city)
        {
            Pincode = pincode;
            City = city;
        }

        public int ID { get; set; }
        public int Pincode { get; set; }
        public City City { get; set; }
    }
}
