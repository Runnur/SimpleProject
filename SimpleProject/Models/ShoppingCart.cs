﻿using System;
using System.Collections.Generic;

namespace SimpleProject.Models
{
    public class ShoppingCart
    {
        private IValueCalculator calc;


        public ShoppingCart(IValueCalculator calcParam)
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
