using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApi.Entities;

namespace WebApi.Helpers
{
    public class DataContext : DbContext
    {

        public DataContext()
        {
        }


        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{


        //    modelBuilder.Entity<Account>(entity =>
        //    {


        //        entity.Property(e => e.Email).IsUnicode(false);
        //    });
        //}

    }
}