using Microsoft.EntityFrameworkCore;
using MoneyDiary.Entities;

namespace MoneyDiary.DataAccess.Context
{
  public class MoneyDiaryContext : DbContext
  {
    private const string dataSource = @"Data Source=DESKTOP-6FDL58C;Initial Catalog=MoneyDiary;Integrated Security=True;";

    public DbSet<Account> Account { get; set; }
    public DbSet<Transaction> Transaction { get; set; }
    public DbSet<Category> Category { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(dataSource);
    }
  }
}
