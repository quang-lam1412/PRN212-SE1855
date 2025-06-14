using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQObject2
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();
        }
        public void gen_products()
        {
            products.Add(new Product()
            {
                Id = 1,
                Name = "Laptop",
                Quantity = 10,
                Price = 1500
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Laptop",
                Quantity = 10,
                Price = 1500
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Laptop",
                Quantity = 10,
                Price = 1500
            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Laptop",
                Quantity = 10,
                Price = 1500
            });
            products.Add(new Product()
            {
                Id = 5,
                Name = "Laptop",
                Quantity = 10,
                Price = 1500
            });
            products.Add(new Product()
            {
                Id = 6,
                Name = "Laptop",
                Quantity = 10,
                Price = 1500
            });
            products.Add(new Product()
            {
                Id = 7,
                Name = "Laptop",
                Quantity = 10,
                Price = 1500
            });
            products.Add(new Product()
            {
                Id = 8,
                Name = "Laptop",
                Quantity = 10,
                Price = 1500
            });
            products.Add(new Product()
            {
                Id = 9,
                Name = "Laptop",
                Quantity = 10,
                Price = 1500
            });
            products.Add(new Product()
            {
                Id = 10,
                Name = "Laptop",
                Quantity = 10,
                Price = 1500
            });
            



        }
        public List<Product> FilterProductsByPrice(double price1, double price2)
        {
            var results = from p in products
                          where p.Price >= price1 && p.Price <= price2
                          select p;
            return results.ToList();
        }
        public List<Product> SortProductByPriceDec2()
        {
            var result = from p in products
                         orderby p.Price descending
                         select p;
            return result.ToList();
        }
        public double SumOfValue()
        {
            return products.Sum(p => p.Price * p.Quantity);
        }
    }
}
