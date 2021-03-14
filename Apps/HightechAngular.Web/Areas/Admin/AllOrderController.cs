using System;
using System.Linq;
using System.Threading.Tasks;
using Force.Ccc;
using Force.Extensions;
using HightechAngular.Areas.Admin;
using HightechAngular.Areas.Admin.CompleteOrder;
using HightechAngular.Areas.Admin.PayOrder;
using HightechAngular.Areas.Admin.ShipOrder;
using HightechAngular.Areas.Shared;
using HightechAngular.Orders.Entities;
using HightechAngular.Shop.Features.Cart;
using HightechAngular.Shop.Features.MyOrders;
using Infrastructure.AspNetCore;
using Infrastructure.Cqrs;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HightechAngular.Admin.Features.OrderManagement
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
        public IActionResult GetAll([FromQuery] GetAllOrders query) =>
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