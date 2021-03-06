﻿using Force.Cqrs;
using HightechAngular.Core.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Shop.Areas.Index.GetArrivals
{
    public class GetNewArrivalsQueryHandler : IQueryHandler<GetNewArrivalsQuery, IEnumerable<NewArrivalsListItem>>
    {

        private IQueryable<Product> _products;

        public GetNewArrivalsQueryHandler(IQueryable<Product> products)
        {
            _products = products;
        }

        public IEnumerable<NewArrivalsListItem> Handle(GetNewArrivalsQuery input)
        {
            return _products
                   .ProjectToType<NewArrivalsListItem>()
                   .OrderByDescending(x => x.DateCreated)
                   .Take(4)
                   .ToList();
        }
    }
}
