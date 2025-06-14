using SchoolManagment.Model;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.DTOS
{
    public class StudentDto
    {
        public LaptopDto Laptop { get; set; }
        [Required(ErrorMessage = "Student Name is required")]
        [MaxLength(100, ErrorMessage = "Student Name cannot exceed 100 characters")]
        public string StudentName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string StudentEmail { get; set; }
    }
     public class StudentDtos
    {
         [Required(ErrorMessage = "LaptopModel  is required")]
        public string LaptopModel { get; set; }
        [Required(ErrorMessage = "Student Name is required")]
        [MaxLength(100, ErrorMessage = "Student Name cannot exceed 100 characters")]
        public string StudentName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string StudentEmail { get; set; }
    }
    public class StudentPostDto
        {
        public LaptopDto Laptop { get; set; }
        [Required(ErrorMessage = "Student Name is required")]
        [MaxLength(100, ErrorMessage = "Student Name cannot exceed 100 characters")]
        public string StudentName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string StudentEmail { get; set; }
        public TeacherPostDto Teacher { get; set; }
        }
      public class GetStudentDto
        {
        public LaptopDto Laptop { get; set; }
        [Required(ErrorMessage = "Student Name is required")]
        [MaxLength(100, ErrorMessage = "Student Name cannot exceed 100 characters")]
        public string StudentName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string StudentEmail { get; set; }
        public List<TeacherPostWithSubjectDto> Teacher { get; set; }
        }
}
