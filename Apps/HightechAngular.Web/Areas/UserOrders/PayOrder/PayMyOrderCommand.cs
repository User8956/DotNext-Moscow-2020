using System.Threading.Tasks;
using Force.Cqrs;
using HightechAngular.Orders.Entities;
using Infrastructure.Cqrs;

namespace HightechAngular.Areas.UserOrders.PayOrder
{
    public class PayMyOrderCommand: ICommand<Task<HandlerResult<OrderStatus>>>
    {
        public int   OrderId { get; set; }
    }
}