using EntityFramework.Entity;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class TestTaskDBContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public TestTaskDBContext(DbContextOptions<TestTaskDBContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HTT_TestTask;Trusted_Connection=True;");
        }
    }
}
