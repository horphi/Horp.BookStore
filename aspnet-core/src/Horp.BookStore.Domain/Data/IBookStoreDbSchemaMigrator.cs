using System.Threading.Tasks;

namespace Horp.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
