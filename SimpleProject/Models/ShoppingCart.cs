using System.Collections.Generic;

namespace SimpleProject.Models
{
    public class ShoppingCart	
    {
        private ILinqValueCalculator calc;

	
        public ShoppingCart(ILinqValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public IEnumerable<Product> Products { get; set; }
        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}