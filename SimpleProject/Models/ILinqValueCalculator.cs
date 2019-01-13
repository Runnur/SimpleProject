using System;
using System.Collections.Generic;

namespace SimpleProject.Models
{
    public interface ILinqValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);

    }
}
