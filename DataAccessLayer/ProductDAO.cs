using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();
        public void GenerateSampleData()
        {
            products.Add(new Product { Id = 1, Name = "Laptop", Price = 999.99F });
            products.Add(new Product { Id = 2, Name = "Smartphone", Price = 499.99F });
            products.Add(new Product { Id = 3, Name = "Tablet", Price = 299.99F });
            products.Add(new Product { Id = 4, Name = "Smartwatch", Price = 199.99F });
            products.Add(new Product { Id = 5, Name = "Headphones", Price = 89.99F });
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public bool SaveProduct(Product product)
        {
           Product old = products.FirstOrDefault(p => p.Id == product.Id);
            if (old != null)
            
                return false; // Product already exists
                products.Add(product);
                return true;
            
        }
    }
}
