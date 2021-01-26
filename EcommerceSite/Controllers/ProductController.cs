using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceSite.Data;
using EcommerceSite.Data.Interfaces;
using EcommerceSite.Data.Model;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using EcommerceSite.Data.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace EcommerceSite.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ShopNepalDbContext _context;
        private readonly IHostingEnvironment _appEnvironment;

        public  ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository ,ShopNepalDbContext context, IHostingEnvironment appEnvironment)
        {
            _productRepository = productRepository;
            _context = context;
            _appEnvironment = appEnvironment;
            _categoryRepository = categoryRepository;
        }
        [Authorize(Roles ="Admin")]
        [Route("Product")]
        public IActionResult Index()
        {
            var productList = _productRepository.GetAll();
            return View(productList);
        }
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.Products.OrderBy(p => p.ProductName);
                currentCategory = "All Products";
            }
            else
            {
               products = _productRepository.Products.Where(p => p.Category.CategoryName == category);
                currentCategory = _category;
            }

            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }

        public ViewResult Details(int productId)
        {
            var product= _productRepository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
            {
                return View("~/Views/Product/Error.cshtml");
            }
            return View(product);
        }
        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Product> products;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                products = _productRepository.Products.OrderBy(p => p.ProductId);
            }
            else
            {
                products = _productRepository.Products.Where(p => p.ProductName.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Product/List.cshtml", new ProductListViewModel { Products = products, CurrentCategory = "All Prodcuts" });
        }
        [Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            ProductCategoryViewModel vm = new ProductCategoryViewModel()
            {
                Categories = _categoryRepository.GetAll()
            };
            return View(vm);
        }
        [Authorize(Roles ="Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductCategoryViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    {
                        var files = HttpContext.Request.Form.Files;
                        if (files != null)
                        {
                            foreach (var image in files)
                            {
                                if (image != null && image.Length > 0)
                                {
                                    var file = image;
                                    //There is an error here
                                    var uploads = Path.Combine(_appEnvironment.WebRootPath, "images//ProductImages");
                                    if (file.Length > 0)
                                    {
                                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                        {
                                            file.CopyToAsync(fileStream);
                                            model.Product.Image = "~/images/ProductImages/" + fileName;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            ProductCategoryViewModel vm = new ProductCategoryViewModel()
                            {
                                Categories = _categoryRepository.GetAll()
                            };
                            TempData["message"] = "Please insert image!!!";
                            return View(vm);
                        }

                        model.Product.CreatedDate = DateTime.Now;
                        _productRepository.Create(model.Product);
                        TempData["message"] = "Data inserted Successfully!!!";
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    ProductCategoryViewModel vm = new ProductCategoryViewModel()
                    {
                        Categories = _categoryRepository.GetAll()
                    };
                    return View(vm);
                }
            }
            catch (Exception ex)
            {
                TempData["message"] = "<div class='alert alert-danger'><a href='#' class='close' data-dismiss='alert'>&times; </a><strong> " + ex.ToString() + "</strong> </div>";
                ProductCategoryViewModel vm = new ProductCategoryViewModel()
                {
                    Categories = _categoryRepository.GetAll()
                };
                return View(vm);
            }
        }
        [Authorize(Roles = "Admin")]

        [HttpGet]
        public IActionResult Edit(int id)

        {
            ProductCategoryViewModel vm = new ProductCategoryViewModel()
            {
              Product = _productRepository.GetById(id),
              Categories = _categoryRepository.GetAll()
            };
            return View(vm);
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        public IActionResult Edit(ProductCategoryViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    {
                        var files = HttpContext.Request.Form.Files;
                        var count = files.Count;
                        if (count != 0)
                        {
                            foreach (var image in files)
                            {
                                if (image != null && image.Length > 0)
                                {
                                    var file = image;
                                    //There is an error here
                                    var uploads = Path.Combine(_appEnvironment.WebRootPath, "images//ProductImages");
                                    if (file.Length > 0)
                                    {
                                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                        {
                                            file.CopyToAsync(fileStream);
                                            model.Product.Image = "~/images/ProductImages/" + fileName;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            
                        }
                        model.Product.CreatedDate = DateTime.Now;
                        _productRepository.Update(model.Product);
                        TempData["message"] = "Product Updated Successfully!!!";
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    ProductCategoryViewModel vm = new ProductCategoryViewModel()
                    {
                        Product = _productRepository.GetById(model.Product.ProductId),
                        Categories = _categoryRepository.GetAll()
                    };
                    return View(vm);
                }
            }
            catch (Exception ex)
            {
                ProductCategoryViewModel vm = new ProductCategoryViewModel()
                {
                    Product = _productRepository.GetById(model.Product.ProductId),
                    Categories = _categoryRepository.GetAll()
                };
                return View(vm);
            }

        }
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var data = _productRepository.GetById(id);
            _productRepository.Delete(data);
            TempData["message"] = "Product deleted Successfully!!!";
            return RedirectToAction("Index");
        }
        
    }
}