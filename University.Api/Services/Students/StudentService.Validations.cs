using University.Api.Models.Student;
using University.Api.Models.Students.Exceptions;

namespace University.Api.Services.Students
{
    public partial class StudentService
    {
        private void ValidateStudent(StudentModel student)
        {
            if(student is null)
            {
                throw new NullStudentException();
            }
        }
    }
}
