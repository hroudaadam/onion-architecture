﻿using Onion.Application.Services.Models.Item;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Onion.Application.Services.Abstractions
{
    public interface IItemService
    {
        Task<IList<ItemRes>> ListAsync();
        Task<ItemRes> GetAsync(Guid itemId);
        Task<ItemRes> CreateAsync(ItemReq model);
        Task<ItemRes> DeleteAsync(Guid itemId);
        Task<ItemRes> UpdateAsync(Guid itemId, ItemReq model);

        Task<bool> FooAsync();
    }
}
