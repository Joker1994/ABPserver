

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
    /// See <see cref="TP_OrderListEntityPermissions" /> for all permission names. TP_OrderListEntity
    ///</summary>
    public class TP_OrderListEntityAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

		public TP_OrderListEntityAuthorizationProvider()
		{

		}

       
        public TP_OrderListEntityAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public TP_OrderListEntityAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了TP_OrderListEntity 的权限。
//			var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

//			var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

//			var tP_OrderListEntity = administration.CreateChildPermission(TP_OrderListEntityPermissions.TP_OrderListEntity_Node , L("TP_OrderListEntity"));
//tP_OrderListEntity.CreateChildPermission(TP_OrderListEntityPermissions.TP_OrderListEntity_Query, L("QueryTP_OrderListEntity"));
//tP_OrderListEntity.CreateChildPermission(TP_OrderListEntityPermissions.TP_OrderListEntity_Create, L("CreateTP_OrderListEntity"));
//tP_OrderListEntity.CreateChildPermission(TP_OrderListEntityPermissions.TP_OrderListEntity_Edit, L("EditTP_OrderListEntity"));
//tP_OrderListEntity.CreateChildPermission(TP_OrderListEntityPermissions.TP_OrderListEntity_Delete, L("DeleteTP_OrderListEntity"));
//tP_OrderListEntity.CreateChildPermission(TP_OrderListEntityPermissions.TP_OrderListEntity_BatchDelete, L("BatchDeleteTP_OrderListEntity"));
//tP_OrderListEntity.CreateChildPermission(TP_OrderListEntityPermissions.TP_OrderListEntity_ExportExcel, L("ExportToExcel"));

			
							//// custom codes
									
							

							//// custom codes end
		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, AbpConsts.LocalizationSourceName);
		}
    }
}
