using SchoolManagment.Model;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.DTOS
{
    public class TeacherPostDto
    {
        
        [Required]
        [MaxLength(100)]
        public string TeacherName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string TeacherEmail { get; set; }
        public string ?TeacherPhone  { get; set; }
        public List<StudentDto> students { get; set; }
    }
     public class TeacherPostDtoForStudent
    {
        [Required]
        [MaxLength(100)]
        public string TeacherName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string TeacherEmail { get; set; }
        public string ?TeacherPhone  { get; set; }
    }
    public class TeacherPostWithSubjectDto
    {
        [Required]
        [MaxLength(100)]
        public string TeacherName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string TeacherEmail { get; set; }
        public string ?TeacherPhone { get; set; }
        public SubjectDto Subject { get; set; }
    }
      public class TeacherPostWithSubjectDtos
    {
        [Required]
        [MaxLength(100)]
        public string TeacherName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string TeacherEmail { get; set; }
        public string ?TeacherPhone { get; set; }
        public int SubId { get; set; }
    }
}
