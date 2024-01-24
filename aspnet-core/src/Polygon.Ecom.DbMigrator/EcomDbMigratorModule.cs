using Polygon.Ecom.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Polygon.Ecom.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EcomEntityFrameworkCoreModule),
    typeof(EcomApplicationContractsModule)
    )]
public class EcomDbMigratorModule : AbpModule
{
}
