﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAliasAndClone
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}