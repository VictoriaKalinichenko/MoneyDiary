using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MoneyDiary.BusinessLogic.Mappers.Profiles;

namespace MoneyDiary.BusinessLogic.Configuration
{
  public class AutoMapperConfig
  {
    public static void ConfigureServices(IServiceCollection services)
    {
      var mappingConfig = new MapperConfiguration(mc =>
      {
        mc.AddProfile(new AccountProfile());
      });

      IMapper mapper = mappingConfig.CreateMapper();
      services.AddSingleton(mapper);
    }
  }
}
