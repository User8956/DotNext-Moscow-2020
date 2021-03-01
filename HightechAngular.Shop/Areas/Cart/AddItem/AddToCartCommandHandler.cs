using Force.Cqrs;
using HightechAngular.Core.Entities;
using System.Linq;

namespace HightechAngular.Shop.Areas.Cart.AddItem
{
    public class AddToCartCommandHandler : ICommandHandler<AddToCartCommand, int>
    {
        private readonly ICartStorage _cartStorage;
        private readonly IQueryable<Product> _products;

        public AddToCartCommandHandler(ICartStorage cartStorage,
            IQueryable<Product> products)
        {
            _cartStorage = cartStorage;
            _products = products;
        }

        public int Handle(AddToCartCommand input)
        {
            var product = _products.First(x => x.Id == input.ProductID);
            _cartStorage.Cart.AddProduct(product);
            _cartStorage.SaveChanges();
            return input.ProductID;
        }
    }
}
