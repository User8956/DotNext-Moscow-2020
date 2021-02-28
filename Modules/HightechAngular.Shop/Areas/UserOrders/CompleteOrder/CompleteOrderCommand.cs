using HightechAngular.Areas.Shared;

namespace HightechAngular.Areas.UserOrders.CompleteOrder
{
    public class CompleteOrderCommand : ChangeOrderStateBase
    {
        public int   OrderId { get; set; }
    }
}