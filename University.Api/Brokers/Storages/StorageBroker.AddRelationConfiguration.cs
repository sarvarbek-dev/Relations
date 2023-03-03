﻿using Microsoft.EntityFrameworkCore;
using University.Api.Models.Groups;
using University.Api.Models.Student;

namespace University.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void AddRelationConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne<Group>(s => s.Group)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.StudentId);                
        }
    }
}
