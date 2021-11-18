using KeoghsKataTestCheckout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeoghsKataTestCheckout.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}