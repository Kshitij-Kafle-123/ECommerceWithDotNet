using EcommerceSite.Data.Interfaces;
using EcommerceSite.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Data.Repository
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        public ProductRepository(ShopNepalDbContext context):base(context)
        {
        }

        public IEnumerable<Product> Products => _context.products.Include(c => c.Category);
    }
}
