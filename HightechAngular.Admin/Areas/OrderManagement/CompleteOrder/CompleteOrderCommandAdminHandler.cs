using Force.Cqrs;
using HightechAngular.Admin.Areas.OrderManagement;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Admin.Areas.OrderManagement.CompleteOrder
{
    public class CompleteOrderCommandAdminHandler : ICommandHandler<CompleteOrderAdminCommand, Task<HandlerResult<OrderStatus>>>
    {
        private readonly IQueryable<Order> _orders;

        public CompleteOrderCommandAdminHandler(IQueryable<Order> orders)
        {
            _orders = orders;
        }

        public async Task<HandlerResult<OrderStatus>> Handle(CompleteOrderAdminCommand input)
        {
            var order = _orders.First(x => x.Id == input.OrderId);
            await Task.Delay(1000);
            var result = order.BecomeComplete();
            return new HandlerResult<OrderStatus>(result);
        }
    }
}
