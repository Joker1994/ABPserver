

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
    /// See <see cref="TP_TaskLogEntityPermissions" /> for all permission names. TP_TaskLogEntity
    ///</summary>
    public class TP_TaskLogEntityAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public TP_TaskLogEntityAuthorizationProvider()
        {

        }


        public TP_TaskLogEntityAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public TP_TaskLogEntityAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            // 在这里配置了TP_TaskLogEntity 的权限。
            //			var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

            //			var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

            //			var tP_TaskLogEntity = administration.CreateChildPermission(TP_TaskLogEntityPermissions.TP_TaskLogEntity_Node , L("TP_TaskLogEntity"));
            //tP_TaskLogEntity.CreateChildPermission(TP_TaskLogEntityPermissions.TP_TaskLogEntity_Query, L("QueryTP_TaskLogEntity"));
            //tP_TaskLogEntity.CreateChildPermission(TP_TaskLogEntityPermissions.TP_TaskLogEntity_Create, L("CreateTP_TaskLogEntity"));
            //tP_TaskLogEntity.CreateChildPermission(TP_TaskLogEntityPermissions.TP_TaskLogEntity_Edit, L("EditTP_TaskLogEntity"));
            //tP_TaskLogEntity.CreateChildPermission(TP_TaskLogEntityPermissions.TP_TaskLogEntity_Delete, L("DeleteTP_TaskLogEntity"));
            //tP_TaskLogEntity.CreateChildPermission(TP_TaskLogEntityPermissions.TP_TaskLogEntity_BatchDelete, L("BatchDeleteTP_TaskLogEntity"));
            //tP_TaskLogEntity.CreateChildPermission(TP_TaskLogEntityPermissions.TP_TaskLogEntity_ExportExcel, L("ExportToExcel"));


            //// custom codes



            //// custom codes end
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpConsts.LocalizationSourceName);
        }
    }
}
