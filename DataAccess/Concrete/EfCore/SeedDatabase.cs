using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();
            }
        }
        public static Category[] Categories = {
        new Category() {Name="Phone"},
        new Category() {Name="Notebook"},
        new Category() {Name="Electronic"}
        };

        public static Product[] Products = {
        new Product() {Name="Iphone",Description="Best",ImageUrl="1.jfif",IsApproved=true,Price=2300},
        new Product() {Name="Redmi",Description="Good",ImageUrl="2.jfif",IsApproved=true,Price=2300},
        new Product() {Name="Lenova",Description="Better",ImageUrl="3.jfif",IsApproved=false,Price=2300},
        new Product() {Name="Samsung",Description="Nice",ImageUrl="4.jfif",IsApproved=true,Price=2300},
        new Product() {Name="S3",Description="Simple",ImageUrl="5.jfif",IsApproved=false,Price=2300},
        new Product() {Name="Nokia",Description="Best",ImageUrl="7.jfif",IsApproved=true,Price=2300},
        };
    }
}
