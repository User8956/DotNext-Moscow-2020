using HightechAngular.Areas.Shared;

namespace HightechAngular.Areas.Admin.CompleteOrder
{
    public class CompleteOrderAdminCommand: ChangeOrderStateBase
    {
        public int   OrderId { get; set; }
    }
}