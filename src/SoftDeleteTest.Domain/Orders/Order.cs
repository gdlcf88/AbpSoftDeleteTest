using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace SoftDeleteTest.Orders
{
    public class Order : FullAuditedAggregateRoot<Guid>
    {
        public virtual List<OrderItem> OrderItems { get; set; }

        protected Order()
        {
            OrderItems = new List<OrderItem>();
        }

        public Order(Guid id)
        {
            Id = id;
            OrderItems = new List<OrderItem>();
        }

        public void AddOrderItem(string remark)
        {
            OrderItems.Add(new OrderItem(Guid.Empty, Id, remark));
        }
    }
}