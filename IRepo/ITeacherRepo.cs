using SchoolManagment.DTOS;

namespace SchoolManagment.IRepo
{
    public interface ITeacherRepo
    {
    
        void PostTeacher(TeacherPostWithSubjectDtos teacher);

    }
}
