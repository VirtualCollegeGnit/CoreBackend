namespace core.data.Model.Member
{
    public class Admin
    {
        public int Id { get; set; }
        public virtual Member? Member { get; set; }
    }
}
