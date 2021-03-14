using System;
using System.Threading.Tasks;
using HightechAngular.Admin.Areas.OrderManagement.PayOrder;
using Infrastructure.SwaggerSchema.Dropdowns;

namespace Infrastructure.SwaggerSchema.Dropdowns.Providers
{
    public class PayOrderDropdownProvider : IDropdownProvider<PayOrderCommand>
    {
        private readonly IServiceProvider _serviceProvider;

        public PayOrderDropdownProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<Dropdowns> GetDropdownOptionsAsync()
        {
            return _serviceProvider.DropdownsFor<PayOrderCommand>();
        }
    }
}