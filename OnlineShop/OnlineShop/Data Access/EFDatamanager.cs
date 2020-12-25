using OnlineShop.Data_Access.Entity_Framework;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data_Access
{
    public class EFDatamanager : IDataManager
    {

        private EFDbContext _context;

        public EFDatamanager(EFDbContext context)
        {
            _context = context;
        }

        public IQueryable<Product> GetAllProducts()
        {
            return _context.Products;
        }

        public IQueryable<Product> GetProductByName(string name)
        {
            var result = from product in _context.Products
                         where product.Name.Equals(name)
                         select product;
            return result;
        }
    }
}
