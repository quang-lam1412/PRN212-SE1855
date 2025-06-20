﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        override public string ToString()
        {
            return $"Customer ID: {Id}, Name: {Name}, Phone: {Phone}";
        }
    }
}
