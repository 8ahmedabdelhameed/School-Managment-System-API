using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagment.DTOS;
using SchoolManagment.IRepo;

namespace SchoolManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _studentRepo;
        public StudentController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        [HttpGet("GetStudent")]
        public IActionResult GetStudent()
        {
            var students = _studentRepo.GetAllStudents();
            return Ok(students);
        }
        [HttpPost("PostStudent")]
         public IActionResult PostStudent(StudentPostDto studentPostDto)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            _studentRepo.PostStudent(studentPostDto);
            return CreatedAtAction(nameof(PostStudent), studentPostDto);
        }
        [HttpPut("PutStudent/{id}")]
        public IActionResult PutStudent(int id, StudentDtos studentDto)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            _studentRepo.PutStudent(id,studentDto);
            return NoContent();
        }
        [HttpDelete("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            _studentRepo.DeleteStudent(id);
            return NoContent();
        }
    }
}
