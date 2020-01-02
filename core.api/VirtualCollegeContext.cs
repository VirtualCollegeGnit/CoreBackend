using core.data.Model.Member;
using core.data.Model.Person;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.api
{
    //public class VirtualCollegeContext : DbContext
    //{
    //    public VirtualCollegeContext(DbContextOptions<VirtualCollegeContext> options) : base(options)
    //    {

    //    }

    //    public DbSet<Member> Members { get; set; }
    //    public DbSet<Person> People { get; set; }
    //    public DbSet<Student> Students { get; set; }
    //    public DbSet<Contact> Contacts { get; set; }
    //    //public DbSet<Blog> Blogs { get; set; }
    //}

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
