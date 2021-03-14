using System;
using System.Threading.Tasks;
using Force.Cqrs;
using Force.Ddd;
using HightechAngular.Orders.Entities;
using Infrastructure.Cqrs;

namespace HightechAngular.Areas.Admin.PayOrder
{
    public class PayOrderCommand : HasIdBase, ICommand<Task<HandlerResult<OrderStatus>>>
    {
        public int OrderId { get; set; } 
    }
}