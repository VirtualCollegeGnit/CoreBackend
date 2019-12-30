namespace core.data.Model.Address
{
    public class District
    {
        public District(string name, State state)
        {
            Name = name;
            State = state;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
    }
}
