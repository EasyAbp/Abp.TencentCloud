using Volo.Abp.Modularity;
using EasyAbp.Abp.TencentCloud.TestBase;

namespace EasyAbp.Abp.TencentCloud.CloudLive.Tests
{
    [DependsOn(typeof(AbpTencentCloudTestBaseModule)
        , typeof(AbpTencentCloudCloudLiveModule))]
    public class AbpTencentCloudCloudLiveTestsModule : AbpModule
    {
    }
}