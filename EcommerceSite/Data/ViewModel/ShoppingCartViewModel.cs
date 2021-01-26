using EcommerceSite.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Data.ViewModel
{
    public class ShoppingCartViewModel
    {
            public ShoppingCart ShoppingCart { get; set; }
            public decimal ShoppingCartTotal { get; set; }
    }
}
