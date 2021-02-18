using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.WebUi.Models;

namespace ShopApp.WebUi.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;
        static CategoryRepository()
        {
            _categories = new List<Category>
            {
            new Category{CategoryId=1, Name = "Arabalar", Description = "Turbo Arabalar" },
            new Category{CategoryId=2, Name = "Telefonlar", Description = "Guclu Telefonlar" },
            new Category{CategoryId=3, Name = "Aksesuarlar", Description = "En iyi Aksesuarlar" },
            };
        }
        public static List<Category> Categories 
        {
            get 
            {
                return _categories;
            }
        }
        public static void AddCatogory(Category category)
        {
            _categories.Add(category);
        }
        public static Category GetCatogoryById(int id)
        {
            return _categories.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
