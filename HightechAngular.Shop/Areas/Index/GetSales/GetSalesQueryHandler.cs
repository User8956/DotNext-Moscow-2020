using Force.Cqrs;
using HightechAngular.Core.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Shop.Areas.Index.GetSales
{
    public class GetSalesQueryHandler : IQueryHandler<GetSalesQuery, IEnumerable<SaleListItem>>
    {
        private IQueryable<Product> _products;

        public GetSalesQueryHandler(IQueryable<Product> products)
        {
            _products = products;
        }

        public IEnumerable<SaleListItem> Handle(GetSalesQuery input)
        {
            return _products
                   .Where(x => x.DiscountPercent > 0)
                   .ProjectToType<SaleListItem>()
                   .ToList();

        }
    }
}
