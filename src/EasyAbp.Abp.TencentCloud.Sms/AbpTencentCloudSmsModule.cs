using EasyAbp.Abp.TencentCloud.Common;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.TencentCloud.Sms
{
    [DependsOn(typeof(AbpTencentCloudCommonModule))]
    public class AbpTencentCloudSmsModule : AbpModule
    {
    }
}