using MoneyDiary.DataAccess.Context;
using MoneyDiary.DataAccess.Interfaces;
using MoneyDiary.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MoneyDiary.DataAccess.Repositories
{
  public class CategoryRepository : ICategoryRepository
  {
    private readonly MoneyDiaryContext _context;

    public CategoryRepository(MoneyDiaryContext context)
    {
      _context = context;
    }

    public List<Category> GetAll()
    {
      var categories = new List<Category>();
      categories = _context.Category.ToList();
      return categories;
    }
  }
}
