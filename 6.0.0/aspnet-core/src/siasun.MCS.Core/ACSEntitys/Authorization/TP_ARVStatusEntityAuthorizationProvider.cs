

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
    /// See <see cref="TP_ARVStatusEntityPermissions" /> for all permission names. TP_ARVStatusEntity
    ///</summary>
    public class TP_ARVStatusEntityAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

		public TP_ARVStatusEntityAuthorizationProvider()
		{

		}

       
        public TP_ARVStatusEntityAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public TP_ARVStatusEntityAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

		public override void SetPermissions(IPermissionDefinitionContext context)
		{
            // 在这里配置了TP_ARVStatusEntity 的权限。
            //var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

            //var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

            //var tP_ARVStatusEntity = administration.CreateChildPermission(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Node, L("TP_ARVStatusEntity"));
            //tP_ARVStatusEntity.CreateChildPermission(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Query, L("QueryTP_ARVStatusEntity"));
            //tP_ARVStatusEntity.CreateChildPermission(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Create, L("CreateTP_ARVStatusEntity"));
            //tP_ARVStatusEntity.CreateChildPermission(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Edit, L("EditTP_ARVStatusEntity"));
            //tP_ARVStatusEntity.CreateChildPermission(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_Delete, L("DeleteTP_ARVStatusEntity"));
            //tP_ARVStatusEntity.CreateChildPermission(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_BatchDelete, L("BatchDeleteTP_ARVStatusEntity"));
            //tP_ARVStatusEntity.CreateChildPermission(TP_ARVStatusEntityPermissions.TP_ARVStatusEntity_ExportExcel, L("ExportToExcel"));


            //// custom codes



            //// custom codes end
        }

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, AbpConsts.LocalizationSourceName);
		}
    }
}
