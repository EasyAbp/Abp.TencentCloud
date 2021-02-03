using EasyAbp.Abp.TencentCloud.TestBase;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.TencentCloud.Sms.Tests
{
    [DependsOn(typeof(AbpTencentCloudSmsModule),
        typeof(AbpTencentCloudTestBaseModule))]
    public class AbpTencentCloudSmsTestsModule : AbpModule
    {
    }
}