using HightechAngular.Core.Services;

namespace HightechAngular.Account.Areas.UserOrders.CompleteOrder
{
    public class CompleteOrderCommand : ChangeOrderStateBase
    {
        public int OrderId { get; set; }
    }
}