using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EcommerceSite.Data.Model;
using EcommerceSite.Data.Interfaces;

namespace EcommerceSite.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ShopNepalDbContext context) : base(context)
        {

        }

      
    }
}
