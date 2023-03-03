using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using University.Api.Models.Student;

namespace University.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<StudentModel> Students { get; set; }

        public async ValueTask<StudentModel> InsertStudentAsync(StudentModel student) =>
            await InsertAsync(student);

        public IQueryable<StudentModel> SelectAllStudents() =>
            SelectAll<StudentModel>();

        public async ValueTask<StudentModel> SelectStudentByIdAsync(Guid id) =>
            await SelectAsync<StudentModel>(id);

        public async ValueTask<StudentModel> UpdateStudentAsync(StudentModel student) =>
            await UpdateAsync(student);

        public async ValueTask<StudentModel> DeleteStudentAsync(StudentModel student) =>
            await DeleteAsync<StudentModel>(student);
    }
}
