namespace core.data.Model.Member
{
    public class Course
    {
        public Course(string name, int semester, int capacity)
        {
            Name = name;
            Semester = semester;
            Capacity = capacity;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
        public int Capacity { get; set; }
    }
}
