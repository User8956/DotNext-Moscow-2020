using System.Collections.Generic;

namespace HightechAngular.Core.Entities
{
    public interface ICartStorage
    {
        Cart Cart { get; }
        void SaveChanges();
        void EmptyCart();
    }
}