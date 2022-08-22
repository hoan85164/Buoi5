using Buoi5.Dto;
using Buoi5.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Buoi5.Services
{
    public class StudentServices : IStudentServices
    {
        private static int Id = 0;
        private static List<Student> _students = new();
        private readonly ILogger _logger;

        public StudentServices(ILogger<StudentServices> logger)
        {
            _logger = logger;
            _logger.LogInformation("vào đây");
        }

        public void CreateStudent(CreateStudentsDto input)
        {
            _students.Add(new Student
            {
                Id = ++StudentServices.Id,
                Name = input.Name,
                StudentCode = input.Msv,
                DateOfBirth = input.DateofBirth
            });
        }
        public object UpdateStudent(UpdateStudentsDto input)
        {
            var studentfind = _students.Find(x => x.Id == input._id);
            if (studentfind != null)
            {
                studentfind.StudentCode = input.Msv;
                studentfind.DateOfBirth = input.DateofBirth;
                studentfind.Name = input.Name;
            }   
            return studentfind;
        }
        public void DeleteById(int id)
        {
            var studentfind = _students.FirstOrDefault(x => x.Id == id);
            _students.Remove(studentfind);
        }
        public List<Student> GetAll()
        {
            return _students;
        }
        public object GetById(int Id)
        {
            var studentfind = _students.Find(x => x.Id == Id);
            return studentfind;
        }

    }
}
