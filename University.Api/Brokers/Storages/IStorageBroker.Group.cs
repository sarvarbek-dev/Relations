using System.Linq;
using System;
using System.Threading.Tasks;
using University.Api.Models.Student;
using University.Api.Models.Groups;

namespace University.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Group> InsertGroupAsync(Group group);
        IQueryable<Group> SelectAllGroups();
        ValueTask<Group> SelectGroupByIdAsync(Guid id);
        ValueTask<Group> UpdateGroupAsync(Group group);
        ValueTask<Group> DeleteGroupAsync(Group group); 
    }
}
