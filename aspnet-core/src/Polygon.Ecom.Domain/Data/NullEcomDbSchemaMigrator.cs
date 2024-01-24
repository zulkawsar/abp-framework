using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Polygon.Ecom.Data;

/* This is used if database provider does't define
 * IEcomDbSchemaMigrator implementation.
 */
public class NullEcomDbSchemaMigrator : IEcomDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
