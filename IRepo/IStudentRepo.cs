using SchoolManagment.DTOS;

namespace SchoolManagment.IRepo
{
    public interface IStudentRepo 
    {
        void PostStudent(StudentPostDto student);
        List<GetStudentDto> GetAllStudents();
        void PutStudent(int id, StudentDtos s);
        void DeleteStudent(int id);
    }
}
