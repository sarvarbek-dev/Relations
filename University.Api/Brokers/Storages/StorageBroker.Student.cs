using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using University.Api.Models.Student;

namespace University.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Student> Students { get; set; }

        public async ValueTask<Student> InsertStudentAsync(Student student) =>
            await InsertAsync(student);

        public IQueryable<Student> SelectAllStudents() =>
            SelectAll<Student>();

        public async ValueTask<Student> SelectStudentByIdAsync(Guid id) =>
            await SelectAsync<Student>(id);

        public async ValueTask<Student> UpdateStudentAsync(Student student) =>
            await UpdateAsync(student);

        public async ValueTask<Student> DeleteStudentAsync(Student student) =>
            await DeleteAsync<Student>(student);
    }
}
