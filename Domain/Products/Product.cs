﻿using System;
using CleanArchitecture.Domain.Vendors;

namespace CleanArchitecture.Domain.Products
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Vendor Vendor { get; set; }

        public decimal Price { get; set; }
    }
}
