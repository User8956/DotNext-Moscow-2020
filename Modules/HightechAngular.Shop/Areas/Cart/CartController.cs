using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Force.Cqrs;
using Force.Extensions;
using HightechAngular.Areas.Cart.AddItem;
using HightechAngular.Areas.Cart.RemoveItem;
using HightechAngular.Orders.Entities;
using HightechAngular.Orders.Services;
using Infrastructure.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Areas.Cart
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