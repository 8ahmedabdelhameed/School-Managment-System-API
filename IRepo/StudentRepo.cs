using Microsoft.EntityFrameworkCore;
using SchoolManagment.DTOS;
using SchoolManagment.Model;

namespace SchoolManagment.IRepo
{
    public class StudentRepo : IStudentRepo
    {
        private readonly AppDbContext _context;

        public StudentRepo(AppDbContext context)
        {
            _context = context;
        }

        public void DeleteStudent(int id)
        {
            var student = _context.students.FirstOrDefault(s => s.StudentId== id);
            if (student != null)
            {
                _context.students.Remove(student);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Student not found");
            }
        }

        public List<GetStudentDto> GetAllStudents()
        {
            return _context.students == null ? null : _context.students.Select(s => new GetStudentDto
                {
                StudentName = s.StudentName,
                StudentEmail = s.StudentEmail,
                Laptop = s.Laptop == null ? null : new LaptopDto
                {
                    LaptopModel = s.Laptop.LaptopModel,
                },
                Teacher = s.teachers == null ? null : s.teachers.Select(x=> new TeacherPostWithSubjectDto
                {
                    TeacherEmail = x.TeacherEmail,
                    TeacherName = x.TeacherName,
                    TeacherPhone = x.TeacherPhone,
                    Subject = x.Subject == null ? null : new SubjectDto
                    {
                        SubjectName = x.Subject.SubjectName
                    }
                }).ToList()
                }).ToList();
        }
        public void PostStudent(StudentPostDto student)
        {
           Student student1 = new Student
           {
               StudentEmail = student.StudentEmail,
               StudentName = student.StudentName,
               Laptop = student.Laptop == null ? null : new Laptop
               {
                   LaptopModel = student.Laptop.LaptopModel,
               },
           };
            _context.students.Add(student1);
            _context.SaveChanges();

        }

        public void PutStudent(int id, StudentDtos s)
        {
            var student = _context.students.Include(x=>x.Laptop).FirstOrDefault(st => st.StudentId == id);
            if (student != null)
            {
                student.StudentName = s.StudentName;
                student.StudentEmail = s.StudentEmail;
                student.Laptop.LaptopModel = s.LaptopModel;
                _context.SaveChanges();
             }
            else
            {
                throw new Exception("Student not found");
            }
        }
    }
}
