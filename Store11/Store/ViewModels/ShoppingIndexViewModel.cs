﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Store.Models;

namespace Store.ViewModels
{
    public class ShoppingIndexViewModel
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
    }
}