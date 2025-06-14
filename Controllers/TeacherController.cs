using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagment.DTOS;
using SchoolManagment.IRepo;

namespace SchoolManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepo _teacherRepo;

        public TeacherController(ITeacherRepo teacherRepo)
        {
            _teacherRepo = teacherRepo;
        }
        [HttpPost]
        public IActionResult PostTeacher(TeacherPostWithSubjectDtos teacher)
        { 
        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }  
        _teacherRepo.PostTeacher(teacher);
        return CreatedAtAction(nameof(PostTeacher), teacher);
        }

    }
}
