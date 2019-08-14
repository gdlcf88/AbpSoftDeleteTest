using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace SoftDeleteTest.Orders
{
    public class OrderDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Order, Guid> _orderRepository;

        public OrderDataSeedContributor(
            IRepository<Order, Guid> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [UnitOfWork]
        public virtual async Task SeedAsync(DataSeedContext context)
        {
            await SeedTestOrderDataAsync();
        }

        private async Task SeedTestOrderDataAsync()
        {
            var orders = await _orderRepository.GetListAsync();

            var order = orders.FirstOrDefault();

            if (order == null)
            {
                order = await _orderRepository.InsertAsync(new Order(Guid.Empty), true);
            }

            if (order.OrderItems.Count == 0)
            {
                order.AddOrderItem("test remark");
                await _orderRepository.UpdateAsync(order, true);
            }
        }
    }
}
