using MoneyDiary.DataAccess.Context;
using MoneyDiary.DataAccess.Interfaces;
using MoneyDiary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyDiary.DataAccess.Repositories
{
  public class TransactionRepository : ITransactionRepository
  {
    public List<Transaction> GetAll()
    {
      var transactions = new List<Transaction>();

      using (var context = new MoneyDiaryContext())
      {
        transactions = context.Transaction.ToList();
      }

      return transactions;
    }

    public void Insert(Transaction transaction)
    {
      using (var context = new MoneyDiaryContext())
      {
        context.Transaction.Add(transaction);
      }
    }

    public Transaction Get(Guid id)
    {
      Transaction transaction = null;

      using (var context = new MoneyDiaryContext())
      {
        transaction = context.Transaction.FirstOrDefault(x => x.Id == id);
      }

      return transaction;
    }
  }
}
