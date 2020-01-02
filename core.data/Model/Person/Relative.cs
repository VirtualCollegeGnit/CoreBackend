namespace core.data.Model.Person
{
    public enum Relation
    {
        Father=0,
        Mother=1,
        Grandfather=2,
        Grandmother=3,
        Uncle=4,
        Aunt=5,
        Cousin=6,
        Son=7,
        Daughter=8,
        Brother=9,
        Sister=10,
        Friend=11
    }
    public class Relative
    {
        public Relative(Relation relation)
        {
            Relation = relation;
        }

        public int ID { get; set; }
        public virtual Relation Relation { get; set; }
        public virtual Person? Person { get; set; }
    }
}
