using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using SchoolManagment.DTOS;
using SchoolManagment.Model;

namespace SchoolManagment.IRepo
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly AppDbContext _context;

        public TeacherRepo(AppDbContext context)
        {
            _context = context;
        }

        public void PostTeacher(TeacherPostWithSubjectDtos teacher)
        {
            var subject = _context.subjects.FirstOrDefault(s => s.SubjectId == teacher.SubId);
            if(subject == null)
            {
                throw new Exception("Subject not found");
            }
            else {
            Teacher t = new Teacher
            {
                TeacherEmail = teacher.TeacherEmail,
                TeacherName = teacher.TeacherName,
                TeacherPhone = teacher.TeacherPhone,
                Subject = subject,
            };
            _context.teachers.Add(t);
            _context.SaveChanges();
            }
        }
    }
}
