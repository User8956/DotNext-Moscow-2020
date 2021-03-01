using Force.Cqrs;
using Force.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Shop.Areas.Cart.RemoveItem
{
    public class RemoveFromCartCommand : HasIdBase, ICommand<bool>
    {
        public int ProductID { get; private set; }

        public RemoveFromCartCommand(int productId)
        {
            ProductID = productId;
        }

    }
}
