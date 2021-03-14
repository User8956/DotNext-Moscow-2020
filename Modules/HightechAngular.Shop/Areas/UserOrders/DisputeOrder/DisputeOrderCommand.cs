using HightechAngular.Areas.Shared;

namespace HightechAngular.Areas.UserOrders.DisputeOrder
{
    public class DisputeOrderCommand : ChangeOrderStateBase
    {
        public int   OrderId { get; set; }
    }
}