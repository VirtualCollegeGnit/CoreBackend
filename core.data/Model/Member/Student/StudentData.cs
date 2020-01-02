using System.Collections.Generic;

namespace core.data.Model.Member
{
    public class StudentData
    {
        public int Id { get; set; }
        public virtual Course? Course { get; set; }
        public virtual Section? Section { get; set; }
        public virtual ICollection<SemesterData>? SemestersData { get; set; }
    }
}
