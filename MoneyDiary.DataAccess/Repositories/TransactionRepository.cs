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
    private readonly MoneyDiaryContext _context;

    public TransactionRepository(MoneyDiaryContext context)
    {
      _context = context;
    }

    public List<Transaction> GetAll()
    {
      var transactions = new List<Transaction>();
      transactions = _context.Transaction.ToList();
      return transactions;
    }

    public void Insert(Transaction transaction)
    {
      _context.Transaction.Add(transaction);
    }

    public Transaction Get(Guid id)
    {
      Transaction transaction = null;
      transaction = _context.Transaction.FirstOrDefault(x => x.Id == id);
      return transaction;
    }
  }
}
