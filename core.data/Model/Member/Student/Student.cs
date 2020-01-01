namespace core.data.Model.Member
{
    public class Student
    {
        public int Id { get; set; }
        public Member? Member { get; set; }
        public StudentData? StudentData { get; set; }
    }
}
