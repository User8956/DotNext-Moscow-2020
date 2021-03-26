using System;
using System.Threading.Tasks;
using Force.Cqrs;
using Force.Ddd;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;

namespace HightechAngular.Admin.Areas.OrderManagement.PayOrder
{
    public class PayOrderCommand : HasIdBase, ICommand<Task<HandlerResult<OrderStatus>>>
    {
        public int OrderId { get; set; }
    }
}