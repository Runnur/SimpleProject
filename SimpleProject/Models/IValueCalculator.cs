using System.Collections.Generic;
namespace SimpleProject.Models
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}