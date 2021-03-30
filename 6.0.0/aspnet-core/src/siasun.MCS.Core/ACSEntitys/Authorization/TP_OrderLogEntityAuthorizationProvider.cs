

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
    /// See <see cref="TP_OrderLogEntityPermissions" /> for all permission names. TP_OrderLogEntity
    ///</summary>
    public class TP_OrderLogEntityAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public TP_OrderLogEntityAuthorizationProvider()
        {

        }


        public TP_OrderLogEntityAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public TP_OrderLogEntityAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            // 在这里配置了TP_OrderLogEntity 的权限。
            //			var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

            //			var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

            //			var tP_OrderLogEntity = administration.CreateChildPermission(TP_OrderLogEntityPermissions.TP_OrderLogEntity_Node , L("TP_OrderLogEntity"));
            //tP_OrderLogEntity.CreateChildPermission(TP_OrderLogEntityPermissions.TP_OrderLogEntity_Query, L("QueryTP_OrderLogEntity"));
            //tP_OrderLogEntity.CreateChildPermission(TP_OrderLogEntityPermissions.TP_OrderLogEntity_Create, L("CreateTP_OrderLogEntity"));
            //tP_OrderLogEntity.CreateChildPermission(TP_OrderLogEntityPermissions.TP_OrderLogEntity_Edit, L("EditTP_OrderLogEntity"));
            //tP_OrderLogEntity.CreateChildPermission(TP_OrderLogEntityPermissions.TP_OrderLogEntity_Delete, L("DeleteTP_OrderLogEntity"));
            //tP_OrderLogEntity.CreateChildPermission(TP_OrderLogEntityPermissions.TP_OrderLogEntity_BatchDelete, L("BatchDeleteTP_OrderLogEntity"));
            //tP_OrderLogEntity.CreateChildPermission(TP_OrderLogEntityPermissions.TP_OrderLogEntity_ExportExcel, L("ExportToExcel"));


            //// custom codes



            //// custom codes end
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpConsts.LocalizationSourceName);
        }
    }
}
