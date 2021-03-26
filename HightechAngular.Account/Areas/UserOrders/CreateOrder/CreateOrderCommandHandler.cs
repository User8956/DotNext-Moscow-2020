using Force.Ccc;
using Force.Cqrs;
using HightechAngular.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Account.Areas.UserOrders.CreateOrder
{
    public class CreateOrderCommandHandler : ICommandHandler<CreateOrderCommand, int>
    {
        private readonly ICartStorage _cartStorage;
        private readonly IUnitOfWork _unitOfWork;

        public CreateOrderCommandHandler(
            ICartStorage cartStorage,
            IUnitOfWork unitOfWork)
        {
            _cartStorage = cartStorage;
            _unitOfWork = unitOfWork;
        }

        public int Handle(CreateOrderCommand input)
        {
            var order = new Order(_cartStorage.Cart);
            _unitOfWork.Add(order);
            _cartStorage.EmptyCart();
            _unitOfWork.Commit();

            return order.Id;
        }
    }
}
