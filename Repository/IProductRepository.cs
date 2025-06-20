﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repository
{
    public interface IProductRepository
    {
        public void GenerateSampleDataset();

        public List<Product> GetProducts();
        public bool SaveProduct(Product product);
    }
}
