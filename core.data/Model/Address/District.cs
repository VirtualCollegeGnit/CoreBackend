namespace core.data.Model.Address
{
    public class District
    {
        public District(string name)
        {
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual State? State { get; set; }
    }
}
