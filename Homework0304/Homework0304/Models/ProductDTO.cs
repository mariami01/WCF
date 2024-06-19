﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework0304.Models
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}