using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Force.Ccc;
using Force.Cqrs;
using HightechAngular.Account.Areas.UserOrders.CompleteOrder;
using HightechAngular.Account.Areas.UserOrders.CreateOrder;
using HightechAngular.Account.Areas.UserOrders.DisputeOrder;
using HightechAngular.Account.Areas.UserOrders.GetOrders;
using HightechAngular.Account.Areas.UserOrders.PayOrder;
using HightechAngular.Core.Entities;
using Infrastructure.AspNetCore;
using Infrastructure.Cqrs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Account.Areas.UserOrders
{
    public class MyOrdersController : ApiControllerBase
    {

        [HttpPost("CreateNew")]
        [Authorize]
        public ActionResult<int> CreateNew(
            [FromBody] CreateOrderCommand command) => this.Process(command);


        [HttpGet("GetMyOrders")]
        public ActionResult<IEnumerable<OrderListItem>> GetMyOrders([FromQuery] GetMyOrdersQuery query) => this.Process(query);


        [HttpPut("Dispute")]
        public async Task<IActionResult> Dispute([FromBody] DisputeOrderCommand command) => await this.ProcessAsync(command);


        [HttpPut("Complete")]
        public async Task<IActionResult> Complete([FromBody] CompleteOrderCommand command) =>
            await this.ProcessAsync(command);

        [HttpPut("PayOrder")]
        public async Task<IActionResult> PayOrder([FromBody] PayMyOrderCommand command) => await this.ProcessAsync(command);
    }
}