using HightechAngular.Core.Services;

namespace HightechAngular.Account.Areas.UserOrders.DisputeOrder
{
    public class DisputeOrderCommand : ChangeOrderStateBase
    {
        public int OrderId { get; set; }
    }
}