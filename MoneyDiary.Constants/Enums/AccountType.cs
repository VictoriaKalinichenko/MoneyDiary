using System.ComponentModel.DataAnnotations;

namespace MoneyDiary.Constants.Enums
{
  public enum AccountType
  {
    [Display(Name = "CASH Card")]
    Cash = 0,

    [Display(Name = "CHARGE Card")]
    Charge = 1
  }
}
