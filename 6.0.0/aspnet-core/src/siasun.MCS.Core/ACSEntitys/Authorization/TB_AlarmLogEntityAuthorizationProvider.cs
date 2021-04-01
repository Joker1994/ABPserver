

using System.Linq;
using Abp;
using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MultiTenancy;
using siasun.MCS.Authorization;

// ReSharper disable once CheckNamespace
namespace siasun.MCS.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="TB_AlarmLogEntityPermissions" /> for all permission names. TB_AlarmLogEntity
    ///</summary>
    public class TB_AlarmLogEntityAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public TB_AlarmLogEntityAuthorizationProvider()
        {

        }


        public TB_AlarmLogEntityAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public TB_AlarmLogEntityAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            // 在这里配置了TB_AlarmLogEntity 的权限。
            //			var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

            //			var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

            //			var tB_AlarmLogEntity = administration.CreateChildPermission(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Node , L("TB_AlarmLogEntity"));
            //tB_AlarmLogEntity.CreateChildPermission(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Query, L("QueryTB_AlarmLogEntity"));
            //tB_AlarmLogEntity.CreateChildPermission(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Create, L("CreateTB_AlarmLogEntity"));
            //tB_AlarmLogEntity.CreateChildPermission(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Edit, L("EditTB_AlarmLogEntity"));
            //tB_AlarmLogEntity.CreateChildPermission(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_Delete, L("DeleteTB_AlarmLogEntity"));
            //tB_AlarmLogEntity.CreateChildPermission(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_BatchDelete, L("BatchDeleteTB_AlarmLogEntity"));
            //tB_AlarmLogEntity.CreateChildPermission(TB_AlarmLogEntityPermissions.TB_AlarmLogEntity_ExportExcel, L("ExportToExcel"));


            //// custom codes



            //// custom codes end
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpConsts.LocalizationSourceName);
        }
    }
}
