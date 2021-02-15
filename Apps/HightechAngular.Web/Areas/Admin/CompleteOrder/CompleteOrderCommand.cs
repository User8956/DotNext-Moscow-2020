using HightechAngular.Areas.Shared;

namespace HightechAngular.Areas.Admin.CompleteOrder
{
    public class CompleteOrderCommand: ChangeOrderStateBase
    {
        public int   OrderId { get; set; }
    }
}