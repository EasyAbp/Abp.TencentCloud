using Volo.Abp.Modularity;
using EasyAbp.Abp.TencentCloud.Common;

namespace EasyAbp.Abp.TencentCloud.CloudLive
{
    [DependsOn(typeof(AbpTencentCloudCommonModule))]
    public class AbpTencentCloudCloudLiveModule : AbpModule
    {
    }
}