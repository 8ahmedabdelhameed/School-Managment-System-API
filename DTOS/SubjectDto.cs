using SchoolManagment.Model;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.DTOS
{
    public class Subject_Post_With_Teacher_And_Students_Dto
    {
       [Required]
       [MaxLength(50)]
        public string SubjectName { get; set; }
        public List<TeacherPostDto> teachers { get; set; }
    }
    public class SubjectDto
    {  [Required]
     [MaxLength(50)]
       public string SubjectName { get; set; }
    }
}
