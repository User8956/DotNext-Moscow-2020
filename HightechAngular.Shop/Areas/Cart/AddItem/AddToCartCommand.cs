using Force.Ddd;
using Force.Cqrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Shop.Areas.Cart.AddItem
{
    public class AddToCartCommand : HasIdBase, ICommand<int>
    {
        public int ProductID { get; private set; }

        public AddToCartCommand(int productId)
        {
            ProductID = productId;
        }

    }
}
