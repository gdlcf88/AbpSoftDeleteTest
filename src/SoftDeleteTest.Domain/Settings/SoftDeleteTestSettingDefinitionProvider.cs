using Volo.Abp.Settings;

namespace SoftDeleteTest.Settings
{
    public class SoftDeleteTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(SoftDeleteTestSettings.MySetting1));
        }
    }
}
