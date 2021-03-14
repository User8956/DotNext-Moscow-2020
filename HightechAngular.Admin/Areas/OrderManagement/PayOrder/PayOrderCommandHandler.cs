using Force.Ccc;
using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Admin.Areas.OrderManagement.PayOrder
{
    public class PayOrderCommandHandler : ICommandHandler<PayOrderCommand, Task<HandlerResult<OrderStatus>>>
    {

        private readonly IQueryable<Order> _orders;
        private readonly IUnitOfWork _unitOfWork;

        public PayOrderCommandHandler(IQueryable<Order> orders, IUnitOfWork unitOfWork)
        {
            _orders = orders;
            _unitOfWork = unitOfWork;
        }

        public async Task<HandlerResult<OrderStatus>> Handle(PayOrderCommand input)
        {
            await Task.Delay(1000);
            var order = _orders.First(x => x.Id == input.OrderId);
            var result = order.BecomePaid();
            _unitOfWork.Commit();
            return new HandlerResult<OrderStatus>(result);
        }
    }
}
