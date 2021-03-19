using HightechAngular.Core.Entities;
using System.Collections.Generic;

namespace HightechAngular.Core.Services
{
    public interface ICartStorage
    {
        Cart Cart { get; }
        void SaveChanges();
        void EmptyCart();
    }
}