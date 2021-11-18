using KeoghsKataTestCheckout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeoghsKataTestCheckout.ViewModels
{
    public class BasketViewModel
    {
        public List<Product> Products { get; set; }
        public int TotalPrice { get; set; }
    }
}