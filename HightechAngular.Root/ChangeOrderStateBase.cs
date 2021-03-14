using System.Threading.Tasks;
using Force.Cqrs;
using Force.Ddd;
using HightechAngular.Orders.Entities;
using Infrastructure.Cqrs;

namespace HightechAngular.Areas.Shared
{
    public abstract class ChangeOrderStateBase: 
        HasIdBase,
        ICommand<Task<HandlerResult<OrderStatus>>>
    {
    }
}