using MoneyDiary.Entities;
using System.Collections.Generic;

namespace MoneyDiary.DataAccess.Interfaces
{
  public interface ICategoryRepository
  {
    List<Category> GetAll();
  }
}
