using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MoneyDiary.BusinessLogic.Mappers.Profiles;

namespace MoneyDiary.BusinessLogic.Config
{
  public class AutoMapperConfig
  {
    public void ConfigureServices(IServiceCollection services)
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
