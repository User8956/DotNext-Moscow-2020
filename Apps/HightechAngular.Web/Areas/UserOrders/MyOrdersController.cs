using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Force.Ccc;
using Force.Cqrs;
using HightechAngular.Areas.Admin.CompleteOrder;
using HightechAngular.Areas.Shared;
using HightechAngular.Areas.UserOrders.CreateOrder;
using HightechAngular.Areas.UserOrders.DisputeOrder;
using HightechAngular.Areas.UserOrders.PayOrder;
using HightechAngular.Identity.Services;
using HightechAngular.Orders.Entities;
using HightechAngular.Orders.Services;
using Infrastructure.AspNetCore;
using Infrastructure.Cqrs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Areas.UserOrders
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
        public async Task<IActionResult> Complete([FromBody] CompleteOrderAdminCommand command) => 
            await this.ProcessAsync(command);

        [HttpPut("PayOrder")]
        public async Task<IActionResult> PayOrder([FromBody] PayMyOrderCommand command) => await this.ProcessAsync(command);
    }
}