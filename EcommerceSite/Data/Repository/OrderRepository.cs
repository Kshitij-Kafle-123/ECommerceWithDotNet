using EcommerceSite.Data.Interfaces;
using EcommerceSite.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShopNepalDbContext _context;
        private readonly ShoppingCart _shoppingCart;


        public OrderRepository(ShopNepalDbContext context, ShoppingCart shoppingCart)
        {
            _context = context;
            _shoppingCart = shoppingCart;
        }


        public void CreateOrder(Order order)
        {
            order.OrderDate = DateTime.Now;

            _context.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.CartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    ProductId = shoppingCartItem.Product.ProductId,
                    OrderId = order.OrderId,
                    Price= (shoppingCartItem.Product.Rate).ToString()
                };

                _context.OrderDetails.Add(orderDetail);
            }

            _context.SaveChanges();
        }
    }
}
