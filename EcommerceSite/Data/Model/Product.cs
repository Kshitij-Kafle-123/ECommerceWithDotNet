using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Data.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name ="Product Name")]
        [Required]
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        [Display(Name ="Short Description")]
        public string ShortDescription { get; set; }
        [Display(Name = "Long Description")]
        public string LongDescription { get; set; }
        [Required(ErrorMessage ="Rate is Required")]
        [Range(0.01, 999999999, ErrorMessage = "Enter valid amount")]
        public decimal Rate { get; set; }
        [Range(0.01, 999999999, ErrorMessage = "Enter valid number")]
        public decimal Discount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public virtual Category Category { get; set; }


    }
}
