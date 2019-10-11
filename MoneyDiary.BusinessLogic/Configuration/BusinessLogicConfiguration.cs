using Microsoft.Extensions.DependencyInjection;
using MoneyDiary.BusinessLogic.Interfaces;
using MoneyDiary.BusinessLogic.Services;
using MoneyDiary.DataAccess.Configuration;

namespace MoneyDiary.BusinessLogic.Configuration
{
  public class BusinessLogicConfiguration
  {
    public static void ConfigureServices(IServiceCollection services, string connectionString)
    {
      AutoMapperConfig.ConfigureServices(services);
      DataAccessConfiguration.ConfigureServices(services, connectionString);

      services.AddTransient<IAccountService, AccountService>();
      services.AddTransient<ITransactionService, TransactionService>();
      services.AddTransient<IUtilityService, UtilityService>();
    }
  }
}
