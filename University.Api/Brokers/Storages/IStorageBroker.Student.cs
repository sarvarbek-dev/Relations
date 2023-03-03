using System;
using System.Linq;
using System.Threading.Tasks;
using University.Api.Models.Student;

namespace University.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Student> InsertStudentAsync(Student student);
        IQueryable<Student> SelectAllStudents();
        ValueTask<Student> SelectStudentByIdAsync(Guid id); 
        ValueTask<Student> UpdateStudentAsync(Student student);
        ValueTask<Student> DeleteStudentAsync(Student student);       
    }
}
