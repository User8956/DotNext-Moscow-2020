using Force.Cqrs;
using HightechAngular.Areas.Shared;
using HightechAngular.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Areas.Admin.GetAllOrders
{
    public class GetAllOrdersQueryHandler : IQueryHandler<GetAllOrdersQuery, IEnumerable<AllOrdersItem>>
    {

        private readonly IQueryable<Order> _orders;

        public GetAllOrdersQueryHandler(IQueryable<Order> orders)
        {
            _orders = orders;
        }

        public IEnumerable<AllOrdersItem> Handle(GetAllOrdersQuery input) =>
              _orders
              .Select(AllOrdersItem.Map)
              .ToList();
              
    }
}
