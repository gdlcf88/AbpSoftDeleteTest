using System.Threading.Tasks;

namespace SoftDeleteTest.Data
{
    public interface ISoftDeleteTestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
