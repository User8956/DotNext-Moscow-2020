using System.Collections.Generic;
using System.Linq;
using Force.Cqrs;
using HightechAngular.Areas.Catalog.GetCategories;
using HightechAngular.Areas.Catalog.GetProducts;
using HightechAngular.Areas.Shared;
using HightechAngular.Orders.Entities;
using Infrastructure.AspNetCore;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Areas.Catalog
{
    public class CatalogController: ApiControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductListItem>> Get([FromQuery] GetProductsQuery query) => this.Process(query);

        [HttpGet("GetCategories")]
        public IActionResult GetCategories() => this.Process(new GetCategoriesQuery());
    }
}