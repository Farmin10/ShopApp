﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUi.Models;
using ShopApp.WebUi.ViewModels;

namespace ShopApp.WebUi.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;

        public ShopController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult List(string category,int page=1)
        {
            const int pageSize = 2;
            var productViewModel = new ProductListViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = _productService.GetCountByCategory(category),
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentCategory = category
                },
                Products = _productService.GetProductsByCategory(category,page,pageSize)
            };
            return View(productViewModel);
        }
        public IActionResult Details(string url)
        {
            if (url==null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails(url);
            if (product==null)
            {
                return NotFound();
            }
            return View(new ProductDetailModel { 
                Product=product,
                Categories=product.ProductCategories.Select(i=>i.Category).ToList()
            });
        }
    }
}
