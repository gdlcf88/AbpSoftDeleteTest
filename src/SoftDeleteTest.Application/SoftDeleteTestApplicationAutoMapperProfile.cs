using AutoMapper;
using SoftDeleteTest.Orders;
using SoftDeleteTest.Orders.Dtos;

namespace SoftDeleteTest
{
    public class SoftDeleteTestApplicationAutoMapperProfile : Profile
    {
        public SoftDeleteTestApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Order, OrderDto>();
            CreateMap<OrderItem, OrderItemDto>();
        }
    }
}
