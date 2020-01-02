using System.Collections.Generic;

namespace core.data.Model.Member
{
    public class Section
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public virtual ICollection<Student>? Students { get; set; }
    }
}
