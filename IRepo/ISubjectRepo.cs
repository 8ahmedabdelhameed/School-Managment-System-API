using SchoolManagment.DTOS;

namespace SchoolManagment.IRepo
{
    public interface ISubjectRepo
    {
        void PostSubject(Subject_Post_With_Teacher_And_Students_Dto subject);
        Subject_Post_With_Teacher_And_Students_Dto GetSubject(int id);

    }
}
