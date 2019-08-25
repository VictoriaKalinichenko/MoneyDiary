using AutoMapper;
using MoneyDiary.Entities;
using MoneyDiary.ViewModels.Account;

namespace MoneyDiary.BusinessLogic.Mappers.Profiles
{
  public class AccountProfile : Profile
  {
    public AccountProfile()
    {
      CreateMap<Account, AccountViewItem>();
      CreateMap<InsertAccountViewModel, Account>();
    }
  }
}
