using MoneyDiary.Constants.Enums;
using System;

namespace MoneyDiary.Entities
{
  public class Transaction
  {
    public Guid Id { get; set; }
    public long Amount { get; set; }
    public TransactionType Type { get; set; }
    public DateTime Created { get; set; }
    public string Comment { get; set; }

    public Guid CategoryId { get; set; }
    public Guid AccountId { get; set; }
  }
}
