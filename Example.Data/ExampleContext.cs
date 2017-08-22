using System;
using Microsoft.EntityFrameworkCore;

namespace Example.Data
{
    public class ExampleContext: DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Example.db");
            //optionsBuilder.UseInMemoryDatabase();
        }

        public class Blog
        {
            public int Id { get; set; }
            public string Url { get; set; }

        }
    }
}
