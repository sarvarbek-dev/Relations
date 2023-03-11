using System;
using System.Linq;
using System.Threading.Tasks;
using University.Api.Models.Student;

namespace University.Api.Services.Students
{
    public interface IStudentService
    {
        ValueTask<StudentModel> AddStudentAsync(StudentModel student);
        IQueryable<StudentModel> RetrieveAllStudent();
        ValueTask<StudentModel> RetrieveStudentByIdAsync(Guid studentId);
        ValueTask<StudentModel> ModifyStudentAsync(StudentModel student);
        ValueTask<StudentModel> RemoveStudentAsync(Guid studentId);
    }
}
