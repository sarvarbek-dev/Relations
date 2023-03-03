using System;
using University.Api.Models.Groups;

namespace University.Api.Models.Student
{
    public class StudentModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Age { get; set; }   
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
        
    }
}
