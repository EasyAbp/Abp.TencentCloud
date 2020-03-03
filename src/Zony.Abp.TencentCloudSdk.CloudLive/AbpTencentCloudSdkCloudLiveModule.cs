using Volo.Abp.Modularity;
using Zony.Abp.TencentCloudSdk.Common;

namespace Zony.Abp.TencentCloudSdk.CloudLive
{
    [DependsOn(typeof(AbpTencentCloudSdkCommonModule))]
    public class AbpTencentCloudSdkCloudLiveModule : AbpModule
    {
    }
}