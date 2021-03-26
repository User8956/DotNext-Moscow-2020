using HightechAngular.Core.Services;

namespace HightechAngular.Admin.Areas.OrderManagement.ShipOrder
{
    public class ShipOrderCommand : ChangeOrderStateBase
    {
        public int OrderId { get; set; }
    }
}