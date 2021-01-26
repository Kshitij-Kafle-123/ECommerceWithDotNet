using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Data.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string PaymentType { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage ="Please enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter address")]
        public string Address { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
