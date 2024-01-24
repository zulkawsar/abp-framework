using Volo.Abp.Settings;

namespace Polygon.Ecom.Settings;

public class EcomSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EcomSettings.MySetting1));
    }
}
