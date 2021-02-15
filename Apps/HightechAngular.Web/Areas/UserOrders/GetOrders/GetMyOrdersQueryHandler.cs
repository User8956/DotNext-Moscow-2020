using Force.Cqrs;
using HightechAngular.Areas.Shared;
using HightechAngular.Identity.Services;
using HightechAngular.Orders.Entities;
using HightechAngular.Shop.Features.MyOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Web.UserOrders.GetOrders
{
    public class GetMyOrdersQueryHandler : IQueryHandler<GetMyOrdersQuery, IEnumerable<OrderListItem>>
    {
        private readonly IQueryable<Order> _orders;
        private readonly IUserContext _userContext;

        public GetMyOrdersQueryHandler(
            IQueryable<Order> orders,
            IUserContext userContext)
        {
            _orders = orders;
            _userContext = userContext;
        }

        public IEnumerable<OrderListItem> Handle(GetMyOrdersQuery input)
        {
            return _orders
                      .Where(Order.Specs.ByUserName(_userContext.User?.UserName))
                      .Select(OrderListItem.Map)
                      .ToList();
        }
    }
}
