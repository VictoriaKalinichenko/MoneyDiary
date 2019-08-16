using System.ComponentModel.DataAnnotations;

namespace MoneyDiary.Constants.Enums
{
  public enum ChargeType
  {
    [Display(Name = "Universal")]
    Universal = 0,

    [Display(Name = "For Payments")]
    ForPayments = 1,

    [Display(Name = "Universal GOLD")]
    UniversalGold = 2,

    [Display(Name = "For Payments GOLD")]
    ForPaymentsGold = 3
  }
}
