using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleProject.Models
{
    public class LinqValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }
        public LinqValueCalculator()
        {
        }
    }
}
