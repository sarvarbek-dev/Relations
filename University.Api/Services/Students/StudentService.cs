using System;
using System.Linq;
using System.Threading.Tasks;
using University.Api.Brokers.Loggings;
using University.Api.Brokers.Storages;
using University.Api.Models.Student;

namespace University.Api.Services.Students
{
    public partial class StudentService : IStudentService
    {
        private IStorageBroker storageBroker;
        private ILoggingBroker loggingBroker;

        public StudentService(IStorageBroker storageBroker, ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }

        public async ValueTask<StudentModel> AddStudentAsync(StudentModel student)
        {

            ValidateStudent(student);

            return await this.storageBroker.InsertStudentAsync(student);
        }
       

        public ValueTask<StudentModel> ModifyStudentAsync(StudentModel student)
        {
            throw new NotImplementedException();
        }

        public ValueTask<StudentModel> RemoveStudentAsync(Guid studentId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StudentModel> RetrieveAllStudent()
        {
            throw new NotImplementedException();
        }

        public ValueTask<StudentModel> RetrieveStudentByIdAsync(Guid studentId)
        {
            throw new NotImplementedException();
        }
    }
}
