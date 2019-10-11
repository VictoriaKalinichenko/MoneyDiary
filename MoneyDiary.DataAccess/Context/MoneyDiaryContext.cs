using Microsoft.EntityFrameworkCore;
using MoneyDiary.Entities;

namespace MoneyDiary.DataAccess.Context
{
  public class MoneyDiaryContext : DbContext
  {
    public DbSet<Account> Account { get; set; }
    public DbSet<Transaction> Transaction { get; set; }
    public DbSet<Category> Category { get; set; }

    public MoneyDiaryContext(DbContextOptions<MoneyDiaryContext> options) : base(options) { }
  }
}
