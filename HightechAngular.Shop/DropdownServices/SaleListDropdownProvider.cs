using System;
using System.Threading.Tasks;
using HightechAngular.Shop.Areas.Index.GetSales;
using Infrastructure.SwaggerSchema.Dropdowns;
using Infrastructure.SwaggerSchema.Dropdowns.Providers;

namespace HightechAngular.Shop.DropdownServices
{
    public class SaleListDropdownProvider : IDropdownProvider<SaleListItem>
    {
        private readonly IServiceProvider _serviceProvider;

        public SaleListDropdownProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<Dropdowns> GetDropdownOptionsAsync()
        {
            return _serviceProvider.DropdownsFor<SaleListItem>();
        }
    }
}