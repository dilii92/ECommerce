﻿
using ECommerce.Api.Products.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Api.Products.Interfaces
{
    public interface IProductProvider
    {
        Task<(bool IsSuccess, IEnumerable<Product> Products, string ErrorMessage)> GetProductAsync();
        Task<(bool IsSuccess, Product Product,  string ErrorMessage)> GetProductAsync(int id);
    }
}
