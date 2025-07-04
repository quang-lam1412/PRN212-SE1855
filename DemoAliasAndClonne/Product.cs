﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAliasAndClonne
{
    public class Product
    {
        public int Id { get; set; }    
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
         override public string ToString()
        {
            return $"Id:{Id}, Name:{Name},Quantity:{Quantity},Price:{Price}";
        }
        public Product clone()
        {
            return MemberwiseClone() as Product;
        }

    }
}
