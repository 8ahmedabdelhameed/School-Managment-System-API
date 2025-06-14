namespace SchoolManagment.Model
{
    public class Laptop
    {
        public int LaptopId { get; set; }
        public string LaptopModel { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
