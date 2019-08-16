using System.Collections.Generic;

namespace MoneyDiary.ViewModels.Account
{
  public class GetAllAccountViewModel
  {
    public long TotalBalance { get; set; }
    public List<AccountViewItem> Accounts { get; set; }

    public GetAllAccountViewModel()
    {
      Accounts = new List<AccountViewItem>();
    }
  }
}
