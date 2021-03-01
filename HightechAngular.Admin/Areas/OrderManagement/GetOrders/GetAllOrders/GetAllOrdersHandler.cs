using Force.Cqrs;
using HightechAngular.Admin.Areas.OrderManagement;
using HightechAngular.Admin.Features.OrderManagement;
using HightechAngular.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Admin.Areas.OrderManagement.GetOrders.GetAllOrders
{
    public class GetAllOrdersHandler : IQueryHandler<GetAllOrdersQuery, IEnumerable<OrderListItem>>
    {

        private readonly IQueryable<Order> _orders;

        public GetAllOrdersHandler(IQueryable<Order> orders)
        {
            _orders = orders;
        }

        public IEnumerable<OrderListItem> Handle(GetAllOrdersQuery input) =>
            (IEnumerable<OrderListItem>)_orders
              .Select(AllOrdersItem.Map);
    }
}
