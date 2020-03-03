using Volo.Abp.Modularity;
using Zony.Abp.TencentCloudSdk.TestBase;

namespace Zony.Abp.TencentCloudSdk.CloudLive.Tests
{
    [DependsOn(typeof(AbpTencentCloudSdkTestBaseModule)
        , typeof(AbpTencentCloudSdkCloudLiveModule))]
    public class AbpTencentCloudSdkCloudLiveTestsModule : AbpModule
    {
    }
}