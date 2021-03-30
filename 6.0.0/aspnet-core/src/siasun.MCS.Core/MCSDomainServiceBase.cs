

using Abp.Domain.Services;

namespace siasun.MCS
{
	public abstract class MCSDomainServiceBase : DomainService
	{
		/* Add your common members for all your domain services. */
		/*在领域服务中添加你的自定义公共方法*/





		protected MCSDomainServiceBase()
		{
			LocalizationSourceName = MCSConsts.LocalizationSourceName;
		}
	}
}
