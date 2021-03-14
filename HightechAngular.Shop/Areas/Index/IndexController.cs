using System.Collections.Generic;
using System.Linq;
using Force.Cqrs;
using HightechAngular.Shop.Areas.Index.GetArrivals;
using HightechAngular.Shop.Areas.Index.GetBestsellers;
using HightechAngular.Shop.Areas.Index.GetSales;
using Infrastructure.AspNetCore;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Shop.Areas.Index
{
    [Route("api")]
    public class IndexController : ApiControllerBase
    {

        [HttpGet("Bestsellers")]
        public ActionResult<IEnumerable<BestsellersListItem>> Get([FromQuery] GetBestsellersQuery query) =>
                this.Process(query);

        [HttpGet("NewArrivals")]
        public ActionResult<IEnumerable<NewArrivalsListItem>> Get([FromQuery] GetNewArrivalsQuery query) =>
            this.Process(query);

        [HttpGet("Sale")]
        public ActionResult<IEnumerable<SaleListItem>> Get([FromQuery] GetSalesQuery query) => this.Process(query);

    }
}