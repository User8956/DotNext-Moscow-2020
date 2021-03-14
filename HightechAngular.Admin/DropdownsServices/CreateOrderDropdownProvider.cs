using System;
using System.Threading.Tasks;
using HightechAngular.Admin.Areas.OrderManagement;
using Infrastructure.SwaggerSchema.Dropdowns;

namespace Infrastructure.SwaggerSchema.Dropdowns.Providers
{
    public class CreateOrderDropdownProvider : IDropdownProvider<AllOrdersItem>
    {
        private readonly IServiceProvider _serviceProvider;

        public CreateOrderDropdownProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<Dropdowns> GetDropdownOptionsAsync()
        {
            return _serviceProvider.DropdownsFor<AllOrdersItem>();
        }
    }
}