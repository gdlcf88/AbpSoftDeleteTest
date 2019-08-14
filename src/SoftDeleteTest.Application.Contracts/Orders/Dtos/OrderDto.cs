using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace SoftDeleteTest.Orders.Dtos
{
    public class OrderDto : AuditedEntityDto<Guid>
    {
        public List<OrderItemDto> OrderItems { get; set; }
    }

    public class OrderItemDto : AuditedEntityDto<Guid>
    {
        public string Remark { get; set; }
    }
}