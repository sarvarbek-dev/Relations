using System;
using System.Collections.Generic;
using University.Api.Models.Student;

namespace University.Api.Models.Groups
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<StudentModel> Students { get; set; }
    }
}
