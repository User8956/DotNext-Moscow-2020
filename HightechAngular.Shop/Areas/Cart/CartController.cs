using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Force.Cqrs;
using Force.Extensions;
using HightechAngular.Core.Entities;
using HightechAngular.Shop.Areas.Cart.AddItem;
using HightechAngular.Shop.Areas.Cart.RemoveItem;
using Infrastructure.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Shop.Areas.Cart
{
    public class CartController : ApiControllerBase
    {
        private readonly ICartStorage _cartStorage;
        private readonly IQueryable<Product> _products;

        public CartController(ICartStorage cartStorage,
            IQueryable<Product> products)
        {
            _cartStorage = cartStorage;
            _products = products;
        }

        [HttpGet]
        public ActionResult<List<CartItem>> Get([FromServices] ICartStorage storage) =>
            storage.Cart.CartItems.PipeTo(Ok);

        [HttpPut("Add")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public IActionResult Add([FromBody] int productId) => this.Process(new AddToCartCommand(productId));


        [HttpPut("Remove")]
        public ActionResult<bool> Remove([FromBody] int productId) => this.Process(new RemoveFromCartCommand(productId));

    }
}