using HightechAngular.Areas.Shared;
using HightechAngular.Orders.Entities;

namespace HightechAngular.Areas.Admin.ShipOrder
{
    public class ShipOrderCommand: ChangeOrderStateBase
    {
        public int   OrderId { get; set; }
    }
}