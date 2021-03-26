using System;
using System.Threading.Tasks;
using HightechAngular.Core.Entities;
using Infrastructure.SwaggerSchema.Dropdowns;

namespace Infrastructure.SwaggerSchema.Dropdowns.Providers
{
    public class OrderListItemDropdownProvider : IDropdownProvider<OrderListItem>
    {
        private readonly IServiceProvider _serviceProvider;

        public OrderListItemDropdownProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<Dropdowns> GetDropdownOptionsAsync()
        {
            return _serviceProvider.DropdownsFor<OrderListItem>();
        }
    }
}