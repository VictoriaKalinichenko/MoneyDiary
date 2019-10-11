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
    private readonly MoneyDiaryContext _context;

    public AccountRepository(MoneyDiaryContext context)
    {
      _context = context;
    }

    public List<Account> GetAll()
    {
      var accounts = new List<Account>();
      accounts = _context.Account.ToList();
      return accounts;
    }

    public void Insert(Account account)
    {
      _context.Account.Add(account);
    }

    public Account Get(Guid id)
    {
      Account account = null;
      account = _context.Account.FirstOrDefault(x => x.Id == id);
      return account;
    }

    public void Update(Account account)
    {
      _context.Account.Update(account);
    }

    public void Delete(Guid id)
    {
      Account account = _context.Account.FirstOrDefault(x => x.Id == id);

      if (account != null)
      {
        _context.Account.Remove(account);
      }
    }
  }
}
