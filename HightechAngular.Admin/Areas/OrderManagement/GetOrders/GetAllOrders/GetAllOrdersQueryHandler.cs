using Force.Cqrs;
using HightechAngular.Admin.Areas.OrderManagement;
using HightechAngular.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Admin.Areas.OrderManagement.GetOrders.GetAllOrders
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
