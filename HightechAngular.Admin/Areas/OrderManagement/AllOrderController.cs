using System;
using System.Linq;
using System.Threading.Tasks;
using Force.Ccc;
using Force.Extensions;
using HightechAngular.Account.Areas.UserOrders.GetOrders;
using HightechAngular.Admin.Areas.OrderManagement.CompleteOrder;
using HightechAngular.Admin.Areas.OrderManagement.GetOrders.GetAllOrders;
using HightechAngular.Admin.Areas.OrderManagement.PayOrder;
using HightechAngular.Admin.Areas.OrderManagement.ShipOrder;
using HightechAngular.Core.Entities;
using Infrastructure.AspNetCore;
using Infrastructure.Cqrs;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HightechAngular.Admin.Areas.OrderManagement
{
    public class OrderController : ApiControllerBase
    {
        private readonly IQueryable<Order> _orders;
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IQueryable<Order> orders, IUnitOfWork unitOfWork)
        {
            _orders = orders;
            _unitOfWork = unitOfWork;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(OrderListItem), StatusCodes.Status200OK)]
        public IActionResult GetAll([FromQuery] GetAllOrdersQuery query) =>
            _orders
                .Select(AllOrdersItem.Map)
                .PipeTo(Ok);

        [HttpPut("PayOrder")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> PayOrder([FromBody] PayOrderCommand command) => await this.ProcessAsync(command);

        [HttpGet("GetOrders")]
        [ProducesResponseType(typeof(AllOrdersItem), StatusCodes.Status200OK)]
        public IActionResult GetOrders([FromQuery] GetMyOrdersQuery query) => this.Process(query);


        [HttpPut("Shipped")]
        public async Task<IActionResult> Shipped([FromBody] ShipOrderCommand command) => await this.ProcessAsync(command);

        [HttpPut("Complete")]
        public async Task<IActionResult> Complete([FromBody] CompleteOrderAdminCommand command) =>
            await this.ProcessAsync(command);
    }
}