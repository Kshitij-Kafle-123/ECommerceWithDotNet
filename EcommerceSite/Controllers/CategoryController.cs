using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceSite.Data;
using EcommerceSite.Data.Interfaces;
using EcommerceSite.Data.Model;
using EcommerceSite.Data.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace EcommerceSite.Controllers
{
    [Authorize(Roles ="Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ShopNepalDbContext _context;

        public CategoryController(ICategoryRepository categoryRepository, ShopNepalDbContext context)
        {
            _context = context;
            _categoryRepository = categoryRepository;
                
        }
        [Route("Category")]
        public IActionResult Index()
        {
            var categoryList=_categoryRepository.GetAll();
            return View(categoryList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    category.CreatedDate = DateTime.Now;
                    _categoryRepository.Create(category);
                    TempData["message"] = "Data inserted Successfully!!!";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception )
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _categoryRepository.GetById(id);
            return View(data);
        }
        public IActionResult Edit(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    category.UpdatedDate = DateTime.Now;
                    _categoryRepository.Update(category);
                    TempData["message"] = "Successfully updated!!";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                return View();
            }
           
        }
        public IActionResult Delete(int id)
        {
            var data=_categoryRepository.GetById(id);
            _categoryRepository.Delete(data);
            TempData["message"] = "Successfully Deleted!!";
            return RedirectToAction("Index");
        }
    }
}