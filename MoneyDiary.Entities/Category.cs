using System;

namespace MoneyDiary.Entities
{
  public class Category
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public string ColorHex { get; set; }
  }
}
