﻿using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Shop.Areas.Catalog.GetCategories
{
    public class GetCategoriesQueryHandler : GetIntEnumerableQueryHandlerBase<GetCategoriesQuery, Category, CategoryListItem>
    {
        public GetCategoriesQueryHandler(IQueryable<Category> queryable) : base(queryable)
        {
        }
    }
}
