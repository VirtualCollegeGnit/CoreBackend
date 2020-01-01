using System.Collections.Generic;

namespace core.data.Model.Member
{
    public class StudentData
    {
        public int Id { get; set; }
        public Course? Course { get; set; }
        public Section? Section { get; set; }
        public ICollection<SemesterData>? SemestersData { get; set; }
    }
}
