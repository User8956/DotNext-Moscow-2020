using System;
using System.Collections.Generic;

namespace HightechAngular.Core.Entities
{
    public class CartDto
    {
        public Guid Id { get; set; }

        public List<CartItem> CartItems { get; set; }
    }
}