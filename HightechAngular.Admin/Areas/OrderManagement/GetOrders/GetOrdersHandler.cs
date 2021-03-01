using Force.Cqrs;
using Force.Extensions;
using HightechAngular.Account.Areas.UserOrders.GetOrders;
using HightechAngular.Admin.Areas.OrderManagement;
using HightechAngular.Admin.Features.OrderManagement;
using HightechAngular.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HightechAngular.Admin.Areas.OrderManagement.GetOrders
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
            return (IQueryable<OrderListItem>)_orders
                .Select(AllOrdersItem.Map)
                .ToList();
        }

    }
}
