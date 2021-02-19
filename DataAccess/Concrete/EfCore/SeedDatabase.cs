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
                    context.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
                context.SaveChanges();
            }
        }
        public static Category[] Categories = {
        new Category() {Name="Phone",Url="phone"},
        new Category() {Name="Notebook",Url="notebook"},
        new Category() {Name="Electronic",Url="electronic"},
        new Category() {Name="Photo Camera",Url="photo-camera"}
        };

        public static Product[] Products = {
        new Product() {Name="Iphone", Url="iphone",Description="Best",ImageUrl="1.jfif",IsApproved=true,Price=2300},
        new Product() {Name="Redmi",Url="redmi",Description="Good",ImageUrl="2.jfif",IsApproved=true,Price=2300},
        new Product() {Name="Lenova",Url="lenova",Description="Better",ImageUrl="3.jfif",IsApproved=false,Price=2300},
        new Product() {Name="Samsung",Url="samsung",Description="Nice",ImageUrl="4.jfif",IsApproved=true,Price=2300},
        new Product() {Name="S3",Url="s3",Description="Simple",ImageUrl="5.jfif",IsApproved=false,Price=2300},
        new Product() {Name="Nokia",Url="nokia",Description="Best",ImageUrl="7.jfif",IsApproved=true,Price=2300},
        };
        private static ProductCategory[] ProductCategories = {
        new ProductCategory(){ Product=Products[0],Category=Categories[0]},
        new ProductCategory(){ Product=Products[0],Category=Categories[2]},
        new ProductCategory(){ Product=Products[1],Category=Categories[0]},
        new ProductCategory(){ Product=Products[1],Category=Categories[2]},
        new ProductCategory(){ Product=Products[2],Category=Categories[0]},
        new ProductCategory(){ Product=Products[2],Category=Categories[2]},
        new ProductCategory(){ Product=Products[3],Category=Categories[0]},
        new ProductCategory(){ Product=Products[3],Category=Categories[2]},
        };
    }
}
