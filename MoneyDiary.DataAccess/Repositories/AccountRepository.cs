using MoneyDiary.DataAccess.Context;
using MoneyDiary.DataAccess.Interfaces;
using MoneyDiary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyDiary.DataAccess.Repositories
{
  public class AccountRepository : IAccountRepository
  {
    public List<Account> GetAll()
    {
      var accounts = new List<Account>();

      using (var context = new MoneyDiaryContext())
      {
        accounts = context.Account.ToList();
      }

      return accounts;
    }

    public void Insert(Account account)
    {
      using (var context = new MoneyDiaryContext())
      {
        context.Account.Add(account);
      }
    }

    public Account Get(Guid id)
    {
      Account account = null;

      using (var context = new MoneyDiaryContext())
      {
        account = context.Account.FirstOrDefault(x => x.Id == id);
      }

      return account;
    }

    public void Update(Account account)
    {
      using (var context = new MoneyDiaryContext())
      {
        context.Account.Update(account);
      }
    }

    public void Delete(Guid id)
    {
      using (var context = new MoneyDiaryContext())
      {
        Account account = context.Account.FirstOrDefault(x => x.Id == id);

        if (account != null)
        {
          context.Account.Remove(account);
        }
      }
    }
  }
}
