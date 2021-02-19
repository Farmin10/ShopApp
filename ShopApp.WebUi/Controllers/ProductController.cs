using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopApp.WebUi.ViewModels;

namespace ShopApp.WebUi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product() { Name="Iphone",Price=3000,Description="Iyi Telefon"};
            //ViewData["Catogory"] = "Telefonlar";
            //ViewData["Product"] = prd;
            ViewBag.Catogory = "Telefonlar";
            //ViewBag.Product = prd;
            return View(product);
        }
        public IActionResult List(int? id,string q)
        {
            //Console.WriteLine(RouteData.Values["controller"]);
            //Console.WriteLine(RouteData.Values["action"]);
            //Console.WriteLine(RouteData.Values["id"]);
            //Console.WriteLine(HttpContext.Request.Query["q"].ToString());
            //var products = ProductRepository.Products;
            //if (id!=null)
            //{
            //    products = products.Where(p => p.CategoryId == id).ToList();
            //}
            //if (!string.IsNullOrEmpty(q))
            //{
            //    products = products.Where(i => i.Name.ToLower().Contains(q.ToLower())|| i.Description.Contains(q)).ToList();
            //}
            //var productViewModel = new ProductViewModel()
            //{
            //    Products = products
            //};
            //return View(productViewModel);
            return View();
        }
        
        public IActionResult Details(int id)
        {
            //ViewBag.Name = "Samsung S6";
            //ViewBag.Price = 3000;
            //ViewBag.Description = "Iyi Telefon";
           
            return View();
        }
        public IActionResult Create()
        {

            //ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            return View(new Product());
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            //if (ModelState.IsValid)
            //{
            //    ProductRepository.AddProduct(product);
            //    return RedirectToAction("List");
            //}
            //ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View();
        }
        public IActionResult Edit(int id)
        {
            //ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            //ProductRepository.EditProduct(product);
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(int productId)
        {
            //ProductRepository.DeleteProduct(productId);
            return RedirectToAction("List");
        }
    }
}
