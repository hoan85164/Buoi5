using Buoi5.Dto;
using Buoi5.Entities;

namespace Buoi5.Services
{
    public interface IStudentServices
    {
        //void CreateStudent(CreateStudentsDto input);
        void CreateStudent(CreateStudentsDto input);
        void DeleteById(int id);
        List<Student> GetAll();
        object GetById(int Id);
        object UpdateStudent(UpdateStudentsDto input);
    }
}
