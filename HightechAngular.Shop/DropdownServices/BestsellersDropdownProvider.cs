﻿using System;
using System.Threading.Tasks;
using HightechAngular.Core.Entities;
using HightechAngular.Shop.Areas.Index.GetBestsellers;
using Infrastructure.SwaggerSchema.Dropdowns;
using Infrastructure.SwaggerSchema.Dropdowns.Providers;

namespace HightechAngular.Shop.DropdownServices
{
    public class BestsellersDropdownProvider : IDropdownProvider<BestsellersListItem>
    {
        private readonly IServiceProvider _serviceProvider;

        public BestsellersDropdownProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<Dropdowns> GetDropdownOptionsAsync()
        {
            return _serviceProvider.DropdownsFor<BestsellersListItem>();
        }
    }
}