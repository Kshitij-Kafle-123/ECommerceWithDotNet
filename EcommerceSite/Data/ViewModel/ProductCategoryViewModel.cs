using EcommerceSite.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Data.ViewModel
{
    public class ProductCategoryViewModel
    {
        public Product Product { get; set; }
        [NotMapped]
        public IEnumerable<Category> Categories { get;  set; }
    }
}
