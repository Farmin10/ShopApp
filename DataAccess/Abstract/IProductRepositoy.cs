using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        List<Product> GetPopularProducts();
        List<Product> GetTop5Products();
    }
}
