using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceSite.Data.Interfaces;
using EcommerceSite.Data.Model;
using EcommerceSite.Data.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceSite.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }
        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }
        [Authorize]

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var items = _shoppingCart.GetCartItems();
            _shoppingCart.CartItems = items;
            if (_shoppingCart.CartItems.Count == 0)
            {
                return View("~/Views/Order/Error.cshtml");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            return View();
        }
    }
}
