using HightechAngular.Core.Services;

namespace HightechAngular.Admin.Areas.OrderManagement.CompleteOrder
{
    public class CompleteOrderAdminCommand : ChangeOrderStateBase
    {
        public int OrderId { get; set; }
    }
}