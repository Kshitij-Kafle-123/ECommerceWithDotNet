using EcommerceSite.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Data.Repository
{
    public class ShoppingCart
    {
        private readonly ShopNepalDbContext _context;
        private ShoppingCart(ShopNepalDbContext contex)
        {
            _context = contex;
        }

        public string CartId { get; set; }

        public List<CartItem> CartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<ShopNepalDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { CartId = cartId };
        }

        public void AddToCart(Product product, int amount)
        {
            var CartItem =
                      _context.cartItems.SingleOrDefault(
                         s => s.Product.ProductId == product.ProductId && s.CartId == CartId);

            if (CartItem == null)
            {
                CartItem = new CartItem
                {
                    CartId = CartId,
                    Product = product,
                    Amount = 1
                };

                _context.cartItems.Add(CartItem);
            }
            else
            {
                CartItem.Amount++;
            }
            _context.SaveChanges();
        }

        public int RemoveFromCart(Product product)
        {
            var CartItem =
                     _context.cartItems.SingleOrDefault(
                        s => s.Product.ProductId== product.ProductId && s.CartId == CartId);

            var localAmount = 0;

            if (CartItem != null)
            {
                if (CartItem.Amount > 1)
                {
                    CartItem.Amount--;
                    localAmount = CartItem.Amount;
                }
                else
                {
                    _context.cartItems.Remove(CartItem);
                }
            }

            _context.SaveChanges();

            return localAmount;
        }

        public List<CartItem> GetCartItems()
        {
            return CartItems ??
                   (CartItems =
                       _context.cartItems.Where(c => c.CartId == CartId)
                           .Include(s => s.Product)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _context
                .cartItems
                .Where(cart => cart.CartId ==CartId);

            _context.cartItems.RemoveRange(cartItems);

            _context.SaveChanges();
        }

        public decimal GetCartTotal()
        {
            var total = _context.cartItems.Where(c => c.CartId == CartId)
                .Select(c => c.Product.Rate* c.Amount).Sum();
            return total;
        }
    }
}
