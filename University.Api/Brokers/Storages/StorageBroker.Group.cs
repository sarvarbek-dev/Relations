using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using University.Api.Models.Student;

namespace University.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Group> Groups { get; set; }

        public async ValueTask<Group> InsertGroupAsync(Group group) =>
            await InsertAsync(group);

        public IQueryable<Group> SelectAllGroups() =>
            SelectAll<Group>();

        public async ValueTask<Group> (Guid id) =>
            await SelectAsync<Group>(id);

        public async ValueTask<Group> UpdateGroupAsync(Group group) =>
            await UpdateAsync(group);

        public async ValueTask<Group> DeleteGroupAsync(Group group) =>
            await DeleteAsync<Group>(group);
    }
}
