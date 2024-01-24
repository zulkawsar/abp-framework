using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Polygon.Ecom;

[Dependency(ReplaceServices = true)]
public class EcomBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Ecom";
}
