using Microsoft.EntityFrameworkCore;
using SchoolManagment.DTOS;
using SchoolManagment.Model;

namespace SchoolManagment.IRepo
{
    public class SubjectRepo : ISubjectRepo
    {
        private readonly AppDbContext _context;

        public SubjectRepo(AppDbContext context)
        {
            _context = context;
        }

        public Subject_Post_With_Teacher_And_Students_Dto GetSubject(int id)
        {
            var subject = _context.subjects.Include(x=>x.teachers).ThenInclude(x=>x.students).ThenInclude(x=>x.Laptop).FirstOrDefault(s => s.SubjectId == id);
            if (subject == null)
            {
                return null;
            }
            else
            {
                return new Subject_Post_With_Teacher_And_Students_Dto
                {
                    SubjectName = subject.SubjectName,
                    teachers = subject.teachers == null ? null : subject.teachers.Select(x=> new TeacherPostDto
                    { 
                        TeacherEmail = x.TeacherEmail,
                        TeacherName = x.TeacherName,
                        TeacherPhone = x.TeacherPhone,
                        students = x.students == null ? null : x.students.Select (x=> new StudentDto
                        {
                            StudentEmail = x.StudentEmail,
                            StudentName = x.StudentName,
                            Laptop = x.Laptop==null ? null :  new LaptopDto
                            {
                                LaptopModel = x.Laptop.LaptopModel,
                            }
                        }).ToList()
                    }).ToList() 
                };
            }
        }
        public void PostSubject(Subject_Post_With_Teacher_And_Students_Dto subject)
        {
            Subject subject1 = new Subject
            {
                SubjectName  = subject.SubjectName,
                teachers = subject.teachers.Select(t => new Teacher
                {
                    TeacherName = t.TeacherName,
                    TeacherEmail = t.TeacherEmail,
                    TeacherPhone = t.TeacherPhone,
                    students = t.students.Select(s => new Student
                    {
                        StudentName = s.StudentName,
                        StudentEmail = s.StudentEmail,
                        Laptop = new Laptop
                        {
                            LaptopModel = s.Laptop.LaptopModel
                        }
                    }).ToList()
                }).ToList()
            };
            _context.subjects.Add(subject1);
            _context.SaveChanges(); 
        }
}


}
