using Force.Cqrs;
using HightechAngular.Areas.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Areas.Catalog.GetProducts
{
    public class GetProductsQuery : FilterQuery<ProductListItem>
    {
        public string[] Name { get; set; }
        public double[] Price { get; set; }
        public int CategoryId { get; set; }
        public GetProductsQuery()
        {
            Order = "Id";
            CategoryId = 1;
        }

        public override IQueryable<ProductListItem> Filter(IQueryable<ProductListItem> queryable)
        {
            return base.Filter(queryable.Where(x => x.CategoryId == CategoryId));
        }

        public override IOrderedQueryable<ProductListItem> Sort(IQueryable<ProductListItem> queryable)
        {
            if (Order == "dateCreated")
            {
                return Asc ? queryable.OrderByDescending(x => x.DateCreated) : queryable.OrderBy(x => x.DateCreated);
            }
            return base.Sort(queryable);
        }
    }
}
