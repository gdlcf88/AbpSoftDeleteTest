using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace SoftDeleteTest.Orders
{
    public class OrderItem : FullAuditedEntity<Guid>
    {
        public Guid OrderId { get; protected set; }
        public Order Order { get; protected set; }

        public virtual string Remark { get; protected set; }

        protected OrderItem() { }

        internal OrderItem(
            Guid id,
            Guid orderId,
            string remark)
        {
            Id = id;
            OrderId = orderId;
            Remark = remark;
        }
    }
}