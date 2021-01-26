using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Data.Model
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string Price { get; set; }
        public Nullable<int> Amount { get; set; }
        public string Image { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
