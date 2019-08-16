using AutoMapper;
using MoneyDiary.Entities;
using MoneyDiary.ViewModels.Account;

namespace MoneyDiary.BusinessLogic.Mappers
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
