using System;
using System.Threading.Tasks;
using SoftDeleteTest.Orders.Dtos;
using Volo.Abp.Application.Services;

namespace SoftDeleteTest.Orders
{
    public interface IOrderAppService : IApplicationService
    {
        Task<OrderDto> ReplaceOrderItemTestAsync();
    }
}