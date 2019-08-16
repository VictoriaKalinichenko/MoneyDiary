using MoneyDiary.Entities;
using System;
using System.Collections.Generic;

namespace MoneyDiary.DataAccess.Interfaces
{
  public interface ITransactionRepository
  {
    List<Transaction> GetAll();
    void Insert(Transaction transaction);
    Transaction Get(Guid id);
  }
}
