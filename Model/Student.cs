namespace SchoolManagment.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public List<Teacher> teachers { get; set; }
        public Laptop Laptop { get; set; }

    }
}
