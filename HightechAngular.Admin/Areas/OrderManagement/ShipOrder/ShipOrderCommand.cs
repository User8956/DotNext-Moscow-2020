using HightechAngular.Core.Services;
using HightechAngular.Orders.Entities;

namespace HightechAngular.Admin.Areas.OrderManagement.ShipOrder
{
    public class ShipOrderCommand : ChangeOrderStateBase
    {
        public int OrderId { get; set; }
    }
}