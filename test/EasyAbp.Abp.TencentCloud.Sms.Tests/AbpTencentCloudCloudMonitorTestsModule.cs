using EasyAbp.Abp.TencentCloud.Sms;
using Volo.Abp.Modularity;
using EasyAbp.Abp.TencentCloud.TestBase;

namespace EasyAbp.Abp.TencentCloud.CloudMonitor.Tests
{
    [DependsOn(typeof(AbpTencentCloudSmsModule),
        typeof(AbpTencentCloudTestBaseModule))]
    public class AbpTencentCloudCloudMonitorTestsModule : AbpModule
    {
    }
}