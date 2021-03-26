using HightechAngular.Core.Entities;
using System;
using System.Collections.Generic;

namespace HightechAngular.Core.Services
{
    public class CartDto
    {
        public Guid Id { get; set; }

        public List<CartItem> CartItems { get; set; }
    }
}