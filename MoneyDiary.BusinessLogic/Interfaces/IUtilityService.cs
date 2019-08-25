using MoneyDiary.ViewModels.Utility;
using System.Collections.Generic;

namespace MoneyDiary.BusinessLogic.Interfaces
{
  public interface IUtilityService
  {
    List<EnumViewItem> GetAccountTypeList();
    List<EnumViewItem> GetChargeTypeList();
  }
}
