using MoneyDiary.DataAccess.Context;
using MoneyDiary.DataAccess.Interfaces;
using MoneyDiary.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MoneyDiary.DataAccess.Repositories
{
  public class CategoryRepository : ICategoryRepository
  {
    public List<Category> GetAll()
    {
      var categories = new List<Category>();

      using (var context = new MoneyDiaryContext())
      {
        categories = context.Category.ToList();
      }

      return categories;
    }
  }
}
