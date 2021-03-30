

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
    /// See <see cref="TP_TaskListEntityPermissions" /> for all permission names. TP_TaskListEntity
    ///</summary>
    public class TP_TaskListEntityAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public TP_TaskListEntityAuthorizationProvider()
        {

        }


        public TP_TaskListEntityAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public TP_TaskListEntityAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            // 在这里配置了TP_TaskListEntity 的权限。
            //			var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

            //			var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

            //			var tP_TaskListEntity = administration.CreateChildPermission(TP_TaskListEntityPermissions.TP_TaskListEntity_Node , L("TP_TaskListEntity"));
            //tP_TaskListEntity.CreateChildPermission(TP_TaskListEntityPermissions.TP_TaskListEntity_Query, L("QueryTP_TaskListEntity"));
            //tP_TaskListEntity.CreateChildPermission(TP_TaskListEntityPermissions.TP_TaskListEntity_Create, L("CreateTP_TaskListEntity"));
            //tP_TaskListEntity.CreateChildPermission(TP_TaskListEntityPermissions.TP_TaskListEntity_Edit, L("EditTP_TaskListEntity"));
            //tP_TaskListEntity.CreateChildPermission(TP_TaskListEntityPermissions.TP_TaskListEntity_Delete, L("DeleteTP_TaskListEntity"));
            //tP_TaskListEntity.CreateChildPermission(TP_TaskListEntityPermissions.TP_TaskListEntity_BatchDelete, L("BatchDeleteTP_TaskListEntity"));
            //tP_TaskListEntity.CreateChildPermission(TP_TaskListEntityPermissions.TP_TaskListEntity_ExportExcel, L("ExportToExcel"));


            //// custom codes



            //// custom codes end
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpConsts.LocalizationSourceName);
        }
    }
}
