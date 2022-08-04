using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BlazorHW.Data
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {
            
        }
        public DbSet<ContactInfo> Contacts { get; set; }

    }

    public class ContactDbContextFactory : IDesignTimeDbContextFactory<ContactContext> 
    {
        public ContactContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ContactContext>();
            optionsBuilder.UseSqlServer("Server=ORANGEBEECEE\\SQLEXPRESS;Database=ContactDB;User ID=Orange;Password=12345");

            return new ContactContext(optionsBuilder.Options);
        }
    }

}
