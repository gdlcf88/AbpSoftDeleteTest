using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftDeleteTest.Orders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace SoftDeleteTest.EntityFrameworkCore
{
    public static class SoftDeleteTestDbContextModelCreatingExtensions
    {
        public static void ConfigureSoftDeleteTest(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(SoftDeleteTestConsts.DbTablePrefix + "YourEntities", SoftDeleteTestConsts.DbSchema);

            //    //...
            //});

            builder.Entity<Order>(b =>
            {
                b.ToTable(SoftDeleteTestConsts.DbTablePrefix + "Orders", SoftDeleteTestConsts.DbSchema);
                b.ConfigureFullAuditedAggregateRoot();
            });

            builder.Entity<OrderItem>(b =>
            {
                b.ToTable(SoftDeleteTestConsts.DbTablePrefix + "OrderItems", SoftDeleteTestConsts.DbSchema);
                b.TryConfigureFullAudited();
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}