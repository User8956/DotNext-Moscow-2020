using Force.Cqrs;
using HightechAngular.Admin.Features.OrderManagement;
using HightechAngular.Areas.Admin;
using HightechAngular.Areas.Shared;
using HightechAngular.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Areas.Admin.GetAllOrders
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
