﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeration_And_Compostion_Exercice_01.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
