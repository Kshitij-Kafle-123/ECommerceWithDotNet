using EcommerceSite.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Data.Interfaces
{
    public interface IProductRepository: IRepository<Product>
    {
         IEnumerable<Product> Products { get; }
    }
}
