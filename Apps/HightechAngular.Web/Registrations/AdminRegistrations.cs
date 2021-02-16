using HightechAngular.Admin.Features.OrderManagement;
using HightechAngular.Areas.Admin;
using HightechAngular.Areas.Admin.PayOrder;
using HightechAngular.Areas.Shared;
using HightechAngular.Shop.Features.MyOrders;
using Infrastructure.SwaggerSchema.Dropdowns.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace HightechAngular.Admin
{
    public static class AdminRegistrations
    {
        public static void RegisterAdmin(this IServiceCollection services)
        {
            services.AddScoped<IDropdownProvider<PayOrderCommand>, PayOrderDropdownProvider>();
            services.AddScoped<IDropdownProvider<OrderListItem>, OrderListItemDropdownProvider>();
            services.AddScoped<IDropdownProvider<AllOrdersItem>, CreateOrderDropdownProvider>();
        }
    }
}