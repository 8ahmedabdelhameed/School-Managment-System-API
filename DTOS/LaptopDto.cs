using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.DTOS
{
    public class LaptopDto
    {
        [Required]
        public string LaptopModel { get; set; }
    }
}
