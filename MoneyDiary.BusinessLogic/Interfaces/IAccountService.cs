using MoneyDiary.ViewModels.Account;

namespace MoneyDiary.BusinessLogic.Interfaces
{
  public interface IAccountService
  {
    GetAllAccountViewModel GetAll();
    void Insert(InsertAccountViewModel insertedAccount);
  }
}
