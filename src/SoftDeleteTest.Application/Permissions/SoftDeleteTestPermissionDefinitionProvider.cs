using SoftDeleteTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SoftDeleteTest.Permissions
{
    public class SoftDeleteTestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SoftDeleteTestPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(SoftDeleteTestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SoftDeleteTestResource>(name);
        }
    }
}
