using Volo.Abp.Modularity;
using Zony.Abp.TencentCloudSdk.TestBase;

namespace Zony.Abp.TencentCloudSdk.CloudMonitor.Tests
{
    [DependsOn(typeof(AbpTencentCloudSdkCloudMonitorModule),
        typeof(AbpTencentCloudSdkTestBaseModule))]
    public class AbpTencentCloudSdkCloudMonitorTestsModule : AbpModule
    {
    }
}