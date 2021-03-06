﻿using Force.Cqrs;
using HightechAngular.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Shop.Areas.Cart.RemoveItem
{
    public class RemoveFromCartCommandHandler : ICommandHandler<RemoveFromCartCommand, bool>
    {
        private readonly ICartStorage _cartStorage;

        public RemoveFromCartCommandHandler(ICartStorage cartStorage)
        {
            _cartStorage = cartStorage;
        }

        public bool Handle(RemoveFromCartCommand input)
        {
            var res = _cartStorage.Cart.TryRemoveProduct(input.ProductID);
            _cartStorage.SaveChanges();
            return res;
        }
    }
}
