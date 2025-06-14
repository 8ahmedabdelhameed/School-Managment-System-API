namespace SchoolManagment.Model
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
        public string TeacherPhone { get; set; }
        public List<Student> students { get; set; }
        public Subject Subject { get; set; }
    }
}
