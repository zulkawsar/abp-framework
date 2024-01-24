using Polygon.Ecom.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Polygon.Ecom;

[DependsOn(
    typeof(EcomEntityFrameworkCoreTestModule)
    )]
public class EcomDomainTestModule : AbpModule
{

}
