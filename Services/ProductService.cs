using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repository;

namespace Services
{
    public class ProductService : IProductService
    {
        IProductRepository irepository;
        public ProductService()
        {
            irepository = new ProductRepository();
        }
        public void GenerateSampleData()
        {
            irepository.GenerateSampleDataset();
        }

        public void GenerateSampleDataset()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return irepository.GetProducts();
        }

        

        public bool SaveProduct(Product product)
        {
            return irepository.SaveProduct(product);
        }
    }
}
