using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Person
{
    public class Relative
    {
        //public Relative(Relation relation)
        //{
        //    Relation = relation;
        //}

        public int ID { get; set; }
        public virtual Relation Relation { get; set; }
        [Required]
        public virtual Person? Person { get; set; }
        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}
