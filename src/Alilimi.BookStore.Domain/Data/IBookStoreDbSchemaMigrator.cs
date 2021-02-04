using System.Threading.Tasks;

namespace Alilimi.BookStore.Data
{
    public interface IBookStoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
