using System.Collections.Generic;
using System.Linq;
using Force.Cqrs;
using HightechAngular.Core.Entities;
using HightechAngular.Shop.Areas.Catalog.GetCategories;
using HightechAngular.Shop.Areas.Catalog.GetProducts;
using Infrastructure.AspNetCore;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Shop.Areas.Catalog
{
    public class CatalogController : ApiControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductListItem>> Get([FromQuery] GetProductsQuery query) => this.Process(query);

        [HttpGet("GetCategories")]
        public IActionResult GetCategories() => this.Process(new GetCategoriesQuery());
    }
}