using System.Threading.Tasks;
using Force.Cqrs;
using Force.Ddd;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;

namespace HightechAngular.Core.Services
{
    public abstract class ChangeOrderStateBase :
        HasIdBase,
        ICommand<Task<HandlerResult<OrderStatus>>>
    {
    }
}