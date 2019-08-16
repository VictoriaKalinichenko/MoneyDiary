using MoneyDiary.Entities;
using System;
using System.Collections.Generic;

namespace MoneyDiary.DataAccess.Interfaces
{
  public interface IAccountRepository
  {
    List<Account> GetAll();
    void Insert(Account account);
    Account Get(Guid id);
    void Update(Account account);
    void Delete(Guid id);
  }
}
