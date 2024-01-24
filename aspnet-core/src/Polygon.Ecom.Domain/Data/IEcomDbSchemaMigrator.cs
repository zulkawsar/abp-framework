using System.Threading.Tasks;

namespace Polygon.Ecom.Data;

public interface IEcomDbSchemaMigrator
{
    Task MigrateAsync();
}
