using System;
using System.Linq;
using System.Threading.Tasks;
using University.Api.Models.Student;

namespace University.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<StudentModel> InsertStudentAsync(StudentModel student);
        IQueryable<StudentModel> SelectAllStudents();
        ValueTask<StudentModel> SelectStudentByIdAsync(Guid id); 
        ValueTask<StudentModel> UpdateStudentAsync(StudentModel student);
        ValueTask<StudentModel> DeleteStudentAsync(StudentModel student);       
    }
}
