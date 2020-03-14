using Volo.Abp.Modularity;
using Zony.Abp.TencentCloudSdk.TestBase;

namespace Zony.Abp.TencentCloudSdk.COS.Tests
{
    [DependsOn(typeof(AbpTencentCloudSdkTestBaseModule),
        typeof(AbpTencentCloudSdkCOSModule))]
    public class AbpTencentCloudSdkCOSTestsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpTencentCloudSdkCOSOptions>(op =>
            {
                op.Region = "ap-chengdu";
            });
        }
    }
}