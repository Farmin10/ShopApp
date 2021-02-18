using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.WebUi.Models;

namespace ShopApp.WebUi.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
            new Product{ProductId=1, Name="Ford",Price=18000,Description="Iyi Araba",IsApproved=false,ImageUrl="IMG_20200207_161332.jpg",CategoryId=1},
            new Product{ProductId=2, Name="mercedes",Price=36000,Description="Baya Iyi Araba",IsApproved=true,ImageUrl="IMG_20200320_121039.jpg",CategoryId=1},
            new Product{ProductId=3, Name="audi",Price=42000,Description="Iyi Araba",IsApproved=true,ImageUrl="IMG_20200327_185333.jpg",CategoryId=2},
            new Product{ProductId=4, Name="tayota",Price=36000,Description="Baya Iyi Araba",IsApproved=false,ImageUrl="IMG-20200119-WA0013.jpg",CategoryId=3}
            };
        }
        public static List<Product> Products
        {
            get 
            {
                return _products;
            }
        }
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
    
}
