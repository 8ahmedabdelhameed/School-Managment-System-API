using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagment.DTOS;
using SchoolManagment.IRepo;

namespace SchoolManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepo _subjectRepo;
        public SubjectController(ISubjectRepo subjectRepo)
        {
            _subjectRepo = subjectRepo;
        }
        [HttpGet]
        public IActionResult GetSubject(int id)
        {  
            var subjects = _subjectRepo.GetSubject(id); 
            return Ok(subjects);
        }
       [HttpPost]
        public IActionResult PostSubject(Subject_Post_With_Teacher_And_Students_Dto sub)
        {  
            if(ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            _subjectRepo.PostSubject(sub); 
            return Created();
        }
    }
}
