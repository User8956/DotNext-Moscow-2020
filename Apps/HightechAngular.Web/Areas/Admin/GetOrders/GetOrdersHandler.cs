using Force.Cqrs;
using Force.Extensions;
using HightechAngular.Admin.Features.OrderManagement;
using HightechAngular.Areas.Admin;
using HightechAngular.Areas.Shared;
using HightechAngular.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HightechAngular.Areas.Admin.GetOrders
{
    public class GetOrdersHandler : IQueryHandler<GetMyOrdersQuery, IEnumerable<OrderListItem>>
    {
        private readonly IQueryable<Order> _orders;

        public GetOrdersHandler(IQueryable<Order> orders)
        {
            _orders = orders;
        }


        public IEnumerable<OrderListItem> Handle(GetMyOrdersQuery input)
        {
            return (IEnumerable<OrderListItem>)_orders
                .Select(AllOrdersItem.Map)
                .ToList();
        }
            
    }
}
