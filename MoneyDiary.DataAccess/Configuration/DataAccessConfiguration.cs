using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoneyDiary.DataAccess.Context;
using MoneyDiary.DataAccess.Interfaces;
using MoneyDiary.DataAccess.Repositories;

namespace MoneyDiary.DataAccess.Configuration
{
  public class DataAccessConfiguration
  {
    public static void ConfigureServices(IServiceCollection services, string connectionString)
    {
      services.AddDbContext<MoneyDiaryContext>(options => options.UseSqlServer(connectionString));

      services.AddTransient<IAccountRepository, AccountRepository>();
      services.AddTransient<ITransactionRepository, TransactionRepository>();
      services.AddTransient<ICategoryRepository, CategoryRepository>();
    }
  }
}
