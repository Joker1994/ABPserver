

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
    /// See <see cref="TB_MapInfoEntityPermissions" /> for all permission names. TB_MapInfoEntity
    ///</summary>
    public class TB_MapInfoEntityAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

		public TB_MapInfoEntityAuthorizationProvider()
		{

		}

       
        public TB_MapInfoEntityAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public TB_MapInfoEntityAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了TB_MapInfoEntity 的权限。
//			var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

//			var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

//			var tB_MapInfoEntity = administration.CreateChildPermission(TB_MapInfoEntityPermissions.TB_MapInfoEntity_Node , L("TB_MapInfoEntity"));
//tB_MapInfoEntity.CreateChildPermission(TB_MapInfoEntityPermissions.TB_MapInfoEntity_Query, L("QueryTB_MapInfoEntity"));
//tB_MapInfoEntity.CreateChildPermission(TB_MapInfoEntityPermissions.TB_MapInfoEntity_Create, L("CreateTB_MapInfoEntity"));
//tB_MapInfoEntity.CreateChildPermission(TB_MapInfoEntityPermissions.TB_MapInfoEntity_Edit, L("EditTB_MapInfoEntity"));
//tB_MapInfoEntity.CreateChildPermission(TB_MapInfoEntityPermissions.TB_MapInfoEntity_Delete, L("DeleteTB_MapInfoEntity"));
//tB_MapInfoEntity.CreateChildPermission(TB_MapInfoEntityPermissions.TB_MapInfoEntity_BatchDelete, L("BatchDeleteTB_MapInfoEntity"));
//tB_MapInfoEntity.CreateChildPermission(TB_MapInfoEntityPermissions.TB_MapInfoEntity_ExportExcel, L("ExportToExcel"));

			
							//// custom codes
									
							

							//// custom codes end
		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, AbpConsts.LocalizationSourceName);
		}
    }
}
