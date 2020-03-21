using Volo.Abp.Modularity;
using EasyAbp.Abp.TencentCloud.TestBase;

namespace EasyAbp.Abp.TencentCloud.CloudMonitor.Tests
{
    [DependsOn(typeof(AbpTencentCloudCloudMonitorModule),
        typeof(AbpTencentCloudTestBaseModule))]
    public class AbpTencentCloudCloudMonitorTestsModule : AbpModule
    {
    }
}