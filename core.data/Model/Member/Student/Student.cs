namespace core.data.Model.Member
{
    public class Student
    {
        public int Id { get; set; }
        public virtual Member? Member { get; set; }
        public virtual StudentData? StudentData { get; set; }
    }
}
