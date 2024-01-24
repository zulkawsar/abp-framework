using Volo.Abp.Modularity;

namespace Polygon.Ecom;

[DependsOn(
    typeof(EcomApplicationModule),
    typeof(EcomDomainTestModule)
    )]
public class EcomApplicationTestModule : AbpModule
{

}
