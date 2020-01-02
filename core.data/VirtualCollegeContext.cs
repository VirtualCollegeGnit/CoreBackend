using core.data.Model;
using core.data.Model.Member;
using core.data.Model.Person;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.data
{
    public class VirtualCollegeContext : DbContext
    {
        public VirtualCollegeContext(DbContextOptions<VirtualCollegeContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Member>? Members { get; set; }
        public DbSet<Person>? People { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Contact>? Contacts { get; set; }

    }
}
