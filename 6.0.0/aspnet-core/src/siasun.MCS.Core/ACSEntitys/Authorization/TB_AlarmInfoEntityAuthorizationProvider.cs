

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
    /// See <see cref="TB_AlarmInfoEntityPermissions" /> for all permission names. TB_AlarmInfoEntity
    ///</summary>
    public class TB_AlarmInfoEntityAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

		public TB_AlarmInfoEntityAuthorizationProvider()
		{

		}

       
        public TB_AlarmInfoEntityAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public TB_AlarmInfoEntityAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了TB_AlarmInfoEntity 的权限。
//			var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

//			var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

//			var tB_AlarmInfoEntity = administration.CreateChildPermission(TB_AlarmInfoEntityPermissions.TB_AlarmInfoEntity_Node , L("TB_AlarmInfoEntity"));
//tB_AlarmInfoEntity.CreateChildPermission(TB_AlarmInfoEntityPermissions.TB_AlarmInfoEntity_Query, L("QueryTB_AlarmInfoEntity"));
//tB_AlarmInfoEntity.CreateChildPermission(TB_AlarmInfoEntityPermissions.TB_AlarmInfoEntity_Create, L("CreateTB_AlarmInfoEntity"));
//tB_AlarmInfoEntity.CreateChildPermission(TB_AlarmInfoEntityPermissions.TB_AlarmInfoEntity_Edit, L("EditTB_AlarmInfoEntity"));
//tB_AlarmInfoEntity.CreateChildPermission(TB_AlarmInfoEntityPermissions.TB_AlarmInfoEntity_Delete, L("DeleteTB_AlarmInfoEntity"));
//tB_AlarmInfoEntity.CreateChildPermission(TB_AlarmInfoEntityPermissions.TB_AlarmInfoEntity_BatchDelete, L("BatchDeleteTB_AlarmInfoEntity"));
//tB_AlarmInfoEntity.CreateChildPermission(TB_AlarmInfoEntityPermissions.TB_AlarmInfoEntity_ExportExcel, L("ExportToExcel"));

			
							//// custom codes
									
							

							//// custom codes end
		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, AbpConsts.LocalizationSourceName);
		}
    }
}
