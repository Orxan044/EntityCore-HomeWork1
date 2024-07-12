using Core_HomeWork2.Models.Abstract;

namespace Core_HomeWork2.Models.Concretes;

public class Category : BaseEntity
{
    public string? Name { get; set; }
    public ICollection<Product>? Products { get; set; }
}
