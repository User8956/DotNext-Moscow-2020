using Force.Cqrs;
using HightechAngular.Core.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Shop.Areas.Index.GetBestsellers
{
    public class GetBesellersQueryHandler : IQueryHandler<GetBestsellersQuery, IEnumerable<BestsellersListItem>>
    {
        private IQueryable<Product> _products;

        public GetBesellersQueryHandler(IQueryable<Product> products)
        {
            _products = products;
        }


        public IEnumerable<BestsellersListItem> Handle(GetBestsellersQuery input)
        {
            return _products
                .Where(Product.Specs.IsBestseller)
                .ProjectToType<BestsellersListItem>()
                .ToList();
        }
    }
}
