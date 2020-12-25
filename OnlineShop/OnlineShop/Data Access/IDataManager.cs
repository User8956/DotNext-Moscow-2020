using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data_Access
{
    public interface IDataManager
    {
        public IQueryable<Product> GetAllProducts();
        public IQueryable<Product> GetProductByName(string name);
    }
}
