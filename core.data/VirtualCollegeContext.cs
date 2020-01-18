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


        public DbSet<Member>? Members { get; set; }
        public DbSet<Person>? People { get; set; }
        //public DbSet<Student>? Students { get; set; }
        public DbSet<Contact>? Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlServer("Data Source=localhost;Initial Catalog=VirtualCollege;Persist Security Info=True;User ID=sa;Password=12.LmnbA");
            var x = (Environment.GetEnvironmentVariable("HEROKU_POSTGRES"));
            Console.WriteLine(x);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberRole>()
                        .HasKey(x => new { x.MemberId, x.RoleId });
            modelBuilder.Entity<MemberRole>()
                        .HasOne(x => x.Member)
                        .WithMany(x => x.MemberRole)
                        .HasForeignKey(x => x.MemberId);
            modelBuilder.Entity<MemberRole>()
                        .HasOne(x => x.Role)
                        .WithMany(x => x.MemberRole)
                        .HasForeignKey(x => x.RoleId);
        }
    }
}
