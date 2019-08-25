using MoneyDiary.BusinessLogic.Interfaces;
using MoneyDiary.Constants.Enums;
using MoneyDiary.ViewModels.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyDiary.BusinessLogic.Services
{
  public class UtilityService : IUtilityService
  {
    public List<EnumViewItem> GetAccountTypeList()
    {
      List<EnumViewItem> itemList = GetEnumItemList<AccountType>();
      return itemList;
    }

    public List<EnumViewItem> GetChargeTypeList()
    {
      List<EnumViewItem> itemList = GetEnumItemList<ChargeType>();
      return itemList;
    }

    private List<EnumViewItem> GetEnumItemList<T>() where T : Enum
    {
      List<EnumViewItem> itemList = new List<EnumViewItem>();
      List<T> accountTypes = Enum.GetValues(typeof(T)).Cast<T>().ToList();

      foreach (T type in accountTypes)
      {
        EnumViewItem viewItem = new EnumViewItem();
        viewItem.Value = Convert.ToInt32(type);
        viewItem.Label = type.ToString();
        itemList.Add(viewItem);
      }

      return itemList;
    }
  }
}
