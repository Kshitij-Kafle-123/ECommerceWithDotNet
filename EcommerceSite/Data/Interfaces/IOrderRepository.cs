using EcommerceSite.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Data.Interfaces
{
        public interface IOrderRepository
        {
            void CreateOrder(Order order);
        }
    
}
