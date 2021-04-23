using InjectionDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace InjectionDemo
{
    public class InjectDatabaseContext : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Question> Questions { get; set; }

        public InjectDatabaseContext(DbContextOptions<InjectDatabaseContext> options) : base(options)
        {
        }
    }
}