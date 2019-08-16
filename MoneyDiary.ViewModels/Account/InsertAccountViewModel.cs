namespace MoneyDiary.ViewModels.Account
{
  public class InsertAccountViewModel
  {
    public int Type { get; set; }
    public int ChargeType { get; set; }
    public string ChargeNumber { get; set; }
    public long InitialBalance { get; set; }
  }
}
