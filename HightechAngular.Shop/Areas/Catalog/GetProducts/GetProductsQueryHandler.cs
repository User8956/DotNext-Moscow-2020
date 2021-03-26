using Force.Cqrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.AspNetCore;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HightechAngular.Core.Entities;

namespace HightechAngular.Shop.Areas.Catalog.GetProducts
{
    public class GetProductsQueryHandler : IQueryHandler<GetProductsQuery, IEnumerable<ProductListItem>>
    {
        private readonly IQueryable<Product> _products;

        public GetProductsQueryHandler(IQueryable<Product> products)
        {
            _products = products;
        }

        public IEnumerable<ProductListItem> Handle(GetProductsQuery input)
        {
            return _products
            .Where(x => x.Category.Id == input.CategoryId)
            .ProjectToType<ProductListItem>()
            .ToList();
        }
    }
}
