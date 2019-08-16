using MoneyDiary.Constants.Enums;
using System;

namespace MoneyDiary.Entities
{
  public class Account
  {
    public Guid Id { get; set; }
    public long Balance { get; set; }
    public string ChargeNumber { get; set; }
    public AccountType Type { get; set; }
    public ChargeType ChargeType { get; set; }
  }
}
