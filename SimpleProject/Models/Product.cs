using System;

namespace SimpleProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    
        //public Product(string name, string category, decimal price)
        //{
        //    Name = name;
        //    Category = category;
        //    Price = price;
        //}
    }


}
