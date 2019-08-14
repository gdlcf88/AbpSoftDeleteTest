using System;
using System.Linq;
using System.Threading.Tasks;
using SoftDeleteTest.Orders.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SoftDeleteTest.Orders
{
    public class OrderAppService : ApplicationService, IOrderAppService
    {
        private readonly IRepository<Order, Guid> _orderRepository;

        public OrderAppService(
            IRepository<Order, Guid> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<OrderDto> ReplaceOrderItemTestAsync()
        {
            // cannot use ToListAsync, see: https://github.com/abpframework/abp/issues/1570
            var orders = _orderRepository.WithDetails(d => d.OrderItems).ToList();

            var order = orders.FirstOrDefault();
            if (order == null) throw new ApplicationException();

            var orderItem = order.OrderItems.FirstOrDefault();
            if (orderItem == null) throw new ApplicationException();

            order.OrderItems.Remove(orderItem);

            await _orderRepository.UpdateAsync(order, true);

            return ObjectMapper.Map<Order, OrderDto>(order);
        }
    }
}