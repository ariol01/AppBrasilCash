using AppBrasilCash.Models;
using Microsoft.EntityFrameworkCore;

namespace AppCashBrasil.Infra
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasKey(x => x.Id);
            modelBuilder.Entity<Account>().HasIndex(x => x.TaxId).IsUnique();
            modelBuilder.Entity<Account>().Property(x => x.Name).HasMaxLength(60).IsRequired();
            modelBuilder.Entity<Account>().Property(x => x.Password).IsRequired();
            modelBuilder.Entity<Account>().Property(x => x.PhoneNumber).IsRequired(false);
            modelBuilder.Entity<Account>().Property(x => x.PostalCode).IsRequired(false);
            
            modelBuilder.Entity<Address>().HasKey(x => x.Id);
            modelBuilder.Entity<Address>().Property(x => x.District).IsRequired(false);
        }
    }
}
