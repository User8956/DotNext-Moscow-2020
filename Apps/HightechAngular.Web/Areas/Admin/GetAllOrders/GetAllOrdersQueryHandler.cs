using Force.Cqrs;
using HightechAngular.Areas.Shared;
using HightechAngular.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Areas.Admin.GetAllOrders
{
    public class GetAllOrdersQueryHandler : IQueryHandler<GetAllOrdersQuery, IEnumerable<OrderListItem>>
    {

        private readonly IQueryable<Order> _orders;

        public GetAllOrdersQueryHandler(IQueryable<Order> orders)
        {
            _orders = orders;
        }

        public IEnumerable<OrderListItem> Handle(GetAllOrdersQuery input) =>
              (IEnumerable<OrderListItem>)_orders
              .Select(AllOrdersItem.Map);
              
    }
}
