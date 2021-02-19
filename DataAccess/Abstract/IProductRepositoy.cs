using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        Product GetProductDetails(string url);
        List<Product> GetPopularProducts();
        List<Product> GetProductsByCategory(string name,int page,int pageSize);
        List<Product> GetTop5Products();
        int GetCountByCategory(string category);
        List<Product> GetHomePageProducts();
    }
}
